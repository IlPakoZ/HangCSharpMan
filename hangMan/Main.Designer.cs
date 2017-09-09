namespace hangMan
{
    partial class frm_Main
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
            this.pb_BackGround = new System.Windows.Forms.PictureBox();
            this.btn_Check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_BackGround
            // 
            this.pb_BackGround.BackColor = System.Drawing.Color.White;
            this.pb_BackGround.Location = new System.Drawing.Point(172, 12);
            this.pb_BackGround.Name = "pb_BackGround";
            this.pb_BackGround.Size = new System.Drawing.Size(100, 237);
            this.pb_BackGround.TabIndex = 0;
            this.pb_BackGround.TabStop = false;
            this.pb_BackGround.Paint += new System.Windows.Forms.PaintEventHandler(this.backGround_Paint);
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(47, 189);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 1;
            this.btn_Check.Text = "Controlla";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.check_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.pb_BackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Main";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_BackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_BackGround;
        private System.Windows.Forms.Button btn_Check;
    }
}