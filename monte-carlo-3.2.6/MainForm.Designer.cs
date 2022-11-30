namespace monte_carlo
{
    partial class MainForm
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
			this.pB_model = new System.Windows.Forms.PictureBox();
			this.button_start = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pB_model)).BeginInit();
			this.SuspendLayout();
			// 
			// pB_model
			// 
			this.pB_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pB_model.Location = new System.Drawing.Point(12, 12);
			this.pB_model.Name = "pB_model";
			this.pB_model.Size = new System.Drawing.Size(500, 500);
			this.pB_model.TabIndex = 0;
			this.pB_model.TabStop = false;
			// 
			// button_start
			// 
			this.button_start.Location = new System.Drawing.Point(518, 479);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(130, 33);
			this.button_start.TabIndex = 1;
			this.button_start.Text = "Старт";
			this.button_start.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(883, 554);
			this.Controls.Add(this.button_start);
			this.Controls.Add(this.pB_model);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "ИСИТ ННГУ | Двумерный ядерный реактор";
			((System.ComponentModel.ISupportInitialize)(this.pB_model)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_model;
        private System.Windows.Forms.Button button_start;
    }
}