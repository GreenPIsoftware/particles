namespace gravity
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
            this.components = new System.ComponentModel.Container();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.t_Update = new System.Windows.Forms.Timer(this.components);
            this.CB_randrange = new System.Windows.Forms.CheckBox();
            this.NUD_gravity = new System.Windows.Forms.NumericUpDown();
            this.NUD_forcex = new System.Windows.Forms.NumericUpDown();
            this.NUD_forcey = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_clr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_gravity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_forcex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_forcey)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.Black;
            this.Canvas.Location = new System.Drawing.Point(0, 27);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(927, 459);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            // 
            // t_Update
            // 
            this.t_Update.Enabled = true;
            this.t_Update.Interval = 1;
            this.t_Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // CB_randrange
            // 
            this.CB_randrange.AutoSize = true;
            this.CB_randrange.Location = new System.Drawing.Point(542, 7);
            this.CB_randrange.Name = "CB_randrange";
            this.CB_randrange.Size = new System.Drawing.Size(88, 17);
            this.CB_randrange.TabIndex = 1;
            this.CB_randrange.Text = "rand in range";
            this.CB_randrange.UseVisualStyleBackColor = true;
            // 
            // NUD_gravity
            // 
            this.NUD_gravity.DecimalPlaces = 2;
            this.NUD_gravity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.NUD_gravity.Location = new System.Drawing.Point(59, 4);
            this.NUD_gravity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_gravity.Name = "NUD_gravity";
            this.NUD_gravity.Size = new System.Drawing.Size(120, 20);
            this.NUD_gravity.TabIndex = 2;
            this.NUD_gravity.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // NUD_forcex
            // 
            this.NUD_forcex.DecimalPlaces = 2;
            this.NUD_forcex.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.NUD_forcex.Location = new System.Drawing.Point(669, 4);
            this.NUD_forcex.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUD_forcex.Name = "NUD_forcex";
            this.NUD_forcex.Size = new System.Drawing.Size(120, 20);
            this.NUD_forcex.TabIndex = 3;
            // 
            // NUD_forcey
            // 
            this.NUD_forcey.DecimalPlaces = 2;
            this.NUD_forcey.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.NUD_forcey.Location = new System.Drawing.Point(795, 4);
            this.NUD_forcey.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUD_forcey.Name = "NUD_forcey";
            this.NUD_forcey.Size = new System.Drawing.Size(120, 20);
            this.NUD_forcey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "force:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "gravity:";
            // 
            // BTN_clr
            // 
            this.BTN_clr.Location = new System.Drawing.Point(200, 1);
            this.BTN_clr.Name = "BTN_clr";
            this.BTN_clr.Size = new System.Drawing.Size(147, 23);
            this.BTN_clr.TabIndex = 7;
            this.BTN_clr.Text = "Clear";
            this.BTN_clr.UseVisualStyleBackColor = true;
            this.BTN_clr.Click += new System.EventHandler(this.BTN_clr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 484);
            this.Controls.Add(this.BTN_clr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_forcey);
            this.Controls.Add(this.NUD_forcex);
            this.Controls.Add(this.NUD_gravity);
            this.Controls.Add(this.CB_randrange);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_gravity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_forcex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_forcey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Timer t_Update;
        private System.Windows.Forms.CheckBox CB_randrange;
        private System.Windows.Forms.NumericUpDown NUD_gravity;
        private System.Windows.Forms.NumericUpDown NUD_forcex;
        private System.Windows.Forms.NumericUpDown NUD_forcey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_clr;
    }
}

