namespace Nevins_SBB_App
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblvon = new System.Windows.Forms.Label();
            this.tabortsuchen = new System.Windows.Forms.TabControl();
            this.tabverbindungsuchen = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.RichTextBox();
            this.btnsearchconnection = new System.Windows.Forms.Button();
            this.txtconnectionto = new System.Windows.Forms.RichTextBox();
            this.lblconnectionto = new System.Windows.Forms.Label();
            this.txtconnectionfrom = new System.Windows.Forms.RichTextBox();
            this.lblconnectionfrom = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bntcreatelist = new System.Windows.Forms.Button();
            this.txtplacefrom = new System.Windows.Forms.RichTextBox();
            this.lblplacefrom = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bntgooglemaps = new System.Windows.Forms.Button();
            this.tabortsuchen.SuspendLayout();
            this.tabverbindungsuchen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblvon
            // 
            this.lblvon.AutoSize = true;
            this.lblvon.Location = new System.Drawing.Point(66, 95);
            this.lblvon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvon.Name = "lblvon";
            this.lblvon.Size = new System.Drawing.Size(0, 13);
            this.lblvon.TabIndex = 0;
            // 
            // tabortsuchen
            // 
            this.tabortsuchen.Controls.Add(this.tabverbindungsuchen);
            this.tabortsuchen.Controls.Add(this.tabPage1);
            this.tabortsuchen.Controls.Add(this.tabPage2);
            this.tabortsuchen.Location = new System.Drawing.Point(6, 6);
            this.tabortsuchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabortsuchen.Name = "tabortsuchen";
            this.tabortsuchen.SelectedIndex = 0;
            this.tabortsuchen.Size = new System.Drawing.Size(475, 170);
            this.tabortsuchen.TabIndex = 1;
            // 
            // tabverbindungsuchen
            // 
            this.tabverbindungsuchen.Controls.Add(this.dateTimePicker1);
            this.tabverbindungsuchen.Controls.Add(this.textBox1);
            this.tabverbindungsuchen.Controls.Add(this.txtTime);
            this.tabverbindungsuchen.Controls.Add(this.btnsearchconnection);
            this.tabverbindungsuchen.Controls.Add(this.txtconnectionto);
            this.tabverbindungsuchen.Controls.Add(this.lblconnectionto);
            this.tabverbindungsuchen.Controls.Add(this.txtconnectionfrom);
            this.tabverbindungsuchen.Controls.Add(this.lblconnectionfrom);
            this.tabverbindungsuchen.Location = new System.Drawing.Point(4, 22);
            this.tabverbindungsuchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabverbindungsuchen.Name = "tabverbindungsuchen";
            this.tabverbindungsuchen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabverbindungsuchen.Size = new System.Drawing.Size(467, 144);
            this.tabverbindungsuchen.TabIndex = 0;
            this.tabverbindungsuchen.Text = "Verbindung suchen";
            this.tabverbindungsuchen.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 117);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(240, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(202, 113);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(124, 22);
            this.txtTime.TabIndex = 6;
            this.txtTime.Text = "";
            // 
            // btnsearchconnection
            // 
            this.btnsearchconnection.Location = new System.Drawing.Point(270, 57);
            this.btnsearchconnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearchconnection.Name = "btnsearchconnection";
            this.btnsearchconnection.Size = new System.Drawing.Size(148, 35);
            this.btnsearchconnection.TabIndex = 4;
            this.btnsearchconnection.Text = "Verbindung suchen ->";
            this.btnsearchconnection.UseVisualStyleBackColor = true;
            this.btnsearchconnection.Click += new System.EventHandler(this.btnsearchconnection_Click);
            // 
            // txtconnectionto
            // 
            this.txtconnectionto.Location = new System.Drawing.Point(13, 91);
            this.txtconnectionto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtconnectionto.Name = "txtconnectionto";
            this.txtconnectionto.Size = new System.Drawing.Size(166, 29);
            this.txtconnectionto.TabIndex = 3;
            this.txtconnectionto.Text = "";
            // 
            // lblconnectionto
            // 
            this.lblconnectionto.AutoSize = true;
            this.lblconnectionto.Location = new System.Drawing.Point(16, 76);
            this.lblconnectionto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconnectionto.Name = "lblconnectionto";
            this.lblconnectionto.Size = new System.Drawing.Size(36, 13);
            this.lblconnectionto.TabIndex = 2;
            this.lblconnectionto.Text = "Nach:";
            // 
            // txtconnectionfrom
            // 
            this.txtconnectionfrom.Location = new System.Drawing.Point(13, 43);
            this.txtconnectionfrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtconnectionfrom.Name = "txtconnectionfrom";
            this.txtconnectionfrom.Size = new System.Drawing.Size(166, 29);
            this.txtconnectionfrom.TabIndex = 1;
            this.txtconnectionfrom.Text = "";
            this.txtconnectionfrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtconnectionfrom_KeyUp);
            // 
            // lblconnectionfrom
            // 
            this.lblconnectionfrom.AutoSize = true;
            this.lblconnectionfrom.Location = new System.Drawing.Point(16, 29);
            this.lblconnectionfrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconnectionfrom.Name = "lblconnectionfrom";
            this.lblconnectionfrom.Size = new System.Drawing.Size(29, 13);
            this.lblconnectionfrom.TabIndex = 0;
            this.lblconnectionfrom.Text = "Von:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bntcreatelist);
            this.tabPage1.Controls.Add(this.txtplacefrom);
            this.tabPage1.Controls.Add(this.lblplacefrom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(467, 144);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Abfahrtsplan erstellen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bntcreatelist
            // 
            this.bntcreatelist.Location = new System.Drawing.Point(272, 73);
            this.bntcreatelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntcreatelist.Name = "bntcreatelist";
            this.bntcreatelist.Size = new System.Drawing.Size(148, 27);
            this.bntcreatelist.TabIndex = 5;
            this.bntcreatelist.Text = "Abfahrtsliste erstellen";
            this.bntcreatelist.UseVisualStyleBackColor = true;
            this.bntcreatelist.Click += new System.EventHandler(this.bntcreatelist_Click);
            // 
            // txtplacefrom
            // 
            this.txtplacefrom.Location = new System.Drawing.Point(22, 73);
            this.txtplacefrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtplacefrom.Name = "txtplacefrom";
            this.txtplacefrom.Size = new System.Drawing.Size(166, 29);
            this.txtplacefrom.TabIndex = 3;
            this.txtplacefrom.Text = "";
            // 
            // lblplacefrom
            // 
            this.lblplacefrom.AutoSize = true;
            this.lblplacefrom.Location = new System.Drawing.Point(14, 58);
            this.lblplacefrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplacefrom.Name = "lblplacefrom";
            this.lblplacefrom.Size = new System.Drawing.Size(29, 13);
            this.lblplacefrom.TabIndex = 2;
            this.lblplacefrom.Text = "Von:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Controls.Add(this.bntgooglemaps);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(467, 144);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Stationen in der nähe finden";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(10, 10);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(314, 143);
            this.webBrowser1.TabIndex = 1;
            // 
            // bntgooglemaps
            // 
            this.bntgooglemaps.Location = new System.Drawing.Point(328, 32);
            this.bntgooglemaps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntgooglemaps.Name = "bntgooglemaps";
            this.bntgooglemaps.Size = new System.Drawing.Size(108, 27);
            this.bntgooglemaps.TabIndex = 0;
            this.bntgooglemaps.Text = "Google Maps";
            this.bntgooglemaps.UseVisualStyleBackColor = true;
            this.bntgooglemaps.Click += new System.EventHandler(this.bntgooglemaps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 196);
            this.Controls.Add(this.tabortsuchen);
            this.Controls.Add(this.lblvon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(508, 235);
            this.MinimumSize = new System.Drawing.Size(508, 235);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabortsuchen.ResumeLayout(false);
            this.tabverbindungsuchen.ResumeLayout(false);
            this.tabverbindungsuchen.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.TabControl tabortsuchen;
        private System.Windows.Forms.TabPage tabverbindungsuchen;
        private System.Windows.Forms.Button btnsearchconnection;
        private System.Windows.Forms.Label lblconnectionto;
        private System.Windows.Forms.Label lblconnectionfrom;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bntcreatelist;
        private System.Windows.Forms.RichTextBox txtplacefrom;
        private System.Windows.Forms.Label lblplacefrom;
        private System.Windows.Forms.RichTextBox txtTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox txtconnectionto;
        private System.Windows.Forms.RichTextBox txtconnectionfrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bntgooglemaps;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

