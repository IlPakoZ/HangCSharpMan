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
            this.l_word = new System.Windows.Forms.TextBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.s_word = new System.Windows.Forms.TextBox();
            this.ltr_Check = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
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
            this.btn_Check.Location = new System.Drawing.Point(108, 177);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(58, 23);
            this.btn_Check.TabIndex = 1;
            this.btn_Check.Text = "Controlla";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.check_Click);
            // 
            // l_word
            // 
            this.l_word.Location = new System.Drawing.Point(12, 179);
            this.l_word.Name = "l_word";
            this.l_word.Size = new System.Drawing.Size(90, 20);
            this.l_word.TabIndex = 2;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(9, 163);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(142, 13);
            this.informationLabel.TabIndex = 3;
            this.informationLabel.Text = "Prova a indovinare la parola:";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(9, 133);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(43, 13);
            this.wordLabel.TabIndex = 4;
            this.wordLabel.Text = "Lettera:";
            // 
            // s_word
            // 
            this.s_word.Location = new System.Drawing.Point(58, 130);
            this.s_word.MaxLength = 1;
            this.s_word.Name = "s_word";
            this.s_word.Size = new System.Drawing.Size(20, 20);
            this.s_word.TabIndex = 5;
            // 
            // ltr_Check
            // 
            this.ltr_Check.Location = new System.Drawing.Point(84, 130);
            this.ltr_Check.Name = "ltr_Check";
            this.ltr_Check.Size = new System.Drawing.Size(38, 20);
            this.ltr_Check.TabIndex = 6;
            this.ltr_Check.Text = "Vai";
            this.ltr_Check.UseVisualStyleBackColor = true;
            this.ltr_Check.Click += new System.EventHandler(this.ltr_Check_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(13, 226);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.ltr_Check);
            this.Controls.Add(this.s_word);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.l_word);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.pb_BackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Main";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_BackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_BackGround;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.TextBox l_word;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.TextBox s_word;
        private System.Windows.Forms.Button ltr_Check;
        private System.Windows.Forms.Button resetButton;
    }
}