namespace Hotel
{
    partial class Services
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
            this.ServDelete_btn = new System.Windows.Forms.Button();
            this.ServEdit_btn = new System.Windows.Forms.Button();
            this.SevAdd_btn = new System.Windows.Forms.Button();
            this.Service_dataGridView = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Service_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ServDelete_btn
            // 
            this.ServDelete_btn.Location = new System.Drawing.Point(327, 222);
            this.ServDelete_btn.Name = "ServDelete_btn";
            this.ServDelete_btn.Size = new System.Drawing.Size(102, 23);
            this.ServDelete_btn.TabIndex = 3;
            this.ServDelete_btn.Text = "Удалить";
            this.ServDelete_btn.UseVisualStyleBackColor = true;
            this.ServDelete_btn.Click += new System.EventHandler(this.ServDelete_btn_Click);
            // 
            // ServEdit_btn
            // 
            this.ServEdit_btn.Location = new System.Drawing.Point(190, 222);
            this.ServEdit_btn.Name = "ServEdit_btn";
            this.ServEdit_btn.Size = new System.Drawing.Size(121, 23);
            this.ServEdit_btn.TabIndex = 2;
            this.ServEdit_btn.Text = "Редактировать";
            this.ServEdit_btn.UseVisualStyleBackColor = true;
            this.ServEdit_btn.Click += new System.EventHandler(this.ServEdit_btn_Click);
            // 
            // SevAdd_btn
            // 
            this.SevAdd_btn.Location = new System.Drawing.Point(40, 222);
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
            this.Service_dataGridView.Location = new System.Drawing.Point(48, 17);
            this.Service_dataGridView.MultiSelect = false;
            this.Service_dataGridView.Name = "Service_dataGridView";
            this.Service_dataGridView.ReadOnly = true;
            this.Service_dataGridView.RowHeadersWidth = 50;
            this.Service_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Service_dataGridView.Size = new System.Drawing.Size(496, 187);
            this.Service_dataGridView.TabIndex = 0;
            this.Service_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Service_dataGridView_CellClick);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(447, 222);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(102, 23);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 257);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ServDelete_btn);
            this.Controls.Add(this.ServEdit_btn);
            this.Controls.Add(this.Service_dataGridView);
            this.Controls.Add(this.SevAdd_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительные услуги";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Service_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ServDelete_btn;
        private System.Windows.Forms.Button ServEdit_btn;
        private System.Windows.Forms.Button SevAdd_btn;
        private System.Windows.Forms.DataGridView Service_dataGridView;
        private System.Windows.Forms.Button BackBtn;
    }
}