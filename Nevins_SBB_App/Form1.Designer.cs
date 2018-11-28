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
            this.btnsearchconnection = new System.Windows.Forms.Button();
            this.txtconnectionto = new System.Windows.Forms.RichTextBox();
            this.lblconnectionto = new System.Windows.Forms.Label();
            this.txtconnectionfrom = new System.Windows.Forms.RichTextBox();
            this.lblconnectionfrom = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtplacefrom = new System.Windows.Forms.RichTextBox();
            this.lblplacefrom = new System.Windows.Forms.Label();
            this.bntcreatelist = new System.Windows.Forms.Button();
            this.tabortsuchen.SuspendLayout();
            this.tabverbindungsuchen.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabortsuchen.Location = new System.Drawing.Point(12, 12);
            this.tabortsuchen.Name = "tabortsuchen";
            this.tabortsuchen.SelectedIndex = 0;
            this.tabortsuchen.Size = new System.Drawing.Size(950, 428);
            this.tabortsuchen.TabIndex = 1;
            // 
            // tabverbindungsuchen
            // 
            this.tabverbindungsuchen.Controls.Add(this.btnsearchconnection);
            this.tabverbindungsuchen.Controls.Add(this.txtconnectionto);
            this.tabverbindungsuchen.Controls.Add(this.lblconnectionto);
            this.tabverbindungsuchen.Controls.Add(this.txtconnectionfrom);
            this.tabverbindungsuchen.Controls.Add(this.lblconnectionfrom);
            this.tabverbindungsuchen.Location = new System.Drawing.Point(8, 39);
            this.tabverbindungsuchen.Name = "tabverbindungsuchen";
            this.tabverbindungsuchen.Padding = new System.Windows.Forms.Padding(3);
            this.tabverbindungsuchen.Size = new System.Drawing.Size(934, 381);
            this.tabverbindungsuchen.TabIndex = 0;
            this.tabverbindungsuchen.Text = "Verbindung suchen";
            this.tabverbindungsuchen.UseVisualStyleBackColor = true;
            // 
            // btnsearchconnection
            // 
            this.btnsearchconnection.Location = new System.Drawing.Point(541, 109);
            this.btnsearchconnection.Name = "btnsearchconnection";
            this.btnsearchconnection.Size = new System.Drawing.Size(295, 68);
            this.btnsearchconnection.TabIndex = 4;
            this.btnsearchconnection.Text = "Verbindung suchen ->";
            this.btnsearchconnection.UseVisualStyleBackColor = true;
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
            this.tabPage1.Size = new System.Drawing.Size(934, 381);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Abfahrtsplan erstellen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtplacefrom
            // 
            this.txtplacefrom.Location = new System.Drawing.Point(20, 140);
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
            // bntcreatelist
            // 
            this.bntcreatelist.Location = new System.Drawing.Point(537, 131);
            this.bntcreatelist.Name = "bntcreatelist";
            this.bntcreatelist.Size = new System.Drawing.Size(295, 68);
            this.bntcreatelist.TabIndex = 5;
            this.bntcreatelist.Text = "Abfahrtsliste erstellen";
            this.bntcreatelist.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 452);
            this.Controls.Add(this.tabortsuchen);
            this.Controls.Add(this.lblvon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabortsuchen.ResumeLayout(false);
            this.tabverbindungsuchen.ResumeLayout(false);
            this.tabverbindungsuchen.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.TabControl tabortsuchen;
        private System.Windows.Forms.TabPage tabverbindungsuchen;
        private System.Windows.Forms.Button btnsearchconnection;
        private System.Windows.Forms.RichTextBox txtconnectionto;
        private System.Windows.Forms.Label lblconnectionto;
        private System.Windows.Forms.RichTextBox txtconnectionfrom;
        private System.Windows.Forms.Label lblconnectionfrom;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bntcreatelist;
        private System.Windows.Forms.RichTextBox txtplacefrom;
        private System.Windows.Forms.Label lblplacefrom;
    }
}

