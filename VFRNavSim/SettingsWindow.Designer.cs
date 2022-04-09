namespace VFRNavSim
{
    partial class SettingsWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._numMaxTimeOffset = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._numViewAngleDeltaWithTheWind = new System.Windows.Forms.NumericUpDown();
            this._numViewAngleDeltaToTheWind = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this._numWindRangeEnd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this._numWindRangeStart = new System.Windows.Forms.NumericUpDown();
            this._numWindMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this._btnSave = new VFRNavSim.Custom_Controls.RoundedButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numMaxTimeOffset)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numViewAngleDeltaWithTheWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numViewAngleDeltaToTheWind)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numWindRangeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numWindRangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numWindMaxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "הגדרות הדמיית מצב";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._numMaxTimeOffset);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(6, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 77);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "זמן";
            // 
            // _numMaxTimeOffset
            // 
            this._numMaxTimeOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._numMaxTimeOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._numMaxTimeOffset.ForeColor = System.Drawing.Color.White;
            this._numMaxTimeOffset.Location = new System.Drawing.Point(331, 33);
            this._numMaxTimeOffset.Name = "_numMaxTimeOffset";
            this._numMaxTimeOffset.Size = new System.Drawing.Size(120, 20);
            this._numMaxTimeOffset.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "כאשר הזמן נבחר רנדומלית, אפשר חריגה של עד\r\n\r\n\r\nשניות מעבר לזמן הצפוי להגעה לנקודת" +
    " היעד.\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._numViewAngleDeltaWithTheWind);
            this.groupBox2.Controls.Add(this._numViewAngleDeltaToTheWind);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(6, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 91);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "נקודת מבט";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // _numViewAngleDeltaWithTheWind
            // 
            this._numViewAngleDeltaWithTheWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._numViewAngleDeltaWithTheWind.ForeColor = System.Drawing.Color.White;
            this._numViewAngleDeltaWithTheWind.Location = new System.Drawing.Point(12, 63);
            this._numViewAngleDeltaWithTheWind.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this._numViewAngleDeltaWithTheWind.Name = "_numViewAngleDeltaWithTheWind";
            this._numViewAngleDeltaWithTheWind.Size = new System.Drawing.Size(120, 20);
            this._numViewAngleDeltaWithTheWind.TabIndex = 1;
            // 
            // _numViewAngleDeltaToTheWind
            // 
            this._numViewAngleDeltaToTheWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._numViewAngleDeltaToTheWind.ForeColor = System.Drawing.Color.White;
            this._numViewAngleDeltaToTheWind.Location = new System.Drawing.Point(12, 37);
            this._numViewAngleDeltaToTheWind.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this._numViewAngleDeltaToTheWind.Name = "_numViewAngleDeltaToTheWind";
            this._numViewAngleDeltaToTheWind.Size = new System.Drawing.Size(120, 20);
            this._numViewAngleDeltaToTheWind.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "נגד כיוון הרוח (עדיף להכניס פה ערך נמוך יותר)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "לכיוון הרוח:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "הזווית המקסימלית להטיית מצלמה:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this._numWindMaxSpeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "רוח";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this._numWindRangeEnd);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this._numWindRangeStart);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Location = new System.Drawing.Point(6, 58);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(445, 68);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "טווח כיוון רוח (הטווח שיבחר הוא עם כיוון השעון מנקודת התחלת הטווח עד נקודת הסיום)" +
    "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "תחילת טווח:";
            // 
            // _numWindRangeEnd
            // 
            this._numWindRangeEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._numWindRangeEnd.ForeColor = System.Drawing.Color.White;
            this._numWindRangeEnd.Location = new System.Drawing.Point(6, 40);
            this._numWindRangeEnd.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this._numWindRangeEnd.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numWindRangeEnd.Name = "_numWindRangeEnd";
            this._numWindRangeEnd.Size = new System.Drawing.Size(120, 20);
            this._numWindRangeEnd.TabIndex = 4;
            this._numWindRangeEnd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "סיום טווח:";
            // 
            // _numWindRangeStart
            // 
            this._numWindRangeStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._numWindRangeStart.ForeColor = System.Drawing.Color.White;
            this._numWindRangeStart.Location = new System.Drawing.Point(6, 14);
            this._numWindRangeStart.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this._numWindRangeStart.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numWindRangeStart.Name = "_numWindRangeStart";
            this._numWindRangeStart.Size = new System.Drawing.Size(120, 20);
            this._numWindRangeStart.TabIndex = 3;
            this._numWindRangeStart.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _numWindMaxSpeed
            // 
            this._numWindMaxSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._numWindMaxSpeed.ForeColor = System.Drawing.Color.White;
            this._numWindMaxSpeed.Location = new System.Drawing.Point(12, 35);
            this._numWindMaxSpeed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numWindMaxSpeed.Name = "_numWindMaxSpeed";
            this._numWindMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this._numWindMaxSpeed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "כאשר רוח נבחרת באופן רנדומלי:\r\n\r\nמהירות רוח מקסימלית:\r\n";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 367);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(110, 25);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this._btnSave;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(502, 400);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(518, 439);
            this.MinimumSize = new System.Drawing.Size(518, 439);
            this.Name = "SettingsWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הגדרות";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numMaxTimeOffset)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numViewAngleDeltaWithTheWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numViewAngleDeltaToTheWind)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numWindRangeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numWindRangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numWindMaxSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown _numMaxTimeOffset;
        private System.Windows.Forms.NumericUpDown _numViewAngleDeltaToTheWind;
        private System.Windows.Forms.NumericUpDown _numWindRangeEnd;
        private System.Windows.Forms.NumericUpDown _numWindRangeStart;
        private System.Windows.Forms.NumericUpDown _numWindMaxSpeed;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Custom_Controls.RoundedButton _btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _numViewAngleDeltaWithTheWind;
        private System.Windows.Forms.Label label7;
    }
}