namespace hangMan
{
    partial class Main
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
            this.backGround = new System.Windows.Forms.PictureBox();
            this.check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).BeginInit();
            this.SuspendLayout();
            // 
            // backGround
            // 
            this.backGround.BackColor = System.Drawing.Color.White;
            this.backGround.Location = new System.Drawing.Point(172, 12);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(100, 237);
            this.backGround.TabIndex = 0;
            this.backGround.TabStop = false;
            this.backGround.Paint += new System.Windows.Forms.PaintEventHandler(this.backGround_Paint);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(47, 189);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 1;
            this.check.Text = "Controlla";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.check);
            this.Controls.Add(this.backGround);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backGround;
        private System.Windows.Forms.Button check;
    }
}