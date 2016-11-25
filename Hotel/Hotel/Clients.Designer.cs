namespace Hotel
{
    partial class Clients
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
            this.SettleBtn = new System.Windows.Forms.Button();
            this.BookBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_tb = new System.Windows.Forms.TextBox();
            this.Selected_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.ClientsdataGridView = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SettleBtn
            // 
            this.SettleBtn.Enabled = false;
            this.SettleBtn.Location = new System.Drawing.Point(498, 198);
            this.SettleBtn.Name = "SettleBtn";
            this.SettleBtn.Size = new System.Drawing.Size(193, 45);
            this.SettleBtn.TabIndex = 18;
            this.SettleBtn.Text = "Заселить";
            this.SettleBtn.UseVisualStyleBackColor = true;
            this.SettleBtn.Click += new System.EventHandler(this.SettleBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.Enabled = false;
            this.BookBtn.Location = new System.Drawing.Point(498, 277);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(193, 45);
            this.BookBtn.TabIndex = 17;
            this.BookBtn.Text = "Забронировать";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ID_tb);
            this.groupBox1.Controls.Add(this.Selected_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Delete_btn);
            this.groupBox1.Controls.Add(this.Edit_btn);
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о клиенте";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выбрано:";
            // 
            // ID_tb
            // 
            this.ID_tb.Enabled = false;
            this.ID_tb.Location = new System.Drawing.Point(46, 47);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.Size = new System.Drawing.Size(43, 20);
            this.ID_tb.TabIndex = 13;
            // 
            // Selected_tb
            // 
            this.Selected_tb.Enabled = false;
            this.Selected_tb.Location = new System.Drawing.Point(46, 74);
            this.Selected_tb.Name = "Selected_tb";
            this.Selected_tb.Size = new System.Drawing.Size(144, 20);
            this.Selected_tb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО";
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(213, 71);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(141, 23);
            this.Delete_btn.TabIndex = 10;
            this.Delete_btn.Text = "Удалить данные";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(213, 45);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(141, 23);
            this.Edit_btn.TabIndex = 9;
            this.Edit_btn.Text = "Редактировать данные";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(213, 19);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(141, 23);
            this.Add_btn.TabIndex = 8;
            this.Add_btn.Text = "Добавить данные";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // ClientsdataGridView
            // 
            this.ClientsdataGridView.AllowUserToAddRows = false;
            this.ClientsdataGridView.AllowUserToDeleteRows = false;
            this.ClientsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsdataGridView.Location = new System.Drawing.Point(15, 124);
            this.ClientsdataGridView.Name = "ClientsdataGridView";
            this.ClientsdataGridView.ReadOnly = true;
            this.ClientsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsdataGridView.Size = new System.Drawing.Size(457, 198);
            this.ClientsdataGridView.TabIndex = 15;
            this.ClientsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsdataGridView_CellClick);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(498, 124);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(193, 45);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(498, 57);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(193, 45);
            this.ChooseBtn.TabIndex = 20;
            this.ChooseBtn.Text = "Выбрать услугу";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Visible = false;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 345);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SettleBtn);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientsdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clients_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SettleBtn;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_tb;
        private System.Windows.Forms.TextBox Selected_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView ClientsdataGridView;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ChooseBtn;
    }
}