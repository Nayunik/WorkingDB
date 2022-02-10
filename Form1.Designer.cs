namespace WorkingDB
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
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonConnectionToDB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxConnectDB = new System.Windows.Forms.TextBox();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.textBoxDataBase = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelForConnectionString = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 9F);
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // buttonConnectionToDB
            // 
            this.buttonConnectionToDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnectionToDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnectionToDB.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectionToDB.Location = new System.Drawing.Point(3, 78);
            this.buttonConnectionToDB.Name = "buttonConnectionToDB";
            this.buttonConnectionToDB.Size = new System.Drawing.Size(110, 40);
            this.buttonConnectionToDB.TabIndex = 1;
            this.buttonConnectionToDB.Text = "Connect to DB";
            this.buttonConnectionToDB.UseVisualStyleBackColor = true;
            this.buttonConnectionToDB.Click += new System.EventHandler(this.buttonConnectionToDB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelForConnectionString);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxDataBase);
            this.panel1.Controls.Add(this.textBoxServerName);
            this.panel1.Controls.Add(this.textBoxConnectDB);
            this.panel1.Controls.Add(this.buttonConnectionToDB);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 127);
            this.panel1.TabIndex = 2;
            // 
            // textBoxConnectDB
            // 
            this.textBoxConnectDB.Location = new System.Drawing.Point(122, 78);
            this.textBoxConnectDB.Multiline = true;
            this.textBoxConnectDB.Name = "textBoxConnectDB";
            this.textBoxConnectDB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConnectDB.Size = new System.Drawing.Size(200, 40);
            this.textBoxConnectDB.TabIndex = 3;
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(3, 21);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(155, 23);
            this.textBoxServerName.TabIndex = 4;
            this.textBoxServerName.Text = "Server";
            this.textBoxServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxServerName.Enter += new System.EventHandler(this.textBoxServerName_Enter);
            this.textBoxServerName.Leave += new System.EventHandler(this.textBoxServerName_Leave);
            // 
            // textBoxDataBase
            // 
            this.textBoxDataBase.Location = new System.Drawing.Point(167, 21);
            this.textBoxDataBase.Name = "textBoxDataBase";
            this.textBoxDataBase.Size = new System.Drawing.Size(155, 23);
            this.textBoxDataBase.TabIndex = 5;
            this.textBoxDataBase.Text = "Name DB";
            this.textBoxDataBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDataBase.Enter += new System.EventHandler(this.textBoxDataBase_Enter);
            this.textBoxDataBase.Leave += new System.EventHandler(this.textBoxDataBase_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(3, 50);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(155, 23);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(167, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(155, 23);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // labelForConnectionString
            // 
            this.labelForConnectionString.AutoSize = true;
            this.labelForConnectionString.Location = new System.Drawing.Point(6, 4);
            this.labelForConnectionString.Name = "labelForConnectionString";
            this.labelForConnectionString.Size = new System.Drawing.Size(180, 14);
            this.labelForConnectionString.TabIndex = 8;
            this.labelForConnectionString.Text = "Введите данные MySQL сервера:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Algerian", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working with DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button buttonConnectionToDB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxConnectDB;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelForConnectionString;
    }
}

