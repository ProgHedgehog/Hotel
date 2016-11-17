namespace Hotel
{
    partial class Documents
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
            this.Check_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServDelete_btn = new System.Windows.Forms.Button();
            this.ServEdit_btn = new System.Windows.Forms.Button();
            this.SevAdd_btn = new System.Windows.Forms.Button();
            this.Service_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Contract_btn = new System.Windows.Forms.Button();
            this.Contract_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Client_btn = new System.Windows.Forms.Button();
            this.Client_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Service_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contract_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Client_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Check_btn
            // 
            this.Check_btn.Location = new System.Drawing.Point(655, 369);
            this.Check_btn.Name = "Check_btn";
            this.Check_btn.Size = new System.Drawing.Size(159, 64);
            this.Check_btn.TabIndex = 7;
            this.Check_btn.Text = "Составить чек";
            this.Check_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ServDelete_btn);
            this.groupBox3.Controls.Add(this.ServEdit_btn);
            this.groupBox3.Controls.Add(this.SevAdd_btn);
            this.groupBox3.Controls.Add(this.Service_dataGridView);
            this.groupBox3.Location = new System.Drawing.Point(420, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 241);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Добавить доп. услуги";
            // 
            // ServDelete_btn
            // 
            this.ServDelete_btn.Location = new System.Drawing.Point(293, 212);
            this.ServDelete_btn.Name = "ServDelete_btn";
            this.ServDelete_btn.Size = new System.Drawing.Size(102, 23);
            this.ServDelete_btn.TabIndex = 3;
            this.ServDelete_btn.Text = "Удалить";
            this.ServDelete_btn.UseVisualStyleBackColor = true;
            this.ServDelete_btn.Click += new System.EventHandler(this.ServDelete_btn_Click);
            // 
            // ServEdit_btn
            // 
            this.ServEdit_btn.Location = new System.Drawing.Point(154, 212);
            this.ServEdit_btn.Name = "ServEdit_btn";
            this.ServEdit_btn.Size = new System.Drawing.Size(121, 23);
            this.ServEdit_btn.TabIndex = 2;
            this.ServEdit_btn.Text = "Редактировать";
            this.ServEdit_btn.UseVisualStyleBackColor = true;
            this.ServEdit_btn.Click += new System.EventHandler(this.ServEdit_btn_Click);
            // 
            // SevAdd_btn
            // 
            this.SevAdd_btn.Location = new System.Drawing.Point(6, 212);
            this.SevAdd_btn.Name = "SevAdd_btn";
            this.SevAdd_btn.Size = new System.Drawing.Size(133, 23);
            this.SevAdd_btn.TabIndex = 1;
            this.SevAdd_btn.Text = "Добавить услугу";
            this.SevAdd_btn.UseVisualStyleBackColor = true;
            this.SevAdd_btn.Click += new System.EventHandler(this.SevAdd_btn_Click);
            // 
            // Service_dataGridView
            // 
            this.Service_dataGridView.AllowUserToAddRows = false;
            this.Service_dataGridView.AllowUserToDeleteRows = false;
            this.Service_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Service_dataGridView.Location = new System.Drawing.Point(6, 19);
            this.Service_dataGridView.Name = "Service_dataGridView";
            this.Service_dataGridView.ReadOnly = true;
            this.Service_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Service_dataGridView.Size = new System.Drawing.Size(389, 187);
            this.Service_dataGridView.TabIndex = 0;
            this.Service_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Service_dataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Contract_btn);
            this.groupBox2.Controls.Add(this.Contract_dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(6, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Выбрать договор";
            // 
            // Contract_btn
            // 
            this.Contract_btn.Location = new System.Drawing.Point(265, 158);
            this.Contract_btn.Name = "Contract_btn";
            this.Contract_btn.Size = new System.Drawing.Size(137, 23);
            this.Contract_btn.TabIndex = 2;
            this.Contract_btn.Text = "Выбрать";
            this.Contract_btn.UseVisualStyleBackColor = true;
            // 
            // Contract_dataGridView
            // 
            this.Contract_dataGridView.AllowUserToAddRows = false;
            this.Contract_dataGridView.AllowUserToDeleteRows = false;
            this.Contract_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contract_dataGridView.Location = new System.Drawing.Point(7, 20);
            this.Contract_dataGridView.Name = "Contract_dataGridView";
            this.Contract_dataGridView.ReadOnly = true;
            this.Contract_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Contract_dataGridView.Size = new System.Drawing.Size(395, 132);
            this.Contract_dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Client_btn);
            this.groupBox1.Controls.Add(this.Client_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Выбрать клиента";
            // 
            // Client_btn
            // 
            this.Client_btn.Location = new System.Drawing.Point(265, 212);
            this.Client_btn.Name = "Client_btn";
            this.Client_btn.Size = new System.Drawing.Size(137, 23);
            this.Client_btn.TabIndex = 1;
            this.Client_btn.Text = "Выбрать";
            this.Client_btn.UseVisualStyleBackColor = true;
            // 
            // Client_dataGridView
            // 
            this.Client_dataGridView.AllowUserToAddRows = false;
            this.Client_dataGridView.AllowUserToDeleteRows = false;
            this.Client_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Client_dataGridView.Location = new System.Drawing.Point(6, 19);
            this.Client_dataGridView.Name = "Client_dataGridView";
            this.Client_dataGridView.ReadOnly = true;
            this.Client_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Client_dataGridView.Size = new System.Drawing.Size(396, 187);
            this.Client_dataGridView.TabIndex = 0;
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 445);
            this.Controls.Add(this.Check_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Документация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Documents_FormClosing);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Service_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contract_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Client_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Check_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ServDelete_btn;
        private System.Windows.Forms.Button ServEdit_btn;
        private System.Windows.Forms.Button SevAdd_btn;
        private System.Windows.Forms.DataGridView Service_dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Contract_btn;
        private System.Windows.Forms.DataGridView Contract_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Client_btn;
        private System.Windows.Forms.DataGridView Client_dataGridView;
    }
}