namespace AxisHarness
{
    partial class Form1
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
            this.IpList = new System.Windows.Forms.ComboBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.txtAxis1 = new System.Windows.Forms.TextBox();
            this.txtAxis2 = new System.Windows.Forms.TextBox();
            this.txtAxis3 = new System.Windows.Forms.TextBox();
            this.cmdXYZ = new System.Windows.Forms.RadioButton();
            this.cmdPQR = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbParameterID = new System.Windows.Forms.ComboBox();
            this.txtParam1 = new System.Windows.Forms.TextBox();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.txtParam3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGet1 = new System.Windows.Forms.Button();
            this.cmdGet2 = new System.Windows.Forms.Button();
            this.cmdGet3 = new System.Windows.Forms.Button();
            this.cmdSet3 = new System.Windows.Forms.Button();
            this.cmdSet2 = new System.Windows.Forms.Button();
            this.cmdSet1 = new System.Windows.Forms.Button();
            this.cmdGetAll = new System.Windows.Forms.Button();
            this.cmdSetAll = new System.Windows.Forms.Button();
            this.cmdHome = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.bigLabel = new System.Windows.Forms.Label();
            this.cmdEnable = new System.Windows.Forms.Button();
            this.cmdDisable = new System.Windows.Forms.Button();
            this.lblParameter = new System.Windows.Forms.Label();
            this.txtReturn1 = new System.Windows.Forms.TextBox();
            this.txtReturn3 = new System.Windows.Forms.TextBox();
            this.txtReturn2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSelectMode = new System.Windows.Forms.CheckBox();
            this.radSec2 = new System.Windows.Forms.RadioButton();
            this.radSec3 = new System.Windows.Forms.RadioButton();
            this.radPrimary = new System.Windows.Forms.RadioButton();
            this.radSec1 = new System.Windows.Forms.RadioButton();
            this.grpSelectMode = new System.Windows.Forms.GroupBox();
            this.cmdDock = new System.Windows.Forms.Button();
            this.txtReturn4 = new System.Windows.Forms.MaskedTextBox();
            this.cmbSelectStrut = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpSelectMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpList
            // 
            this.IpList.FormattingEnabled = true;
            this.IpList.Location = new System.Drawing.Point(30, 25);
            this.IpList.Name = "IpList";
            this.IpList.Size = new System.Drawing.Size(121, 21);
            this.IpList.TabIndex = 0;
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(175, 25);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(97, 20);
            this.cmdConnect.TabIndex = 1;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = false;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // txtAxis1
            // 
            this.txtAxis1.Location = new System.Drawing.Point(302, 25);
            this.txtAxis1.Name = "txtAxis1";
            this.txtAxis1.Size = new System.Drawing.Size(22, 20);
            this.txtAxis1.TabIndex = 2;
            this.txtAxis1.Text = "X";
            this.txtAxis1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAxis2
            // 
            this.txtAxis2.Location = new System.Drawing.Point(330, 25);
            this.txtAxis2.Name = "txtAxis2";
            this.txtAxis2.Size = new System.Drawing.Size(21, 20);
            this.txtAxis2.TabIndex = 3;
            this.txtAxis2.Text = "Y";
            this.txtAxis2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAxis3
            // 
            this.txtAxis3.Location = new System.Drawing.Point(356, 25);
            this.txtAxis3.Name = "txtAxis3";
            this.txtAxis3.Size = new System.Drawing.Size(22, 20);
            this.txtAxis3.TabIndex = 4;
            this.txtAxis3.Text = "Z";
            this.txtAxis3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdXYZ
            // 
            this.cmdXYZ.AutoSize = true;
            this.cmdXYZ.Checked = true;
            this.cmdXYZ.Location = new System.Drawing.Point(8, 8);
            this.cmdXYZ.Name = "cmdXYZ";
            this.cmdXYZ.Size = new System.Drawing.Size(46, 17);
            this.cmdXYZ.TabIndex = 5;
            this.cmdXYZ.TabStop = true;
            this.cmdXYZ.Text = "XYZ";
            this.cmdXYZ.UseVisualStyleBackColor = true;
            this.cmdXYZ.CheckedChanged += new System.EventHandler(this.cmdXYZ_CheckedChanged);
            // 
            // cmdPQR
            // 
            this.cmdPQR.AutoSize = true;
            this.cmdPQR.Location = new System.Drawing.Point(8, 25);
            this.cmdPQR.Name = "cmdPQR";
            this.cmdPQR.Size = new System.Drawing.Size(48, 17);
            this.cmdPQR.TabIndex = 6;
            this.cmdPQR.Text = "PQR";
            this.cmdPQR.UseVisualStyleBackColor = true;
            this.cmdPQR.CheckedChanged += new System.EventHandler(this.cmdPQR_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPQR);
            this.groupBox1.Controls.Add(this.cmdXYZ);
            this.groupBox1.Location = new System.Drawing.Point(404, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(61, 45);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmbParameterID
            // 
            this.cmbParameterID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbParameterID.DropDownHeight = 450;
            this.cmbParameterID.FormattingEnabled = true;
            this.cmbParameterID.IntegralHeight = false;
            this.cmbParameterID.Location = new System.Drawing.Point(242, 106);
            this.cmbParameterID.MaxDropDownItems = 40;
            this.cmbParameterID.Name = "cmbParameterID";
            this.cmbParameterID.Size = new System.Drawing.Size(242, 21);
            this.cmbParameterID.Sorted = true;
            this.cmbParameterID.TabIndex = 8;
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(30, 142);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(99, 20);
            this.txtParam1.TabIndex = 9;
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(30, 168);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(99, 20);
            this.txtParam2.TabIndex = 10;
            // 
            // txtParam3
            // 
            this.txtParam3.Location = new System.Drawing.Point(30, 194);
            this.txtParam3.Name = "txtParam3";
            this.txtParam3.Size = new System.Drawing.Size(99, 20);
            this.txtParam3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Value";
            // 
            // cmdGet1
            // 
            this.cmdGet1.Location = new System.Drawing.Point(149, 140);
            this.cmdGet1.Name = "cmdGet1";
            this.cmdGet1.Size = new System.Drawing.Size(58, 24);
            this.cmdGet1.TabIndex = 13;
            this.cmdGet1.Text = "Get";
            this.cmdGet1.UseVisualStyleBackColor = true;
            this.cmdGet1.Click += new System.EventHandler(this.cmdGet1_Click);
            // 
            // cmdGet2
            // 
            this.cmdGet2.Location = new System.Drawing.Point(149, 167);
            this.cmdGet2.Name = "cmdGet2";
            this.cmdGet2.Size = new System.Drawing.Size(58, 24);
            this.cmdGet2.TabIndex = 14;
            this.cmdGet2.Text = "Get";
            this.cmdGet2.UseVisualStyleBackColor = true;
            this.cmdGet2.Click += new System.EventHandler(this.cmdGet2_Click);
            // 
            // cmdGet3
            // 
            this.cmdGet3.Location = new System.Drawing.Point(149, 193);
            this.cmdGet3.Name = "cmdGet3";
            this.cmdGet3.Size = new System.Drawing.Size(58, 24);
            this.cmdGet3.TabIndex = 15;
            this.cmdGet3.Text = "Get";
            this.cmdGet3.UseVisualStyleBackColor = true;
            this.cmdGet3.Click += new System.EventHandler(this.cmdGet3_Click);
            // 
            // cmdSet3
            // 
            this.cmdSet3.Location = new System.Drawing.Point(214, 193);
            this.cmdSet3.Name = "cmdSet3";
            this.cmdSet3.Size = new System.Drawing.Size(58, 24);
            this.cmdSet3.TabIndex = 18;
            this.cmdSet3.Text = "Set";
            this.cmdSet3.UseVisualStyleBackColor = true;
            this.cmdSet3.Click += new System.EventHandler(this.cmdSet3_Click);
            // 
            // cmdSet2
            // 
            this.cmdSet2.Location = new System.Drawing.Point(214, 167);
            this.cmdSet2.Name = "cmdSet2";
            this.cmdSet2.Size = new System.Drawing.Size(58, 24);
            this.cmdSet2.TabIndex = 17;
            this.cmdSet2.Text = "Set";
            this.cmdSet2.UseVisualStyleBackColor = true;
            this.cmdSet2.Click += new System.EventHandler(this.cmdSet2_Click);
            // 
            // cmdSet1
            // 
            this.cmdSet1.Location = new System.Drawing.Point(214, 140);
            this.cmdSet1.Name = "cmdSet1";
            this.cmdSet1.Size = new System.Drawing.Size(58, 24);
            this.cmdSet1.TabIndex = 16;
            this.cmdSet1.Text = "Set";
            this.cmdSet1.UseVisualStyleBackColor = true;
            this.cmdSet1.Click += new System.EventHandler(this.cmdSet1_Click);
            // 
            // cmdGetAll
            // 
            this.cmdGetAll.Location = new System.Drawing.Point(149, 223);
            this.cmdGetAll.Name = "cmdGetAll";
            this.cmdGetAll.Size = new System.Drawing.Size(58, 24);
            this.cmdGetAll.TabIndex = 19;
            this.cmdGetAll.Text = "Get All";
            this.cmdGetAll.UseVisualStyleBackColor = true;
            this.cmdGetAll.Click += new System.EventHandler(this.cmdGetAll_Click);
            // 
            // cmdSetAll
            // 
            this.cmdSetAll.Location = new System.Drawing.Point(214, 223);
            this.cmdSetAll.Name = "cmdSetAll";
            this.cmdSetAll.Size = new System.Drawing.Size(58, 24);
            this.cmdSetAll.TabIndex = 20;
            this.cmdSetAll.Text = "Set All";
            this.cmdSetAll.UseVisualStyleBackColor = true;
            this.cmdSetAll.Click += new System.EventHandler(this.cmdSetAll_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Location = new System.Drawing.Point(390, 140);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(94, 38);
            this.cmdHome.TabIndex = 21;
            this.cmdHome.Text = "HOME";
            this.cmdHome.UseVisualStyleBackColor = true;
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(290, 140);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(94, 38);
            this.cmdReset.TabIndex = 23;
            this.cmdReset.Text = "Clear Errors";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // bigLabel
            // 
            this.bigLabel.AutoSize = true;
            this.bigLabel.ForeColor = System.Drawing.Color.Red;
            this.bigLabel.Location = new System.Drawing.Point(68, 253);
            this.bigLabel.Name = "bigLabel";
            this.bigLabel.Size = new System.Drawing.Size(0, 13);
            this.bigLabel.TabIndex = 25;
            // 
            // cmdEnable
            // 
            this.cmdEnable.Location = new System.Drawing.Point(303, 202);
            this.cmdEnable.Name = "cmdEnable";
            this.cmdEnable.Size = new System.Drawing.Size(75, 38);
            this.cmdEnable.TabIndex = 26;
            this.cmdEnable.Text = "Enable Drive";
            this.cmdEnable.UseVisualStyleBackColor = true;
            this.cmdEnable.Click += new System.EventHandler(this.cmdEnable_Click);
            // 
            // cmdDisable
            // 
            this.cmdDisable.Location = new System.Drawing.Point(395, 202);
            this.cmdDisable.Name = "cmdDisable";
            this.cmdDisable.Size = new System.Drawing.Size(75, 38);
            this.cmdDisable.TabIndex = 27;
            this.cmdDisable.Text = "Disable Drive";
            this.cmdDisable.UseVisualStyleBackColor = true;
            this.cmdDisable.Click += new System.EventHandler(this.cmdDisable_Click);
            // 
            // lblParameter
            // 
            this.lblParameter.AutoSize = true;
            this.lblParameter.Location = new System.Drawing.Point(172, 109);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(58, 13);
            this.lblParameter.TabIndex = 28;
            this.lblParameter.Text = "Parameter:";
            // 
            // txtReturn1
            // 
            this.txtReturn1.Enabled = false;
            this.txtReturn1.Location = new System.Drawing.Point(26, 40);
            this.txtReturn1.Name = "txtReturn1";
            this.txtReturn1.Size = new System.Drawing.Size(121, 20);
            this.txtReturn1.TabIndex = 29;
            // 
            // txtReturn3
            // 
            this.txtReturn3.Enabled = false;
            this.txtReturn3.Location = new System.Drawing.Point(345, 40);
            this.txtReturn3.Name = "txtReturn3";
            this.txtReturn3.Size = new System.Drawing.Size(121, 20);
            this.txtReturn3.TabIndex = 30;
            this.txtReturn3.TextChanged += new System.EventHandler(this.txtReturn3_TextChanged);
            // 
            // txtReturn2
            // 
            this.txtReturn2.Enabled = false;
            this.txtReturn2.Location = new System.Drawing.Point(184, 40);
            this.txtReturn2.Name = "txtReturn2";
            this.txtReturn2.Size = new System.Drawing.Size(121, 20);
            this.txtReturn2.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtReturn3);
            this.groupBox2.Controls.Add(this.txtReturn1);
            this.groupBox2.Controls.Add(this.txtReturn2);
            this.groupBox2.Location = new System.Drawing.Point(4, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 67);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return Codes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Axis 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Axis 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Axis 1";
            // 
            // chkSelectMode
            // 
            this.chkSelectMode.AutoSize = true;
            this.chkSelectMode.Location = new System.Drawing.Point(36, 53);
            this.chkSelectMode.Name = "chkSelectMode";
            this.chkSelectMode.Size = new System.Drawing.Size(89, 17);
            this.chkSelectMode.TabIndex = 40;
            this.chkSelectMode.Text = "Select Mode:";
            this.chkSelectMode.UseVisualStyleBackColor = true;
            this.chkSelectMode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radSec2
            // 
            this.radSec2.AutoSize = true;
            this.radSec2.Location = new System.Drawing.Point(227, 13);
            this.radSec2.Name = "radSec2";
            this.radSec2.Size = new System.Drawing.Size(85, 17);
            this.radSec2.TabIndex = 37;
            this.radSec2.TabStop = true;
            this.radSec2.Text = "Secondary 2";
            this.radSec2.UseVisualStyleBackColor = true;
            this.radSec2.CheckedChanged += new System.EventHandler(this.radSec2_CheckedChanged);
            // 
            // radSec3
            // 
            this.radSec3.AutoSize = true;
            this.radSec3.Location = new System.Drawing.Point(343, 13);
            this.radSec3.Name = "radSec3";
            this.radSec3.Size = new System.Drawing.Size(85, 17);
            this.radSec3.TabIndex = 38;
            this.radSec3.TabStop = true;
            this.radSec3.Text = "Secondary 3";
            this.radSec3.UseVisualStyleBackColor = true;
            this.radSec3.CheckedChanged += new System.EventHandler(this.radSec3_CheckedChanged);
            // 
            // radPrimary
            // 
            this.radPrimary.AutoSize = true;
            this.radPrimary.Location = new System.Drawing.Point(22, 13);
            this.radPrimary.Name = "radPrimary";
            this.radPrimary.Size = new System.Drawing.Size(59, 17);
            this.radPrimary.TabIndex = 35;
            this.radPrimary.TabStop = true;
            this.radPrimary.Text = "Primary";
            this.radPrimary.UseVisualStyleBackColor = true;
            // 
            // radSec1
            // 
            this.radSec1.AutoSize = true;
            this.radSec1.Location = new System.Drawing.Point(115, 13);
            this.radSec1.Name = "radSec1";
            this.radSec1.Size = new System.Drawing.Size(85, 17);
            this.radSec1.TabIndex = 36;
            this.radSec1.TabStop = true;
            this.radSec1.Text = "Secondary 1";
            this.radSec1.UseVisualStyleBackColor = true;
            this.radSec1.CheckedChanged += new System.EventHandler(this.radSec1_CheckedChanged);
            // 
            // grpSelectMode
            // 
            this.grpSelectMode.Controls.Add(this.radSec1);
            this.grpSelectMode.Controls.Add(this.radPrimary);
            this.grpSelectMode.Controls.Add(this.radSec3);
            this.grpSelectMode.Controls.Add(this.radSec2);
            this.grpSelectMode.Location = new System.Drawing.Point(30, 63);
            this.grpSelectMode.Name = "grpSelectMode";
            this.grpSelectMode.Size = new System.Drawing.Size(440, 36);
            this.grpSelectMode.TabIndex = 39;
            this.grpSelectMode.TabStop = false;
            // 
            // cmdDock
            // 
            this.cmdDock.Location = new System.Drawing.Point(214, 250);
            this.cmdDock.Name = "cmdDock";
            this.cmdDock.Size = new System.Drawing.Size(87, 29);
            this.cmdDock.TabIndex = 41;
            this.cmdDock.Text = "Dock System";
            this.cmdDock.UseVisualStyleBackColor = true;
            this.cmdDock.Click += new System.EventHandler(this.cmdDock_Click);
            // 
            // txtReturn4
            // 
            this.txtReturn4.Location = new System.Drawing.Point(373, 255);
            this.txtReturn4.Name = "txtReturn4";
            this.txtReturn4.Size = new System.Drawing.Size(113, 20);
            this.txtReturn4.TabIndex = 42;
            // 
            // cmbSelectStrut
            // 
            this.cmbSelectStrut.FormattingEnabled = true;
            this.cmbSelectStrut.Items.AddRange(new object[] {
            "P",
            "Q",
            "R"});
            this.cmbSelectStrut.Location = new System.Drawing.Point(308, 253);
            this.cmbSelectStrut.Name = "cmbSelectStrut";
            this.cmbSelectStrut.Size = new System.Drawing.Size(59, 21);
            this.cmbSelectStrut.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 353);
            this.Controls.Add(this.cmbSelectStrut);
            this.Controls.Add(this.txtReturn4);
            this.Controls.Add(this.cmdDock);
            this.Controls.Add(this.chkSelectMode);
            this.Controls.Add(this.grpSelectMode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblParameter);
            this.Controls.Add(this.cmdDisable);
            this.Controls.Add(this.cmdEnable);
            this.Controls.Add(this.bigLabel);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.cmdSetAll);
            this.Controls.Add(this.cmdGetAll);
            this.Controls.Add(this.cmdSet3);
            this.Controls.Add(this.cmdSet2);
            this.Controls.Add(this.cmdSet1);
            this.Controls.Add(this.cmdGet3);
            this.Controls.Add(this.cmdGet2);
            this.Controls.Add(this.cmdGet1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParam3);
            this.Controls.Add(this.txtParam2);
            this.Controls.Add(this.txtParam1);
            this.Controls.Add(this.cmbParameterID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAxis3);
            this.Controls.Add(this.txtAxis2);
            this.Controls.Add(this.txtAxis1);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.IpList);
            this.Name = "Form1";
            this.Text = "Axis Harness";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpSelectMode.ResumeLayout(false);
            this.grpSelectMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IpList;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.TextBox txtAxis1;
        private System.Windows.Forms.TextBox txtAxis2;
        private System.Windows.Forms.TextBox txtAxis3;
        private System.Windows.Forms.RadioButton cmdXYZ;
        private System.Windows.Forms.RadioButton cmdPQR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbParameterID;
        private System.Windows.Forms.TextBox txtParam1;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.TextBox txtParam3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGet1;
        private System.Windows.Forms.Button cmdGet2;
        private System.Windows.Forms.Button cmdGet3;
        private System.Windows.Forms.Button cmdSet3;
        private System.Windows.Forms.Button cmdSet2;
        private System.Windows.Forms.Button cmdSet1;
        private System.Windows.Forms.Button cmdGetAll;
        private System.Windows.Forms.Button cmdSetAll;
        private System.Windows.Forms.Button cmdHome;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Label bigLabel;
        private System.Windows.Forms.Button cmdEnable;
        private System.Windows.Forms.Button cmdDisable;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.TextBox txtReturn1;
        private System.Windows.Forms.TextBox txtReturn3;
        private System.Windows.Forms.TextBox txtReturn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSelectMode;
        private System.Windows.Forms.RadioButton radSec2;
        private System.Windows.Forms.RadioButton radSec3;
        private System.Windows.Forms.RadioButton radPrimary;
        private System.Windows.Forms.RadioButton radSec1;
        private System.Windows.Forms.GroupBox grpSelectMode;
        private System.Windows.Forms.Button cmdDock;
        private System.Windows.Forms.MaskedTextBox txtReturn4;
        private System.Windows.Forms.ComboBox cmbSelectStrut;
    }
}

