namespace VFRNavSim
{
    partial class PointSelector
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lblWaypointSelectedName = new System.Windows.Forms.Label();
            this._btnCancle = new System.Windows.Forms.Button();
            this._lblWaypointSelectedLatitude = new System.Windows.Forms.Label();
            this._btnOk = new System.Windows.Forms.Button();
            this._lblWaypointSelectedLongitude = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._dgvWaypointsList = new System.Windows.Forms.DataGridView();
            this._gmpVfrMap = new GMap.NET.WindowsForms.GMapControl();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this._txtWaypointSearch = new VFRNavSim.Custom_Controls.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvWaypointsList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.elementHost1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this._dgvWaypointsList);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._gmpVfrMap);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1028, 653);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.groupBox1.Controls.Add(this._lblWaypointSelectedName);
            this.groupBox1.Controls.Add(this._btnCancle);
            this.groupBox1.Controls.Add(this._lblWaypointSelectedLatitude);
            this.groupBox1.Controls.Add(this._btnOk);
            this.groupBox1.Controls.Add(this._lblWaypointSelectedLongitude);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "נקודה מסומנת";
            // 
            // _lblWaypointSelectedName
            // 
            this._lblWaypointSelectedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblWaypointSelectedName.AutoSize = true;
            this._lblWaypointSelectedName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblWaypointSelectedName.Location = new System.Drawing.Point(167, 18);
            this._lblWaypointSelectedName.Name = "_lblWaypointSelectedName";
            this._lblWaypointSelectedName.Size = new System.Drawing.Size(13, 17);
            this._lblWaypointSelectedName.TabIndex = 4;
            this._lblWaypointSelectedName.Text = "-";
            // 
            // _btnCancle
            // 
            this._btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancle.BackColor = System.Drawing.Color.DimGray;
            this._btnCancle.Location = new System.Drawing.Point(178, 62);
            this._btnCancle.Name = "_btnCancle";
            this._btnCancle.Size = new System.Drawing.Size(75, 29);
            this._btnCancle.TabIndex = 3;
            this._btnCancle.Text = "בטל";
            this._btnCancle.UseVisualStyleBackColor = false;
            this._btnCancle.Click += new System.EventHandler(this._btnCancle_Click);
            // 
            // _lblWaypointSelectedLatitude
            // 
            this._lblWaypointSelectedLatitude.AutoSize = true;
            this._lblWaypointSelectedLatitude.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblWaypointSelectedLatitude.Location = new System.Drawing.Point(6, 44);
            this._lblWaypointSelectedLatitude.Name = "_lblWaypointSelectedLatitude";
            this._lblWaypointSelectedLatitude.Size = new System.Drawing.Size(13, 17);
            this._lblWaypointSelectedLatitude.TabIndex = 4;
            this._lblWaypointSelectedLatitude.Text = "-";
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.BackColor = System.Drawing.Color.DimGray;
            this._btnOk.Location = new System.Drawing.Point(259, 62);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 2;
            this._btnOk.Text = "אישור";
            this._btnOk.UseVisualStyleBackColor = false;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // _lblWaypointSelectedLongitude
            // 
            this._lblWaypointSelectedLongitude.AutoSize = true;
            this._lblWaypointSelectedLongitude.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblWaypointSelectedLongitude.Location = new System.Drawing.Point(167, 44);
            this._lblWaypointSelectedLongitude.Name = "_lblWaypointSelectedLongitude";
            this._lblWaypointSelectedLongitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblWaypointSelectedLongitude.Size = new System.Drawing.Size(13, 17);
            this._lblWaypointSelectedLongitude.TabIndex = 4;
            this._lblWaypointSelectedLongitude.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "חפש";
            // 
            // _dgvWaypointsList
            // 
            this._dgvWaypointsList.AllowUserToAddRows = false;
            this._dgvWaypointsList.AllowUserToDeleteRows = false;
            this._dgvWaypointsList.AllowUserToOrderColumns = true;
            this._dgvWaypointsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvWaypointsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._dgvWaypointsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvWaypointsList.Location = new System.Drawing.Point(3, 32);
            this._dgvWaypointsList.Name = "_dgvWaypointsList";
            this._dgvWaypointsList.ReadOnly = true;
            this._dgvWaypointsList.Size = new System.Drawing.Size(335, 522);
            this._dgvWaypointsList.TabIndex = 1;
            this._dgvWaypointsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvWaypointsList_CellClick);
            this._dgvWaypointsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvWaypointsList_CellDoubleClick);
            this._dgvWaypointsList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._dgvWaypointsList_KeyPress);
            // 
            // _gmpVfrMap
            // 
            this._gmpVfrMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gmpVfrMap.Bearing = 0F;
            this._gmpVfrMap.CanDragMap = true;
            this._gmpVfrMap.EmptyTileColor = System.Drawing.Color.Navy;
            this._gmpVfrMap.GrayScaleMode = false;
            this._gmpVfrMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this._gmpVfrMap.LevelsKeepInMemmory = 5;
            this._gmpVfrMap.Location = new System.Drawing.Point(12, 12);
            this._gmpVfrMap.MarkersEnabled = true;
            this._gmpVfrMap.MaxZoom = 2;
            this._gmpVfrMap.MinZoom = 2;
            this._gmpVfrMap.MouseWheelZoomEnabled = true;
            this._gmpVfrMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this._gmpVfrMap.Name = "_gmpVfrMap";
            this._gmpVfrMap.NegativeMode = false;
            this._gmpVfrMap.PolygonsEnabled = true;
            this._gmpVfrMap.RetryLoadTile = 0;
            this._gmpVfrMap.RoutesEnabled = true;
            this._gmpVfrMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this._gmpVfrMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this._gmpVfrMap.ShowTileGridLines = false;
            this._gmpVfrMap.Size = new System.Drawing.Size(660, 629);
            this._gmpVfrMap.TabIndex = 0;
            this._gmpVfrMap.TabStop = false;
            this._gmpVfrMap.Zoom = 0D;
            this._gmpVfrMap.DoubleClick += new System.EventHandler(this._gmpVfrMap_DoubleClick);
            this._gmpVfrMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this._gmpVfrMap_MouseDown);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(3, 6);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(290, 20);
            this.elementHost1.TabIndex = 6;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this._txtWaypointSearch;
            // 
            // PointSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1028, 653);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PointSelector";
            this.Text = "בחר נקודה";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PointSelector_FormClosing);
            this.Load += new System.EventHandler(this.PointSelector_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvWaypointsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button _btnCancle;
        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.DataGridView _dgvWaypointsList;
        private GMap.NET.WindowsForms.GMapControl _gmpVfrMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblWaypointSelectedLatitude;
        private System.Windows.Forms.Label _lblWaypointSelectedLongitude;
        private System.Windows.Forms.Label _lblWaypointSelectedName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Custom_Controls.RoundedTextBox _txtWaypointSearch;
    }
}