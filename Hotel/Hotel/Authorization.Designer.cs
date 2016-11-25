namespace Hotel
{
    partial class Authorization
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
            this.EnterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Logintb = new System.Windows.Forms.TextBox();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.Registration_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(349, 172);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(165, 35);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // Logintb
            // 
            this.Logintb.Location = new System.Drawing.Point(349, 74);
            this.Logintb.Multiline = true;
            this.Logintb.Name = "Logintb";
            this.Logintb.Size = new System.Drawing.Size(165, 20);
            this.Logintb.TabIndex = 3;
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(349, 129);
            this.Passwordtb.Multiline = true;
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.Size = new System.Drawing.Size(165, 20);
            this.Passwordtb.TabIndex = 4;
            // 
            // Registration_btn
            // 
            this.Registration_btn.Location = new System.Drawing.Point(349, 216);
            this.Registration_btn.Name = "Registration_btn";
            this.Registration_btn.Size = new System.Drawing.Size(165, 35);
            this.Registration_btn.TabIndex = 5;
            this.Registration_btn.Text = "Зарегистрироваться";
            this.Registration_btn.UseVisualStyleBackColor = true;
            this.Registration_btn.Click += new System.EventHandler(this.Registration_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(374, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(349, 257);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(165, 35);
            this.Exitbtn.TabIndex = 7;
            this.Exitbtn.Text = "Выйти";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 317);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Registration_btn);
            this.Controls.Add(this.Passwordtb);
            this.Controls.Add(this.Logintb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Logintb;
        private System.Windows.Forms.TextBox Passwordtb;
        private System.Windows.Forms.Button Registration_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exitbtn;
    }
}