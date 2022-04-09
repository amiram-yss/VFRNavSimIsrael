namespace VFRNavSim
{
    partial class InformationWindow
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
            this._gmpResultMap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnShowInfo = new System.Windows.Forms.Button();
            this._txtPathBearing = new System.Windows.Forms.Label();
            this._txtGagueHeading = new System.Windows.Forms.Label();
            this._txtGagueTimer = new System.Windows.Forms.Label();
            this._txtGagueAltitude = new System.Windows.Forms.Label();
            this._txtGagueSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._lblWind = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gmpResultMap
            // 
            this._gmpResultMap.Bearing = 0F;
            this._gmpResultMap.CanDragMap = true;
            this._gmpResultMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gmpResultMap.EmptyTileColor = System.Drawing.Color.Navy;
            this._gmpResultMap.GrayScaleMode = false;
            this._gmpResultMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this._gmpResultMap.LevelsKeepInMemmory = 5;
            this._gmpResultMap.Location = new System.Drawing.Point(0, 0);
            this._gmpResultMap.MarkersEnabled = true;
            this._gmpResultMap.MaxZoom = 2;
            this._gmpResultMap.MinZoom = 2;
            this._gmpResultMap.MouseWheelZoomEnabled = true;
            this._gmpResultMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this._gmpResultMap.Name = "_gmpResultMap";
            this._gmpResultMap.NegativeMode = false;
            this._gmpResultMap.PolygonsEnabled = true;
            this._gmpResultMap.RetryLoadTile = 0;
            this._gmpResultMap.RoutesEnabled = true;
            this._gmpResultMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this._gmpResultMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this._gmpResultMap.ShowTileGridLines = false;
            this._gmpResultMap.Size = new System.Drawing.Size(410, 326);
            this._gmpResultMap.TabIndex = 1;
            this._gmpResultMap.TabStop = false;
            this._gmpResultMap.Zoom = 0D;
            this._gmpResultMap.Load += new System.EventHandler(this._gmpResultMap_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnShowInfo);
            this.groupBox1.Controls.Add(this._txtPathBearing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtGagueHeading);
            this.groupBox1.Controls.Add(this._txtGagueTimer);
            this.groupBox1.Controls.Add(this._txtGagueAltitude);
            this.groupBox1.Controls.Add(this._txtGagueSpeed);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "לוח המכשירים";
            // 
            // _btnShowInfo
            // 
            this._btnShowInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this._btnShowInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._btnShowInfo.Location = new System.Drawing.Point(6, 68);
            this._btnShowInfo.Name = "_btnShowInfo";
            this._btnShowInfo.Size = new System.Drawing.Size(138, 24);
            this._btnShowInfo.TabIndex = 1;
            this._btnShowInfo.Text = "פתח/ סגור חלון מידע";
            this._btnShowInfo.UseVisualStyleBackColor = false;
            this._btnShowInfo.Click += new System.EventHandler(this._btnShowInfo_Click);
            // 
            // _txtPathBearing
            // 
            this._txtPathBearing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._txtPathBearing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._txtPathBearing.Location = new System.Drawing.Point(6, 22);
            this._txtPathBearing.Name = "_txtPathBearing";
            this._txtPathBearing.Size = new System.Drawing.Size(138, 13);
            this._txtPathBearing.TabIndex = 0;
            this._txtPathBearing.Text = "label1";
            this._txtPathBearing.Click += new System.EventHandler(this._txtGagueHeading_Click);
            // 
            // _txtGagueHeading
            // 
            this._txtGagueHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._txtGagueHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._txtGagueHeading.Location = new System.Drawing.Point(285, 44);
            this._txtGagueHeading.Name = "_txtGagueHeading";
            this._txtGagueHeading.Size = new System.Drawing.Size(116, 13);
            this._txtGagueHeading.TabIndex = 0;
            this._txtGagueHeading.Text = "label1";
            this._txtGagueHeading.Click += new System.EventHandler(this._txtGagueHeading_Click);
            // 
            // _txtGagueTimer
            // 
            this._txtGagueTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._txtGagueTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._txtGagueTimer.Location = new System.Drawing.Point(162, 44);
            this._txtGagueTimer.Name = "_txtGagueTimer";
            this._txtGagueTimer.Size = new System.Drawing.Size(117, 13);
            this._txtGagueTimer.TabIndex = 0;
            this._txtGagueTimer.Text = "label1";
            // 
            // _txtGagueAltitude
            // 
            this._txtGagueAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._txtGagueAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._txtGagueAltitude.Location = new System.Drawing.Point(162, 22);
            this._txtGagueAltitude.Name = "_txtGagueAltitude";
            this._txtGagueAltitude.Size = new System.Drawing.Size(117, 13);
            this._txtGagueAltitude.TabIndex = 0;
            this._txtGagueAltitude.Text = "label1";
            // 
            // _txtGagueSpeed
            // 
            this._txtGagueSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._txtGagueSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._txtGagueSpeed.Location = new System.Drawing.Point(285, 22);
            this._txtGagueSpeed.Name = "_txtGagueSpeed";
            this._txtGagueSpeed.Size = new System.Drawing.Size(116, 13);
            this._txtGagueSpeed.TabIndex = 0;
            this._txtGagueSpeed.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(162, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "במידה והמיקום אינו נטען אוטומטית, לחצו על\r\nCurrent Aircraft Position בתפריט בGoog" +
    "le Earth\r\n";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._lblWind);
            this.splitContainer1.Panel2.Controls.Add(this._gmpResultMap);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(412, 432);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 3;
            // 
            // _lblWind
            // 
            this._lblWind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lblWind.AutoSize = true;
            this._lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._lblWind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._lblWind.Location = new System.Drawing.Point(326, 286);
            this._lblWind.Name = "_lblWind";
            this._lblWind.Size = new System.Drawing.Size(52, 18);
            this._lblWind.TabIndex = 2;
            this._lblWind.Text = "label1";
            // 
            // InformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(412, 432);
            this.Controls.Add(this.splitContainer1);
            this.Name = "InformationWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "חלון תמונת מצב";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InformationWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl _gmpResultMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _txtGagueSpeed;
        private System.Windows.Forms.Label _txtGagueHeading;
        private System.Windows.Forms.Label _txtGagueAltitude;
        private System.Windows.Forms.Label _txtGagueTimer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button _btnShowInfo;
        private System.Windows.Forms.Label _lblWind;
        private System.Windows.Forms.Label _txtPathBearing;
        private System.Windows.Forms.Label label1;
    }
}