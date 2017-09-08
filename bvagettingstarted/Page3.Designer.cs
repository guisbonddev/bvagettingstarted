namespace bvagettingstarted
{
    partial class Page3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page3));
            this.sc3op1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sc3op2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sc3op1
            // 
            this.sc3op1.AutoSize = true;
            this.sc3op1.BackColor = System.Drawing.Color.White;
            this.sc3op1.Font = new System.Drawing.Font("Gotham Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc3op1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(118)))), ((int)(((byte)(183)))));
            this.sc3op1.Location = new System.Drawing.Point(22, 159);
            this.sc3op1.Name = "sc3op1";
            this.sc3op1.Size = new System.Drawing.Size(554, 17);
            this.sc3op1.TabIndex = 0;
            this.sc3op1.Text = "Please wait while we search your computer for flight simulator configurations.";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(25, 196);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(551, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // sc3op2
            // 
            this.sc3op2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(118)))), ((int)(((byte)(183)))));
            this.sc3op2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(118)))), ((int)(((byte)(183)))));
            this.sc3op2.FlatAppearance.BorderSize = 0;
            this.sc3op2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(118)))), ((int)(((byte)(183)))));
            this.sc3op2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(138)))), ((int)(((byte)(198)))));
            this.sc3op2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sc3op2.Font = new System.Drawing.Font("Gotham Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc3op2.ForeColor = System.Drawing.Color.White;
            this.sc3op2.Location = new System.Drawing.Point(433, 386);
            this.sc3op2.Name = "sc3op2";
            this.sc3op2.Size = new System.Drawing.Size(143, 37);
            this.sc3op2.TabIndex = 3;
            this.sc3op2.Text = "Continue";
            this.sc3op2.UseVisualStyleBackColor = false;
            // 
            // Page3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.sc3op2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sc3op1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Page3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BVA Getting Started Utility";
            this.Load += new System.EventHandler(this.Page3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sc3op1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button sc3op2;
    }
}