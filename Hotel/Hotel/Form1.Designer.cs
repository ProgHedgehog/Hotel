namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.authorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populatesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorizationToolStripMenuItem,
            this.clientsWorkToolStripMenuItem,
            this.roomsWorkToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // authorizationToolStripMenuItem
            // 
            this.authorizationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.authorizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorisationToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.ChangePassToolStripMenuItem});
            this.authorizationToolStripMenuItem.Name = "authorizationToolStripMenuItem";
            this.authorizationToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.authorizationToolStripMenuItem.Text = "Авторизация";
            // 
            // AuthorisationToolStripMenuItem
            // 
            this.AuthorisationToolStripMenuItem.Name = "AuthorisationToolStripMenuItem";
            this.AuthorisationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.AuthorisationToolStripMenuItem.Text = "Авторизация";
            this.AuthorisationToolStripMenuItem.Click += new System.EventHandler(this.AuthorisationToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Enabled = false;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click_1);
            // 
            // ChangePassToolStripMenuItem
            // 
            this.ChangePassToolStripMenuItem.Enabled = false;
            this.ChangePassToolStripMenuItem.Name = "ChangePassToolStripMenuItem";
            this.ChangePassToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ChangePassToolStripMenuItem.Text = "Сменить пароль";
            this.ChangePassToolStripMenuItem.Click += new System.EventHandler(this.ChangePassToolStripMenuItem_Click);
            // 
            // clientsWorkToolStripMenuItem
            // 
            this.clientsWorkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.populatesClientsToolStripMenuItem});
            this.clientsWorkToolStripMenuItem.Enabled = false;
            this.clientsWorkToolStripMenuItem.Name = "clientsWorkToolStripMenuItem";
            this.clientsWorkToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.clientsWorkToolStripMenuItem.Text = "Работа с клиентами";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // populatesClientsToolStripMenuItem
            // 
            this.populatesClientsToolStripMenuItem.Name = "populatesClientsToolStripMenuItem";
            this.populatesClientsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.populatesClientsToolStripMenuItem.Text = "Заселенные клиенты";
            this.populatesClientsToolStripMenuItem.Click += new System.EventHandler(this.populatesClientsToolStripMenuItem_Click);
            // 
            // roomsWorkToolStripMenuItem
            // 
            this.roomsWorkToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.roomsWorkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem});
            this.roomsWorkToolStripMenuItem.Enabled = false;
            this.roomsWorkToolStripMenuItem.Name = "roomsWorkToolStripMenuItem";
            this.roomsWorkToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.roomsWorkToolStripMenuItem.Text = "Работа с номерами";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.roomsToolStripMenuItem.Text = "Номера";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Enabled = false;
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.documentationToolStripMenuItem.Text = "Документация";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 512);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Работа гостиницы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem populatesClientsToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem clientsWorkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem authorizationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem roomsWorkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem AuthorisationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ChangePassToolStripMenuItem;
    }
}

