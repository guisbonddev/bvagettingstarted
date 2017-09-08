namespace bvagettingstarted
{
    partial class Page2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page2));
            this.sc2op1 = new System.Windows.Forms.LinkLabel();
            this.sc2op2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sc2op1
            // 
            this.sc2op1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(118)))), ((int)(((byte)(183)))));
            this.sc2op1.BackColor = System.Drawing.Color.White;
            this.sc2op1.Font = new System.Drawing.Font("Gotham Medium", 9.5F);
            this.sc2op1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.sc2op1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(118)))), ((int)(((byte)(183)))));
            this.sc2op1.Location = new System.Drawing.Point(21, 380);
            this.sc2op1.Name = "sc2op1";
            this.sc2op1.Padding = new System.Windows.Forms.Padding(15, 1, 50, 1);
            this.sc2op1.Size = new System.Drawing.Size(535, 19);
            this.sc2op1.TabIndex = 0;
            this.sc2op1.TabStop = true;
            this.sc2op1.Text = "I\'m an expert. Quit this utility and show me the manual installation guide.";
            this.sc2op1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sc2op1_LinkClicked);
            // 
            // sc2op2
            // 
            this.sc2op2.BackColor = System.Drawing.Color.White;
            this.sc2op2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sc2op2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(118)))), ((int)(((byte)(183)))));
            this.sc2op2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sc2op2.Font = new System.Drawing.Font("Gotham Medium", 9.5F);
            this.sc2op2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(118)))), ((int)(((byte)(183)))));
            this.sc2op2.Location = new System.Drawing.Point(20, 406);
            this.sc2op2.Name = "sc2op2";
            this.sc2op2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.sc2op2.Size = new System.Drawing.Size(537, 23);
            this.sc2op2.TabIndex = 2;
            this.sc2op2.Text = "I want to use this client. Continue with the automated installation.";
            this.sc2op2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sc2op2.UseVisualStyleBackColor = false;
            this.sc2op2.Click += new System.EventHandler(this.sc2op2_Click);
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.sc2op2);
            this.Controls.Add(this.sc2op1);
            this.Font = new System.Drawing.Font("Gotham Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Page2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BVA Getting Started Utility";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel sc2op1;
        private System.Windows.Forms.Button sc2op2;
    }
}