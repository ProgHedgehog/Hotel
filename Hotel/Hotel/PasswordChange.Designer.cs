namespace Hotel
{
    partial class PasswordChange
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
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Changepassbut = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(141, 79);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(150, 20);
            this.PasswordTb.TabIndex = 0;
            this.toolTip1.SetToolTip(this.PasswordTb, "Может состоять из цифр и букв. Знаки препинания запрещены");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(124, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите новый пароль:";
            // 
            // Changepassbut
            // 
            this.Changepassbut.Location = new System.Drawing.Point(141, 121);
            this.Changepassbut.Name = "Changepassbut";
            this.Changepassbut.Size = new System.Drawing.Size(150, 37);
            this.Changepassbut.TabIndex = 2;
            this.Changepassbut.Text = "Сменить пароль";
            this.Changepassbut.UseVisualStyleBackColor = true;
            this.Changepassbut.Click += new System.EventHandler(this.Changepassbut_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.Changepassbut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTb);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Changepassbut;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}