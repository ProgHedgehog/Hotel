namespace Hotel
{
    partial class RoomsChange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Typecmbb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pricetb = new System.Windows.Forms.TextBox();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Descriptioncmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Descriptioncmb);
            this.groupBox1.Controls.Add(this.Typecmbb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Pricetb);
            this.groupBox1.Controls.Add(this.Nametb);
            this.groupBox1.Location = new System.Drawing.Point(43, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о номере";
            // 
            // Typecmbb
            // 
            this.Typecmbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Typecmbb.FormattingEnabled = true;
            this.Typecmbb.Location = new System.Drawing.Point(142, 104);
            this.Typecmbb.Name = "Typecmbb";
            this.Typecmbb.Size = new System.Drawing.Size(117, 21);
            this.Typecmbb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название комнаты";
            // 
            // Pricetb
            // 
            this.Pricetb.Location = new System.Drawing.Point(142, 74);
            this.Pricetb.Name = "Pricetb";
            this.Pricetb.Size = new System.Drawing.Size(117, 20);
            this.Pricetb.TabIndex = 2;
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(142, 18);
            this.Nametb.MaxLength = 20;
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(117, 20);
            this.Nametb.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(98, 180);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(137, 35);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Descriptioncmb
            // 
            this.Descriptioncmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Descriptioncmb.FormattingEnabled = true;
            this.Descriptioncmb.Items.AddRange(new object[] {
            "Эконом",
            "Стандарт",
            "Люкс"});
            this.Descriptioncmb.Location = new System.Drawing.Point(142, 46);
            this.Descriptioncmb.Name = "Descriptioncmb";
            this.Descriptioncmb.Size = new System.Drawing.Size(117, 21);
            this.Descriptioncmb.TabIndex = 10;
            // 
            // RoomsChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 227);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomsChange";
            this.Text = "Внесение изменений в номера";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pricetb;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox Typecmbb;
        private System.Windows.Forms.ComboBox Descriptioncmb;
    }
}