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
            this.mySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonConnectionToDB = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanelDataGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewContentDB = new System.Windows.Forms.DataGridView();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.buttonExecuteRequest = new System.Windows.Forms.Button();
            this.panelCheck = new System.Windows.Forms.Panel();
            this.textBoxConnectDB = new System.Windows.Forms.TextBox();
            this.labelForConnectionString = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxDataBase = new System.Windows.Forms.TextBox();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.flowLayoutPanelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContentDB)).BeginInit();
            this.panelCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.mySQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // mySQLToolStripMenuItem
            // 
            this.mySQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.checkConnectionToolStripMenuItem,
            this.executeRequestToolStripMenuItem});
            this.mySQLToolStripMenuItem.Name = "mySQLToolStripMenuItem";
            this.mySQLToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.mySQLToolStripMenuItem.Text = "MySQL";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // checkConnectionToolStripMenuItem
            // 
            this.checkConnectionToolStripMenuItem.Name = "checkConnectionToolStripMenuItem";
            this.checkConnectionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.checkConnectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.checkConnectionToolStripMenuItem.Text = "Check connection";
            this.checkConnectionToolStripMenuItem.Click += new System.EventHandler(this.checkConnectionToolStripMenuItem_Click);
            // 
            // executeRequestToolStripMenuItem
            // 
            this.executeRequestToolStripMenuItem.Name = "executeRequestToolStripMenuItem";
            this.executeRequestToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.executeRequestToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.executeRequestToolStripMenuItem.Text = "Execute request";
            this.executeRequestToolStripMenuItem.Click += new System.EventHandler(this.executeRequestToolStripMenuItem_Click);
            // 
            // buttonConnectionToDB
            // 
            this.buttonConnectionToDB.BackColor = System.Drawing.SystemColors.Window;
            this.buttonConnectionToDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnectionToDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnectionToDB.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectionToDB.Location = new System.Drawing.Point(3, 3);
            this.buttonConnectionToDB.Name = "buttonConnectionToDB";
            this.buttonConnectionToDB.Size = new System.Drawing.Size(110, 40);
            this.buttonConnectionToDB.TabIndex = 1;
            this.buttonConnectionToDB.Text = "Check connection";
            this.buttonConnectionToDB.UseVisualStyleBackColor = false;
            this.buttonConnectionToDB.Click += new System.EventHandler(this.buttonConnectionToDB_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.flowLayoutPanelDataGrid);
            this.panelMain.Controls.Add(this.textBoxRequest);
            this.panelMain.Controls.Add(this.buttonExecuteRequest);
            this.panelMain.Controls.Add(this.panelCheck);
            this.panelMain.Controls.Add(this.labelForConnectionString);
            this.panelMain.Controls.Add(this.textBoxPassword);
            this.panelMain.Controls.Add(this.textBoxUsername);
            this.panelMain.Controls.Add(this.textBoxDataBase);
            this.panelMain.Controls.Add(this.textBoxServerName);
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(325, 376);
            this.panelMain.TabIndex = 2;
            // 
            // flowLayoutPanelDataGrid
            // 
            this.flowLayoutPanelDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDataGrid.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelDataGrid.Controls.Add(this.dataGridViewContentDB);
            this.flowLayoutPanelDataGrid.Location = new System.Drawing.Point(325, 0);
            this.flowLayoutPanelDataGrid.Name = "flowLayoutPanelDataGrid";
            this.flowLayoutPanelDataGrid.Size = new System.Drawing.Size(403, 376);
            this.flowLayoutPanelDataGrid.TabIndex = 3;
            // 
            // dataGridViewContentDB
            // 
            this.dataGridViewContentDB.AllowUserToDeleteRows = false;
            this.dataGridViewContentDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContentDB.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewContentDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContentDB.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewContentDB.Name = "dataGridViewContentDB";
            this.dataGridViewContentDB.ReadOnly = true;
            this.dataGridViewContentDB.Size = new System.Drawing.Size(400, 0);
            this.dataGridViewContentDB.TabIndex = 0;
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRequest.Location = new System.Drawing.Point(4, 179);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequest.Size = new System.Drawing.Size(320, 190);
            this.textBoxRequest.TabIndex = 11;
            // 
            // buttonExecuteRequest
            // 
            this.buttonExecuteRequest.BackColor = System.Drawing.SystemColors.Window;
            this.buttonExecuteRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExecuteRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExecuteRequest.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecuteRequest.Location = new System.Drawing.Point(4, 133);
            this.buttonExecuteRequest.Name = "buttonExecuteRequest";
            this.buttonExecuteRequest.Size = new System.Drawing.Size(318, 40);
            this.buttonExecuteRequest.TabIndex = 10;
            this.buttonExecuteRequest.Text = "Execute request";
            this.buttonExecuteRequest.UseVisualStyleBackColor = false;
            this.buttonExecuteRequest.Click += new System.EventHandler(this.buttonExecuteRequest_Click);
            // 
            // panelCheck
            // 
            this.panelCheck.BackColor = System.Drawing.Color.DarkGray;
            this.panelCheck.Controls.Add(this.buttonConnectionToDB);
            this.panelCheck.Controls.Add(this.textBoxConnectDB);
            this.panelCheck.Location = new System.Drawing.Point(4, 79);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(318, 48);
            this.panelCheck.TabIndex = 9;
            // 
            // textBoxConnectDB
            // 
            this.textBoxConnectDB.Location = new System.Drawing.Point(118, 3);
            this.textBoxConnectDB.Multiline = true;
            this.textBoxConnectDB.Name = "textBoxConnectDB";
            this.textBoxConnectDB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConnectDB.Size = new System.Drawing.Size(197, 40);
            this.textBoxConnectDB.TabIndex = 3;
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
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(167, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(155, 23);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(328, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(400, 369);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 404);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Algerian", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(747, 443);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working with DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowLayoutPanelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContentDB)).EndInit();
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button buttonConnectionToDB;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxConnectDB;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelForConnectionString;
        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.Button buttonExecuteRequest;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeRequestToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDataGrid;
        private System.Windows.Forms.DataGridView dataGridViewContentDB;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

