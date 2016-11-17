namespace Hotel
{
    partial class ChangeService
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
            this.Price_tb = new System.Windows.Forms.TextBox();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.Description_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(240, 94);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(141, 23);
            this.Save_btn.TabIndex = 20;
            this.Save_btn.Text = "Сохранить";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Price_tb
            // 
            this.Price_tb.Location = new System.Drawing.Point(75, 68);
            this.Price_tb.Name = "Price_tb";
            this.Price_tb.Size = new System.Drawing.Size(307, 20);
            this.Price_tb.TabIndex = 19;
            // 
            // Name_tb
            // 
            this.Name_tb.Location = new System.Drawing.Point(75, 16);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(307, 20);
            this.Name_tb.TabIndex = 18;
            // 
            // Description_tb
            // 
            this.Description_tb.Location = new System.Drawing.Point(75, 42);
            this.Description_tb.Name = "Description_tb";
            this.Description_tb.Size = new System.Drawing.Size(306, 20);
            this.Description_tb.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название";
            // 
            // ChangeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 134);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Price_tb);
            this.Controls.Add(this.Name_tb);
            this.Controls.Add(this.Description_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeService";
            this.Text = "Внесение изменений в услуги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Price_tb;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.TextBox Description_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}