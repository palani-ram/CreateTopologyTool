using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Configuration;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.Carto;
using System.Threading;

namespace Topology
{
    public partial class mainForm : Form
    {
        private IWorkspace _currentWorkspace;
        private string _currentUser;

        private string _NL = Environment.NewLine;
        private const string DATETIMEFORMAT = "dd MMM yyyy, HH:mm:ss";
        private const string REPORTFILEDATETIMEFORMAT = "yyyyMMdd_HHmmss";

        public mainForm()
        {
            InitializeComponent();
            _currentUser = ConfigurationManager.AppSettings["CurrentUser"];

            // load report log on start.
            //RefreshLogDisplay();
        }

        private void createTopology_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(fgdbTextBox.Text))
            {
                MessageBox.Show("Enter file geodatabase path.");
                return;
            }

            if (string.IsNullOrWhiteSpace(countyFCTextbox.Text) || string.IsNullOrWhiteSpace(municipalFCTextbox.Text) ||
                string.IsNullOrWhiteSpace(datasetName.Text) || string.IsNullOrWhiteSpace(outputTopologyNameTextbox.Text))
            {
                MessageBox.Show("Enter county, municipal, output topology and dataset names.");
                return;
            }

            if (string.IsNullOrWhiteSpace(schoolFCTextBox.Text) || string.IsNullOrWhiteSpace(townFCTextBox.Text) ||
                string.IsNullOrWhiteSpace(datasetName.Text) || string.IsNullOrWhiteSpace(outputTopologyNameTextbox.Text))
            {
                MessageBox.Show("Enter school, town, output topology and dataset names.");
                return;
            }

            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)_currentWorkspace;

            if (featureWorkspace == null)
            {
                MessageBox.Show("The inputs you have provided is incorrect.");
                return;
            }

                IFeatureDataset featureDataset = featureWorkspace.OpenFeatureDataset(datasetName.Text);
            IFeatureClass countyFC = featureWorkspace.OpenFeatureClass(countyFCTextbox.Text);
            IFeatureClass municipalFC = featureWorkspace.OpenFeatureClass(municipalFCTextbox.Text);
            IFeatureClass schoolFC = featureWorkspace.OpenFeatureClass(schoolFCTextBox.Text);
            IFeatureClass townFC = featureWorkspace.OpenFeatureClass(townFCTextBox.Text);

            // Attempt to acquire an exclusive schema lock on the feature dataset.
            ISchemaLock schemaLock = (ISchemaLock)featureDataset;
            try
            {
                schemaLock.ChangeSchemaLock(esriSchemaLock.esriExclusiveSchemaLock);

                // Create the topology.
                ITopologyContainer2 topologyContainer = (ITopologyContainer2)featureDataset;
                ITopology topology = topologyContainer.CreateTopology(outputTopologyNameTextbox.Text,
                  topologyContainer.DefaultClusterTolerance, -1, "");

                // Add feature classes and rules to the topology.
                topology.AddClass(countyFC, 5, 1, 1, false);
                topology.AddClass(municipalFC, 5, 1, 1, false);
                topology.AddClass(schoolFC, 5, 1, 1, false);
                topology.AddClass(townFC, 5, 1, 1, false);
                //AddRuleToTopology(topology, esriTopologyRuleType.esriTRTAreaNoOverlap, 
                //  "No Block Overlap", countyFC);

                # region must be convered by feature class of line
                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineCoveredByLineClass,
                  "county Covered by municipal", countyFC, 1, municipalFC, 1);
                # endregion

                # region The rule is a line-no intersection rule
                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoIntersection,
                  "The rule is a line-no intersection rule", countyFC, 1, municipalFC, 1);

                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoIntersection,
                  "The rule is a line-no intersection rule", schoolFC, 1, townFC, 1);
                # endregion

                #region The rule is a line-no dangles rule
                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoDangles,
                  "The rule is a line-no dangles rule", countyFC, 1, municipalFC, 1);

                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoDangles,
                  "The rule is a line-no dangles rule", schoolFC, 1, townFC, 1);
                #endregion

                #region The rule is a line must not intersect with line rule
                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoIntersectLine,
                  "The rule is a line must not intersect with line rule", countyFC, 1, municipalFC, 1);

                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoIntersectLine,
                  "The rule is a line must not intersect with line rule", schoolFC, 1, townFC, 1);
                #endregion

                #region The rule is a line-no overlap line rule
                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoOverlapLine,
                  "The rule is a line-no overlap line rule", countyFC, 1, municipalFC, 1);

                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoOverlapLine,
                  "The rule is a line-no overlap line rule", schoolFC, 1, townFC, 1);
                #endregion

                #region The rule is a line-no self overlap rule
                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoSelfOverlap,
                  "The rule is a line-no self overlap rule", countyFC, 1, municipalFC, 1);

                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoSelfOverlap,
                  "The rule is a line-no overlap line rule", schoolFC, 1, townFC, 1);
                #endregion

                #region The rule is a line must not intersect with line rule
                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoMultipart,
                  "The rule is a line must not intersect with line rule", countyFC, 1, municipalFC, 1);

                AddRuleToTopology(topology,
                  esriTopologyRuleType.esriTRTLineNoMultipart,
                  "The rule is a line must not intersect with line rule", schoolFC, 1, townFC, 1);
                #endregion

                // Get an envelope with the topology's extents and validate the topology.
                IGeoDataset geoDataset = (IGeoDataset)topology;
                IEnvelope envelope = geoDataset.Extent;
                // Validate the Topology
                topology.ValidateTopology(geoDataset.Extent.Envelope);
                //ValidateTopology(topology, envelope);

                MessageBox.Show("Topology Successfully created.");
                Application.Exit();
            }
            catch (COMException comExc)
            {
                MessageBox.Show("Failed to create topology, try again.");
                return;
                //throw new Exception(String.Format(
                //  "Error creating topology: {0} Message: {1}", comExc.ErrorCode,
                //  comExc.Message), comExc);
            }
            finally
            {
                schemaLock.ChangeSchemaLock(esriSchemaLock.esriSharedSchemaLock);
            }
        }

        public void ValidateTopology(ITopology topology, IEnvelope envelope)
        {
            // Get the dirty area within the provided envelope.
            IPolygon locationPolygon = new PolygonClass();
            ISegmentCollection segmentCollection = (ISegmentCollection)locationPolygon;
            segmentCollection.SetRectangle(envelope);
            IPolygon polygon = topology.get_DirtyArea(locationPolygon);

            // If a dirty area exists, validate the topology.
            if (!polygon.IsEmpty)
            {
                // Define the area to validate and validate the topology.
                IEnvelope areaToValidate = polygon.Envelope;
                IEnvelope areaValidated = topology.ValidateTopology(areaToValidate);
            }
        }

        public void AddRuleToTopology(ITopology topology, esriTopologyRuleType ruleType,
                                        String ruleName, IFeatureClass originClass, int originSubtype, IFeatureClass
                                            destinationClass, int destinationSubtype)
        {
            // Create a new topology rule.
            ITopologyRule topologyRule = new TopologyRuleClass();
            topologyRule.TopologyRuleType = ruleType;
            topologyRule.Name = ruleName;
            topologyRule.OriginClassID = originClass.FeatureClassID;
            topologyRule.AllOriginSubtypes = true;
            topologyRule.OriginSubtype = originSubtype;
            topologyRule.DestinationClassID = destinationClass.FeatureClassID;
            topologyRule.AllDestinationSubtypes = true;
            topologyRule.DestinationSubtype = destinationSubtype;

            // Cast the topology to the ITopologyRuleContainer interface and add the rule.
            ITopologyRuleContainer topologyRuleContainer = (ITopologyRuleContainer)
              topology;
            if (topologyRuleContainer.get_CanAddRule(topologyRule))
            {
                topologyRuleContainer.AddRule(topologyRule);
            }
            else
            {
                throw new ArgumentException("Could not add specified rule to the topology.")
                  ;
            }
        }

        public void AddRuleToTopology(ITopology topology, esriTopologyRuleType ruleType,
                                                        String ruleName, IFeatureClass featureClass)
        {
            // Create a new topology rule.
            ITopologyRule topologyRule = new TopologyRuleClass();
            topologyRule.TopologyRuleType = ruleType;
            topologyRule.Name = ruleName;
            topologyRule.OriginClassID = featureClass.FeatureClassID;
            topologyRule.AllOriginSubtypes = true;

            // Cast the topology to the ITopologyRuleContainer interface and add the rule.
            ITopologyRuleContainer topologyRuleContainer = (ITopologyRuleContainer)
              topology;
            if (topologyRuleContainer.get_CanAddRule(topologyRule))
            {
                topologyRuleContainer.AddRule(topologyRule);
            }
            else
            {
                throw new ArgumentException("Could not add specified rule to the topology.")
                  ;
            }
        }

        // For example, path = @"C:\myData\myfGDB.gdb".
        private IWorkspace getFileGdbWorkspaceFromPath(String path)
        {
            Type factoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.FileGDBWorkspaceFactory");
            IWorkspaceFactory workspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(factoryType);

            try
            {
                return workspaceFactory.OpenFromFile(path, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter valid file geodatabase path");
                return null;
            }

        }

        private void geodatabaseConnectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fgdbTextBox.Text))
            {
                MessageBox.Show("Enter file geodatabase path.");
                return;
            }
            // initialize the workspace.
            _currentWorkspace = getFileGdbWorkspaceFromPath(fgdbTextBox.Text);

            //MessageBox.Show("File geodatabase successfully connected.");
            if (_currentWorkspace != null)
                panel2.Enabled = true;
        }

    }
}