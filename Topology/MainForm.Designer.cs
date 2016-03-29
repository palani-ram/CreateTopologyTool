namespace Topology
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.geodatabaseConnectButton = new System.Windows.Forms.Button();
            this.fgdbTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.townFCTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.schoolFCTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTopologyNameTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datasetName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.municipalFCTextbox = new System.Windows.Forms.TextBox();
            this.countyFCTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createTopology = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.geodatabaseConnectButton);
            this.panel1.Controls.Add(this.fgdbTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 96);
            this.panel1.TabIndex = 3;
            // 
            // geodatabaseConnectButton
            // 
            this.geodatabaseConnectButton.Location = new System.Drawing.Point(625, 26);
            this.geodatabaseConnectButton.Name = "geodatabaseConnectButton";
            this.geodatabaseConnectButton.Size = new System.Drawing.Size(102, 23);
            this.geodatabaseConnectButton.TabIndex = 8;
            this.geodatabaseConnectButton.Text = "Connect";
            this.geodatabaseConnectButton.UseVisualStyleBackColor = true;
            this.geodatabaseConnectButton.Click += new System.EventHandler(this.geodatabaseConnectButton_Click);
            // 
            // fgdbTextBox
            // 
            this.fgdbTextBox.Location = new System.Drawing.Point(196, 28);
            this.fgdbTextBox.Name = "fgdbTextBox";
            this.fgdbTextBox.Size = new System.Drawing.Size(409, 21);
            this.fgdbTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Path to File Geodatabase:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.townFCTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.schoolFCTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.outputTopologyNameTextbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.datasetName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.municipalFCTextbox);
            this.panel2.Controls.Add(this.countyFCTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.createTopology);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Enabled = false;
            this.panel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 241);
            this.panel2.TabIndex = 4;
            // 
            // townFCTextBox
            // 
            this.townFCTextBox.Location = new System.Drawing.Point(278, 114);
            this.townFCTextBox.Name = "townFCTextBox";
            this.townFCTextBox.Size = new System.Drawing.Size(311, 21);
            this.townFCTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Town:";
            // 
            // schoolFCTextBox
            // 
            this.schoolFCTextBox.Location = new System.Drawing.Point(278, 82);
            this.schoolFCTextBox.Name = "schoolFCTextBox";
            this.schoolFCTextBox.Size = new System.Drawing.Size(311, 21);
            this.schoolFCTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "School:";
            // 
            // outputTopologyNameTextbox
            // 
            this.outputTopologyNameTextbox.Location = new System.Drawing.Point(278, 178);
            this.outputTopologyNameTextbox.Name = "outputTopologyNameTextbox";
            this.outputTopologyNameTextbox.Size = new System.Drawing.Size(311, 21);
            this.outputTopologyNameTextbox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Output Topology Name:";
            // 
            // datasetName
            // 
            this.datasetName.Location = new System.Drawing.Point(278, 146);
            this.datasetName.Name = "datasetName";
            this.datasetName.Size = new System.Drawing.Size(311, 21);
            this.datasetName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dataset Name:";
            // 
            // municipalFCTextbox
            // 
            this.municipalFCTextbox.Location = new System.Drawing.Point(278, 50);
            this.municipalFCTextbox.Name = "municipalFCTextbox";
            this.municipalFCTextbox.Size = new System.Drawing.Size(311, 21);
            this.municipalFCTextbox.TabIndex = 13;
            // 
            // countyFCTextbox
            // 
            this.countyFCTextbox.Location = new System.Drawing.Point(278, 23);
            this.countyFCTextbox.Name = "countyFCTextbox";
            this.countyFCTextbox.Size = new System.Drawing.Size(311, 21);
            this.countyFCTextbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "County:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Municipal:";
            // 
            // createTopology
            // 
            this.createTopology.Location = new System.Drawing.Point(458, 214);
            this.createTopology.Name = "createTopology";
            this.createTopology.Size = new System.Drawing.Size(131, 23);
            this.createTopology.TabIndex = 19;
            this.createTopology.Text = "Create Topology";
            this.createTopology.UseVisualStyleBackColor = true;
            this.createTopology.Click += new System.EventHandler(this.createTopology_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 368);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 50);
            this.panel3.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(829, 418);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "Topology";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button createTopology;
        private System.Windows.Forms.Button geodatabaseConnectButton;
        private System.Windows.Forms.TextBox fgdbTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox municipalFCTextbox;
        private System.Windows.Forms.TextBox countyFCTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox datasetName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputTopologyNameTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox schoolFCTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox townFCTextBox;
        private System.Windows.Forms.Label label7;
    }
}

