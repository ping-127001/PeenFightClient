namespace PeenFightClient.GUI
{
    partial class CFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFrm));
            this.gamePnl = new System.Windows.Forms.Panel();
            this.topPnl = new System.Windows.Forms.Panel();
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.miniBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cheatPnl = new System.Windows.Forms.Panel();
            this.teleportBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invisCheckBox = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.antiaimBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.refreshPage = new Siticone.UI.WinForms.SiticoneButton();
            this.consoleBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.tpX = new Siticone.UI.WinForms.SiticoneTextBox();
            this.tpY = new Siticone.UI.WinForms.SiticoneTextBox();
            this.topPnl.SuspendLayout();
            this.cheatPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePnl
            // 
            this.gamePnl.Location = new System.Drawing.Point(0, 47);
            this.gamePnl.Name = "gamePnl";
            this.gamePnl.Size = new System.Drawing.Size(951, 850);
            this.gamePnl.TabIndex = 0;
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Controls.Add(this.miniBtn);
            this.topPnl.Controls.Add(this.label1);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(1352, 41);
            this.topPnl.TabIndex = 29;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.BorderRadius = 4;
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoveredState.Parent = this.exitBtn;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.exitBtn.Location = new System.Drawing.Point(1304, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 27);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.BorderRadius = 4;
            this.miniBtn.BorderThickness = 2;
            this.miniBtn.CheckedState.Parent = this.miniBtn;
            this.miniBtn.CustomImages.Parent = this.miniBtn;
            this.miniBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.HoveredState.Parent = this.miniBtn;
            this.miniBtn.Image = ((System.Drawing.Image)(resources.GetObject("miniBtn.Image")));
            this.miniBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.miniBtn.Location = new System.Drawing.Point(1253, 3);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(45, 27);
            this.miniBtn.TabIndex = 22;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PeenFight Client";
            // 
            // cheatPnl
            // 
            this.cheatPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.cheatPnl.Controls.Add(this.tpY);
            this.cheatPnl.Controls.Add(this.tpX);
            this.cheatPnl.Controls.Add(this.teleportBtn);
            this.cheatPnl.Controls.Add(this.label5);
            this.cheatPnl.Controls.Add(this.label4);
            this.cheatPnl.Controls.Add(this.label3);
            this.cheatPnl.Controls.Add(this.invisCheckBox);
            this.cheatPnl.Controls.Add(this.antiaimBtn);
            this.cheatPnl.Controls.Add(this.refreshPage);
            this.cheatPnl.Controls.Add(this.consoleBtn);
            this.cheatPnl.Controls.Add(this.label2);
            this.cheatPnl.Location = new System.Drawing.Point(949, 47);
            this.cheatPnl.Name = "cheatPnl";
            this.cheatPnl.Size = new System.Drawing.Size(400, 850);
            this.cheatPnl.TabIndex = 30;
            // 
            // teleportBtn
            // 
            this.teleportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.teleportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.teleportBtn.BorderRadius = 4;
            this.teleportBtn.BorderThickness = 2;
            this.teleportBtn.CheckedState.Parent = this.teleportBtn;
            this.teleportBtn.CustomImages.Parent = this.teleportBtn;
            this.teleportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.teleportBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.teleportBtn.ForeColor = System.Drawing.Color.White;
            this.teleportBtn.HoveredState.Parent = this.teleportBtn;
            this.teleportBtn.Location = new System.Drawing.Point(8, 333);
            this.teleportBtn.Name = "teleportBtn";
            this.teleportBtn.ShadowDecoration.Parent = this.teleportBtn;
            this.teleportBtn.Size = new System.Drawing.Size(111, 37);
            this.teleportBtn.TabIndex = 26;
            this.teleportBtn.Text = "Teleport";
            this.teleportBtn.Click += new System.EventHandler(this.teleportBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(158, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Other";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(158, 762);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Misc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(158, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Toggles";
            // 
            // invisCheckBox
            // 
            this.invisCheckBox.AutoSize = true;
            this.invisCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.invisCheckBox.CheckedState.BorderRadius = 0;
            this.invisCheckBox.CheckedState.BorderThickness = 0;
            this.invisCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.invisCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.invisCheckBox.ForeColor = System.Drawing.Color.White;
            this.invisCheckBox.Location = new System.Drawing.Point(8, 187);
            this.invisCheckBox.Name = "invisCheckBox";
            this.invisCheckBox.Size = new System.Drawing.Size(77, 17);
            this.invisCheckBox.TabIndex = 22;
            this.invisCheckBox.Text = "Invis Hack";
            this.invisCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.invisCheckBox.UncheckedState.BorderRadius = 0;
            this.invisCheckBox.UncheckedState.BorderThickness = 0;
            this.invisCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.invisCheckBox.CheckedChanged += new System.EventHandler(this.invisCheckBox_CheckedChanged);
            // 
            // antiaimBtn
            // 
            this.antiaimBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.antiaimBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.antiaimBtn.BorderRadius = 4;
            this.antiaimBtn.BorderThickness = 2;
            this.antiaimBtn.CheckedState.Parent = this.antiaimBtn;
            this.antiaimBtn.CustomImages.Parent = this.antiaimBtn;
            this.antiaimBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.antiaimBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.antiaimBtn.ForeColor = System.Drawing.Color.White;
            this.antiaimBtn.HoveredState.Parent = this.antiaimBtn;
            this.antiaimBtn.Location = new System.Drawing.Point(8, 27);
            this.antiaimBtn.Name = "antiaimBtn";
            this.antiaimBtn.ShadowDecoration.Parent = this.antiaimBtn;
            this.antiaimBtn.Size = new System.Drawing.Size(111, 37);
            this.antiaimBtn.TabIndex = 21;
            this.antiaimBtn.Text = "Anti Aim";
            this.antiaimBtn.Click += new System.EventHandler(this.antiaimBtn_Click);
            // 
            // refreshPage
            // 
            this.refreshPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.refreshPage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.refreshPage.BorderRadius = 4;
            this.refreshPage.BorderThickness = 2;
            this.refreshPage.CheckedState.Parent = this.refreshPage;
            this.refreshPage.CustomImages.Parent = this.refreshPage;
            this.refreshPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.refreshPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshPage.ForeColor = System.Drawing.Color.White;
            this.refreshPage.HoveredState.Parent = this.refreshPage;
            this.refreshPage.Location = new System.Drawing.Point(120, 807);
            this.refreshPage.Name = "refreshPage";
            this.refreshPage.ShadowDecoration.Parent = this.refreshPage;
            this.refreshPage.Size = new System.Drawing.Size(111, 37);
            this.refreshPage.TabIndex = 20;
            this.refreshPage.Text = "Refresh Page";
            this.refreshPage.Click += new System.EventHandler(this.refreshPage_Click);
            // 
            // consoleBtn
            // 
            this.consoleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.consoleBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.consoleBtn.BorderRadius = 4;
            this.consoleBtn.BorderThickness = 2;
            this.consoleBtn.CheckedState.Parent = this.consoleBtn;
            this.consoleBtn.CustomImages.Parent = this.consoleBtn;
            this.consoleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.consoleBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.consoleBtn.ForeColor = System.Drawing.Color.White;
            this.consoleBtn.HoveredState.Parent = this.consoleBtn;
            this.consoleBtn.Location = new System.Drawing.Point(3, 807);
            this.consoleBtn.Name = "consoleBtn";
            this.consoleBtn.ShadowDecoration.Parent = this.consoleBtn;
            this.consoleBtn.Size = new System.Drawing.Size(111, 37);
            this.consoleBtn.TabIndex = 19;
            this.consoleBtn.Text = "Console";
            this.consoleBtn.Click += new System.EventHandler(this.consoleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(162, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main";
            // 
            // dragCtrl
            // 
            this.dragCtrl.TargetControl = this.topPnl;
            // 
            // tpX
            // 
            this.tpX.Animated = false;
            this.tpX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tpX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tpX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tpX.DefaultText = "";
            this.tpX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tpX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tpX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tpX.DisabledState.Parent = this.tpX;
            this.tpX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tpX.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tpX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tpX.FocusedState.Parent = this.tpX;
            this.tpX.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.tpX.ForeColor = System.Drawing.Color.White;
            this.tpX.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tpX.HoveredState.Parent = this.tpX;
            this.tpX.Location = new System.Drawing.Point(125, 333);
            this.tpX.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpX.Name = "tpX";
            this.tpX.PasswordChar = '\0';
            this.tpX.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tpX.PlaceholderText = "x";
            this.tpX.SelectedText = "";
            this.tpX.ShadowDecoration.Parent = this.tpX;
            this.tpX.Size = new System.Drawing.Size(75, 37);
            this.tpX.TabIndex = 27;
            // 
            // tpY
            // 
            this.tpY.Animated = false;
            this.tpY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tpY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tpY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tpY.DefaultText = "";
            this.tpY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tpY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tpY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tpY.DisabledState.Parent = this.tpY;
            this.tpY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tpY.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tpY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tpY.FocusedState.Parent = this.tpY;
            this.tpY.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.tpY.ForeColor = System.Drawing.Color.White;
            this.tpY.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tpY.HoveredState.Parent = this.tpY;
            this.tpY.Location = new System.Drawing.Point(210, 333);
            this.tpY.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpY.Name = "tpY";
            this.tpY.PasswordChar = '\0';
            this.tpY.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tpY.PlaceholderText = "y";
            this.tpY.SelectedText = "";
            this.tpY.ShadowDecoration.Parent = this.tpY;
            this.tpY.Size = new System.Drawing.Size(75, 37);
            this.tpY.TabIndex = 28;
            // 
            // CFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1352, 903);
            this.Controls.Add(this.cheatPnl);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.gamePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFrm";
            this.Load += new System.EventHandler(this.CFrm_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.cheatPnl.ResumeLayout(false);
            this.cheatPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePnl;
        private System.Windows.Forms.Panel topPnl;
        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        public Siticone.UI.WinForms.SiticoneButton miniBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel cheatPnl;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneDragControl dragCtrl;
        public Siticone.UI.WinForms.SiticoneButton consoleBtn;
        public Siticone.UI.WinForms.SiticoneButton refreshPage;
        public Siticone.UI.WinForms.SiticoneButton antiaimBtn;
        private Siticone.UI.WinForms.SiticoneCheckBox invisCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public Siticone.UI.WinForms.SiticoneButton teleportBtn;
        private Siticone.UI.WinForms.SiticoneTextBox tpX;
        private Siticone.UI.WinForms.SiticoneTextBox tpY;
    }
}