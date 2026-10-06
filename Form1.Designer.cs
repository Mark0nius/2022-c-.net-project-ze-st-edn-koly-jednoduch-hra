namespace _31_Jevický
{
    partial class AppWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_IMG = new System.Windows.Forms.Panel();
            this.button_change = new System.Windows.Forms.Button();
            this.button_diff = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_time = new System.Windows.Forms.Button();
            this.numericUpDown_eror = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_time = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_eror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_IMG
            // 
            this.panel_IMG.Location = new System.Drawing.Point(0, 0);
            this.panel_IMG.Name = "panel_IMG";
            this.panel_IMG.Size = new System.Drawing.Size(300, 300);
            this.panel_IMG.TabIndex = 0;
            this.panel_IMG.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_IMG_Paint);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(51, 307);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 1;
            this.button_change.Text = "IMG SWAP";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.Button_change_Click);
            // 
            // button_diff
            // 
            this.button_diff.Location = new System.Drawing.Point(51, 362);
            this.button_diff.Name = "button_diff";
            this.button_diff.Size = new System.Drawing.Size(75, 23);
            this.button_diff.TabIndex = 0;
            this.button_diff.Text = "SEND";
            this.button_diff.UseVisualStyleBackColor = true;
            this.button_diff.Click += new System.EventHandler(this.Button_diff_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2500;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // button_time
            // 
            this.button_time.Location = new System.Drawing.Point(203, 336);
            this.button_time.Name = "button_time";
            this.button_time.Size = new System.Drawing.Size(75, 23);
            this.button_time.TabIndex = 4;
            this.button_time.Text = "SET TIMER";
            this.button_time.UseVisualStyleBackColor = true;
            this.button_time.Click += new System.EventHandler(this.Button_time_Click);
            // 
            // numericUpDown_eror
            // 
            this.numericUpDown_eror.Location = new System.Drawing.Point(71, 336);
            this.numericUpDown_eror.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_eror.Name = "numericUpDown_eror";
            this.numericUpDown_eror.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_eror.TabIndex = 5;
            this.numericUpDown_eror.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_time
            // 
            this.numericUpDown_time.Location = new System.Drawing.Point(158, 339);
            this.numericUpDown_time.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_time.Name = "numericUpDown_time";
            this.numericUpDown_time.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_time.TabIndex = 6;
            this.numericUpDown_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 462);
            this.Controls.Add(this.numericUpDown_time);
            this.Controls.Add(this.numericUpDown_eror);
            this.Controls.Add(this.button_time);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_diff);
            this.Controls.Add(this.panel_IMG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AppWindow";
            this.Text = "AppWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_eror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_IMG;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_diff;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_time;
        private System.Windows.Forms.NumericUpDown numericUpDown_eror;
        private System.Windows.Forms.NumericUpDown numericUpDown_time;
    }
}

