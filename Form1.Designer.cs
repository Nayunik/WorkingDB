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
            this.progressBarConnectDB = new System.Windows.Forms.ProgressBar();
            this.textBoxConnectDB = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 9F);
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // buttonConnectionToDB
            // 
            this.buttonConnectionToDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnectionToDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnectionToDB.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectionToDB.Location = new System.Drawing.Point(3, 3);
            this.buttonConnectionToDB.Name = "buttonConnectionToDB";
            this.buttonConnectionToDB.Size = new System.Drawing.Size(110, 40);
            this.buttonConnectionToDB.TabIndex = 1;
            this.buttonConnectionToDB.Text = "Connect to DB";
            this.buttonConnectionToDB.UseVisualStyleBackColor = true;
            this.buttonConnectionToDB.Click += new System.EventHandler(this.buttonConnectionToDB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxConnectDB);
            this.panel1.Controls.Add(this.progressBarConnectDB);
            this.panel1.Controls.Add(this.buttonConnectionToDB);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 76);
            this.panel1.TabIndex = 2;
            // 
            // progressBarConnectDB
            // 
            this.progressBarConnectDB.Location = new System.Drawing.Point(3, 49);
            this.progressBarConnectDB.Name = "progressBarConnectDB";
            this.progressBarConnectDB.Size = new System.Drawing.Size(316, 20);
            this.progressBarConnectDB.TabIndex = 2;
            // 
            // textBoxConnectDB
            // 
            this.textBoxConnectDB.Location = new System.Drawing.Point(119, 3);
            this.textBoxConnectDB.Multiline = true;
            this.textBoxConnectDB.Name = "textBoxConnectDB";
            this.textBoxConnectDB.Size = new System.Drawing.Size(200, 40);
            this.textBoxConnectDB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Algerian", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
        private System.Windows.Forms.ProgressBar progressBarConnectDB;
    }
}

