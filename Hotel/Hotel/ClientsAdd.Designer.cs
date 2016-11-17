namespace Hotel
{
    partial class ClientsAdd
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.Number_tb = new System.Windows.Forms.TextBox();
            this.FIO_tb = new System.Windows.Forms.TextBox();
            this.Passport_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(250, 96);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(141, 23);
            this.Save_btn.TabIndex = 13;
            this.Save_btn.Text = "Добавить";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Number_tb
            // 
            this.Number_tb.Location = new System.Drawing.Point(139, 70);
            this.Number_tb.Name = "Number_tb";
            this.Number_tb.Size = new System.Drawing.Size(252, 20);
            this.Number_tb.TabIndex = 12;
            // 
            // FIO_tb
            // 
            this.FIO_tb.Location = new System.Drawing.Point(139, 18);
            this.FIO_tb.Name = "FIO_tb";
            this.FIO_tb.Size = new System.Drawing.Size(252, 20);
            this.FIO_tb.TabIndex = 11;
            // 
            // Passport_tb
            // 
            this.Passport_tb.Location = new System.Drawing.Point(138, 44);
            this.Passport_tb.Name = "Passport_tb";
            this.Passport_tb.Size = new System.Drawing.Size(252, 20);
            this.Passport_tb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Паспортные данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО";
            // 
            // ClientsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 127);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Number_tb);
            this.Controls.Add(this.FIO_tb);
            this.Controls.Add(this.Passport_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации о клиенте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Number_tb;
        private System.Windows.Forms.TextBox FIO_tb;
        private System.Windows.Forms.TextBox Passport_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}