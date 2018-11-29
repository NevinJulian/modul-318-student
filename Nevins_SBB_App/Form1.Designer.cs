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
            this.bntgooglemaps = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabortsuchen.SuspendLayout();
            this.tabverbindungsuchen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblvon
            // 
            this.lblvon.AutoSize = true;
            this.lblvon.Location = new System.Drawing.Point(132, 182);
            this.lblvon.Name = "lblvon";
            this.lblvon.Size = new System.Drawing.Size(0, 25);
            this.lblvon.TabIndex = 0;
            // 
            // tabortsuchen
            // 
            this.tabortsuchen.Controls.Add(this.tabverbindungsuchen);
            this.tabortsuchen.Controls.Add(this.tabPage1);
            this.tabortsuchen.Controls.Add(this.tabPage2);
            this.tabortsuchen.Location = new System.Drawing.Point(12, 12);
            this.tabortsuchen.Name = "tabortsuchen";
            this.tabortsuchen.SelectedIndex = 0;
            this.tabortsuchen.Size = new System.Drawing.Size(950, 326);
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
            this.tabverbindungsuchen.Location = new System.Drawing.Point(8, 39);
            this.tabverbindungsuchen.Name = "tabverbindungsuchen";
            this.tabverbindungsuchen.Padding = new System.Windows.Forms.Padding(3);
            this.tabverbindungsuchen.Size = new System.Drawing.Size(934, 279);
            this.tabverbindungsuchen.TabIndex = 0;
            this.tabverbindungsuchen.Text = "Verbindung suchen";
            this.tabverbindungsuchen.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(680, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(481, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(404, 218);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(245, 38);
            this.txtTime.TabIndex = 6;
            this.txtTime.Text = "";
            // 
            // btnsearchconnection
            // 
            this.btnsearchconnection.Location = new System.Drawing.Point(541, 109);
            this.btnsearchconnection.Name = "btnsearchconnection";
            this.btnsearchconnection.Size = new System.Drawing.Size(295, 68);
            this.btnsearchconnection.TabIndex = 4;
            this.btnsearchconnection.Text = "Verbindung suchen ->";
            this.btnsearchconnection.UseVisualStyleBackColor = true;
            this.btnsearchconnection.Click += new System.EventHandler(this.btnsearchconnection_Click);
            // 
            // txtconnectionto
            // 
            this.txtconnectionto.Location = new System.Drawing.Point(26, 175);
            this.txtconnectionto.Name = "txtconnectionto";
            this.txtconnectionto.Size = new System.Drawing.Size(329, 52);
            this.txtconnectionto.TabIndex = 3;
            this.txtconnectionto.Text = "";
            // 
            // lblconnectionto
            // 
            this.lblconnectionto.AutoSize = true;
            this.lblconnectionto.Location = new System.Drawing.Point(33, 147);
            this.lblconnectionto.Name = "lblconnectionto";
            this.lblconnectionto.Size = new System.Drawing.Size(68, 25);
            this.lblconnectionto.TabIndex = 2;
            this.lblconnectionto.Text = "Nach:";
            // 
            // txtconnectionfrom
            // 
            this.txtconnectionfrom.Location = new System.Drawing.Point(26, 83);
            this.txtconnectionfrom.Name = "txtconnectionfrom";
            this.txtconnectionfrom.Size = new System.Drawing.Size(329, 52);
            this.txtconnectionfrom.TabIndex = 1;
            this.txtconnectionfrom.Text = "";
            this.txtconnectionfrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtconnectionfrom_KeyUp);
            // 
            // lblconnectionfrom
            // 
            this.lblconnectionfrom.AutoSize = true;
            this.lblconnectionfrom.Location = new System.Drawing.Point(33, 55);
            this.lblconnectionfrom.Name = "lblconnectionfrom";
            this.lblconnectionfrom.Size = new System.Drawing.Size(56, 25);
            this.lblconnectionfrom.TabIndex = 0;
            this.lblconnectionfrom.Text = "Von:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bntcreatelist);
            this.tabPage1.Controls.Add(this.txtplacefrom);
            this.tabPage1.Controls.Add(this.lblplacefrom);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(934, 279);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Abfahrtsplan erstellen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bntcreatelist
            // 
            this.bntcreatelist.Location = new System.Drawing.Point(543, 140);
            this.bntcreatelist.Name = "bntcreatelist";
            this.bntcreatelist.Size = new System.Drawing.Size(295, 52);
            this.bntcreatelist.TabIndex = 5;
            this.bntcreatelist.Text = "Abfahrtsliste erstellen";
            this.bntcreatelist.UseVisualStyleBackColor = true;
            this.bntcreatelist.Click += new System.EventHandler(this.bntcreatelist_Click);
            // 
            // txtplacefrom
            // 
            this.txtplacefrom.Location = new System.Drawing.Point(44, 140);
            this.txtplacefrom.Name = "txtplacefrom";
            this.txtplacefrom.Size = new System.Drawing.Size(329, 52);
            this.txtplacefrom.TabIndex = 3;
            this.txtplacefrom.Text = "";
            // 
            // lblplacefrom
            // 
            this.lblplacefrom.AutoSize = true;
            this.lblplacefrom.Location = new System.Drawing.Point(27, 112);
            this.lblplacefrom.Name = "lblplacefrom";
            this.lblplacefrom.Size = new System.Drawing.Size(56, 25);
            this.lblplacefrom.TabIndex = 2;
            this.lblplacefrom.Text = "Von:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Controls.Add(this.bntgooglemaps);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 279);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Stationen in der nähe finden";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bntgooglemaps
            // 
            this.bntgooglemaps.Location = new System.Drawing.Point(655, 61);
            this.bntgooglemaps.Name = "bntgooglemaps";
            this.bntgooglemaps.Size = new System.Drawing.Size(217, 51);
            this.bntgooglemaps.TabIndex = 0;
            this.bntgooglemaps.Text = "Google Maps";
            this.bntgooglemaps.UseVisualStyleBackColor = true;
            this.bntgooglemaps.Click += new System.EventHandler(this.bntgooglemaps_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(629, 275);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 344);
            this.Controls.Add(this.tabortsuchen);
            this.Controls.Add(this.lblvon);
            this.MaximumSize = new System.Drawing.Size(1000, 415);
            this.MinimumSize = new System.Drawing.Size(1000, 415);
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

