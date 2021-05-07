namespace ThePicturesOfChaos
{
    partial class FractalDrawingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnProperties = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbLineLength = new System.Windows.Forms.Label();
            this.nUpDLineLength = new System.Windows.Forms.NumericUpDown();
            this.cbFitFractal = new System.Windows.Forms.CheckBox();
            this.lbLineWidth = new System.Windows.Forms.Label();
            this.nUpDLineWidth = new System.Windows.Forms.NumericUpDown();
            this.btnResetFractal = new System.Windows.Forms.Button();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnNextIteration = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pbFractalSpace = new System.Windows.Forms.PictureBox();
            this.pnProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDLineLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFractalSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // pnProperties
            // 
            this.pnProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(155)))), ((int)(((byte)(151)))));
            this.pnProperties.Controls.Add(this.btnSave);
            this.pnProperties.Controls.Add(this.lbLineLength);
            this.pnProperties.Controls.Add(this.nUpDLineLength);
            this.pnProperties.Controls.Add(this.cbFitFractal);
            this.pnProperties.Controls.Add(this.lbLineWidth);
            this.pnProperties.Controls.Add(this.nUpDLineWidth);
            this.pnProperties.Controls.Add(this.btnResetFractal);
            this.pnProperties.Controls.Add(this.btnLineColor);
            this.pnProperties.Controls.Add(this.btnBackgroundColor);
            this.pnProperties.Controls.Add(this.btnNextIteration);
            this.pnProperties.Location = new System.Drawing.Point(0, 651);
            this.pnProperties.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(1053, 30);
            this.pnProperties.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(123)))), ((int)(((byte)(117)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.ForeColor = System.Drawing.Color.Linen;
            this.btnSave.Location = new System.Drawing.Point(36, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // lbLineLength
            // 
            this.lbLineLength.AutoSize = true;
            this.lbLineLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbLineLength.Location = new System.Drawing.Point(782, 6);
            this.lbLineLength.Name = "lbLineLength";
            this.lbLineLength.Size = new System.Drawing.Size(82, 18);
            this.lbLineLength.TabIndex = 10;
            this.lbLineLength.Text = "Line length:";
            // 
            // nUpDLineLength
            // 
            this.nUpDLineLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(155)))), ((int)(((byte)(151)))));
            this.nUpDLineLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUpDLineLength.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDLineLength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nUpDLineLength.Location = new System.Drawing.Point(863, 7);
            this.nUpDLineLength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUpDLineLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDLineLength.Name = "nUpDLineLength";
            this.nUpDLineLength.ReadOnly = true;
            this.nUpDLineLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUpDLineLength.Size = new System.Drawing.Size(44, 20);
            this.nUpDLineLength.TabIndex = 9;
            this.nUpDLineLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDLineLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDLineLength.ValueChanged += new System.EventHandler(this.LineLengthValueChanged);
            // 
            // cbFitFractal
            // 
            this.cbFitFractal.AutoSize = true;
            this.cbFitFractal.Checked = true;
            this.cbFitFractal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFitFractal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbFitFractal.Location = new System.Drawing.Point(926, 5);
            this.cbFitFractal.Name = "cbFitFractal";
            this.cbFitFractal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbFitFractal.Size = new System.Drawing.Size(91, 22);
            this.cbFitFractal.TabIndex = 8;
            this.cbFitFractal.Text = "Fit  fractal";
            this.cbFitFractal.UseVisualStyleBackColor = true;
            this.cbFitFractal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnFitFractalMouseClicked);
            // 
            // lbLineWidth
            // 
            this.lbLineWidth.AutoSize = true;
            this.lbLineWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbLineWidth.Location = new System.Drawing.Point(643, 5);
            this.lbLineWidth.Name = "lbLineWidth";
            this.lbLineWidth.Size = new System.Drawing.Size(77, 18);
            this.lbLineWidth.TabIndex = 7;
            this.lbLineWidth.Text = "Line width:";
            // 
            // nUpDLineWidth
            // 
            this.nUpDLineWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(155)))), ((int)(((byte)(151)))));
            this.nUpDLineWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUpDLineWidth.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDLineWidth.Location = new System.Drawing.Point(719, 6);
            this.nUpDLineWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDLineWidth.Name = "nUpDLineWidth";
            this.nUpDLineWidth.ReadOnly = true;
            this.nUpDLineWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUpDLineWidth.Size = new System.Drawing.Size(44, 20);
            this.nUpDLineWidth.TabIndex = 6;
            this.nUpDLineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnResetFractal
            // 
            this.btnResetFractal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(123)))), ((int)(((byte)(117)))));
            this.btnResetFractal.FlatAppearance.BorderSize = 0;
            this.btnResetFractal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFractal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnResetFractal.ForeColor = System.Drawing.Color.Linen;
            this.btnResetFractal.Location = new System.Drawing.Point(353, 1);
            this.btnResetFractal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnResetFractal.Name = "btnResetFractal";
            this.btnResetFractal.Size = new System.Drawing.Size(165, 30);
            this.btnResetFractal.TabIndex = 5;
            this.btnResetFractal.Text = "Reset fractal";
            this.btnResetFractal.UseVisualStyleBackColor = false;
            // 
            // btnLineColor
            // 
            this.btnLineColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(123)))), ((int)(((byte)(117)))));
            this.btnLineColor.FlatAppearance.BorderSize = 0;
            this.btnLineColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLineColor.ForeColor = System.Drawing.Color.Linen;
            this.btnLineColor.Location = new System.Drawing.Point(515, 1);
            this.btnLineColor.Margin = new System.Windows.Forms.Padding(25, 0, 3, 3);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(108, 30);
            this.btnLineColor.TabIndex = 4;
            this.btnLineColor.Text = "Line color";
            this.btnLineColor.UseVisualStyleBackColor = false;
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(123)))), ((int)(((byte)(117)))));
            this.btnBackgroundColor.FlatAppearance.BorderSize = 0;
            this.btnBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBackgroundColor.ForeColor = System.Drawing.Color.Linen;
            this.btnBackgroundColor.Location = new System.Drawing.Point(102, 1);
            this.btnBackgroundColor.Margin = new System.Windows.Forms.Padding(3, 0, 25, 3);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(143, 30);
            this.btnBackgroundColor.TabIndex = 3;
            this.btnBackgroundColor.Text = "Background color";
            this.btnBackgroundColor.UseVisualStyleBackColor = false;
            // 
            // btnNextIteration
            // 
            this.btnNextIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(123)))), ((int)(((byte)(117)))));
            this.btnNextIteration.FlatAppearance.BorderSize = 0;
            this.btnNextIteration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNextIteration.ForeColor = System.Drawing.Color.Linen;
            this.btnNextIteration.Location = new System.Drawing.Point(241, 1);
            this.btnNextIteration.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnNextIteration.Name = "btnNextIteration";
            this.btnNextIteration.Size = new System.Drawing.Size(113, 30);
            this.btnNextIteration.TabIndex = 2;
            this.btnNextIteration.Text = "Draw";
            this.btnNextIteration.UseVisualStyleBackColor = false;
            // 
            // pbFractalSpace
            // 
            this.pbFractalSpace.Location = new System.Drawing.Point(0, 0);
            this.pbFractalSpace.Name = "pbFractalSpace";
            this.pbFractalSpace.Size = new System.Drawing.Size(1053, 653);
            this.pbFractalSpace.TabIndex = 1;
            this.pbFractalSpace.TabStop = false;
            // 
            // FractalDrawingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.pbFractalSpace);
            this.Controls.Add(this.pnProperties);
            this.Name = "FractalDrawingControl";
            this.Size = new System.Drawing.Size(1053, 682);
            this.pnProperties.ResumeLayout(false);
            this.pnProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDLineLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFractalSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnProperties;
        private System.Windows.Forms.Button btnNextIteration;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Button btnResetFractal;
        private System.Windows.Forms.Label lbLineWidth;
        private System.Windows.Forms.NumericUpDown nUpDLineWidth;
        private System.Windows.Forms.CheckBox cbFitFractal;
        private System.Windows.Forms.Label lbLineLength;
        private System.Windows.Forms.NumericUpDown nUpDLineLength;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pbFractalSpace;
    }
}
