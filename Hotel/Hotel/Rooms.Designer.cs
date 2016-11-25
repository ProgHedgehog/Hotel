namespace Hotel
{
    partial class Rooms
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Filtercmbb = new System.Windows.Forms.ComboBox();
            this.Filterbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.RoomsdataGridView = new System.Windows.Forms.DataGridView();
            this.NextBtn = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Выбор номера";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Editbtn);
            this.groupBox4.Controls.Add(this.Addbtn);
            this.groupBox4.Controls.Add(this.Deletebtn);
            this.groupBox4.Location = new System.Drawing.Point(666, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 129);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактирование";
            // 
            // Editbtn
            // 
            this.Editbtn.Enabled = false;
            this.Editbtn.Location = new System.Drawing.Point(6, 81);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(119, 38);
            this.Editbtn.TabIndex = 3;
            this.Editbtn.Text = "Редактировать данные";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(6, 51);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(119, 23);
            this.Addbtn.TabIndex = 2;
            this.Addbtn.Text = "Добавить данные";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Enabled = false;
            this.Deletebtn.Location = new System.Drawing.Point(6, 22);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(119, 23);
            this.Deletebtn.TabIndex = 14;
            this.Deletebtn.Text = "Удалить данные";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Filtercmbb);
            this.groupBox2.Controls.Add(this.Filterbtn);
            this.groupBox2.Location = new System.Drawing.Point(666, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 82);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // Filtercmbb
            // 
            this.Filtercmbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filtercmbb.FormattingEnabled = true;
            this.Filtercmbb.Items.AddRange(new object[] {
            "все",
            "свободен",
            "занят",
            "бронь"});
            this.Filtercmbb.Location = new System.Drawing.Point(6, 51);
            this.Filtercmbb.Name = "Filtercmbb";
            this.Filtercmbb.Size = new System.Drawing.Size(119, 21);
            this.Filtercmbb.TabIndex = 22;
            this.Filtercmbb.SelectedValueChanged += new System.EventHandler(this.Filtercmbb_SelectedValueChanged);
            // 
            // Filterbtn
            // 
            this.Filterbtn.Enabled = false;
            this.Filterbtn.Location = new System.Drawing.Point(6, 19);
            this.Filterbtn.Name = "Filterbtn";
            this.Filterbtn.Size = new System.Drawing.Size(119, 27);
            this.Filterbtn.TabIndex = 21;
            this.Filterbtn.Text = "Применить фильтр";
            this.Filterbtn.UseVisualStyleBackColor = true;
            this.Filterbtn.Click += new System.EventHandler(this.Filterbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Дата выезда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Дата заезда";
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Location = new System.Drawing.Point(379, 32);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerFinish.TabIndex = 29;
            this.dateTimePickerFinish.Value = new System.DateTime(2016, 11, 24, 0, 0, 0, 0);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(147, 32);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerStart.TabIndex = 28;
            this.dateTimePickerStart.Value = new System.DateTime(2016, 11, 24, 0, 0, 0, 0);
            // 
            // RoomsdataGridView
            // 
            this.RoomsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsdataGridView.Location = new System.Drawing.Point(12, 97);
            this.RoomsdataGridView.Name = "RoomsdataGridView";
            this.RoomsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomsdataGridView.Size = new System.Drawing.Size(647, 259);
            this.RoomsdataGridView.TabIndex = 27;
            this.RoomsdataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RoomsdataGridView_CellMouseClick);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(666, 311);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(134, 45);
            this.NextBtn.TabIndex = 26;
            this.NextBtn.Text = "Далее";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerFinish);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.RoomsdataGridView);
            this.Controls.Add(this.NextBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Rooms";
            this.Text = "Номера";
            this.Activated += new System.EventHandler(this.Rooms_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rooms_FormClosing);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Filtercmbb;
        private System.Windows.Forms.Button Filterbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataGridView RoomsdataGridView;
        private System.Windows.Forms.Button NextBtn;
    }
}