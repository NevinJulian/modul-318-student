namespace Nevins_SBB_App
{
    partial class SBBApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBBApp));
            this.lblvon = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listPlaceFrom = new System.Windows.Forms.ListBox();
            this.txtPlaceFrom = new System.Windows.Forms.TextBox();
            this.bntCreateList = new System.Windows.Forms.Button();
            this.lblPlaceFrom = new System.Windows.Forms.Label();
            this.tabverbindungsuchen = new System.Windows.Forms.TabPage();
            this.listConnectionTo = new System.Windows.Forms.ListBox();
            this.listConnectionFrom = new System.Windows.Forms.ListBox();
            this.lblErrorOne = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtConnectionTo = new System.Windows.Forms.TextBox();
            this.txtConnectionFrom = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.lblConnectionTo = new System.Windows.Forms.Label();
            this.lblConnectionFrom = new System.Windows.Forms.Label();
            this.tabortsuchen = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabverbindungsuchen.SuspendLayout();
            this.tabortsuchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblvon
            // 
            this.lblvon.AutoSize = true;
            this.lblvon.Location = new System.Drawing.Point(132, 183);
            this.lblvon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvon.Name = "lblvon";
            this.lblvon.Size = new System.Drawing.Size(0, 25);
            this.lblvon.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listPlaceFrom);
            this.tabPage1.Controls.Add(this.txtPlaceFrom);
            this.tabPage1.Controls.Add(this.bntCreateList);
            this.tabPage1.Controls.Add(this.lblPlaceFrom);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1385, 418);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Abfahrtsplan erstellen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listPlaceFrom
            // 
            this.listPlaceFrom.FormattingEnabled = true;
            this.listPlaceFrom.ItemHeight = 25;
            this.listPlaceFrom.Location = new System.Drawing.Point(34, 125);
            this.listPlaceFrom.Name = "listPlaceFrom";
            this.listPlaceFrom.Size = new System.Drawing.Size(314, 279);
            this.listPlaceFrom.TabIndex = 14;
            this.listPlaceFrom.DoubleClick += new System.EventHandler(this.listplacefrom_DoubleClick);
            // 
            // txtPlaceFrom
            // 
            this.txtPlaceFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPlaceFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlaceFrom.Location = new System.Drawing.Point(34, 87);
            this.txtPlaceFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaceFrom.Name = "txtPlaceFrom";
            this.txtPlaceFrom.Size = new System.Drawing.Size(314, 31);
            this.txtPlaceFrom.TabIndex = 10;
            this.txtPlaceFrom.TextChanged += new System.EventHandler(this.txtplacefrom_TextChanged);
            // 
            // bntCreateList
            // 
            this.bntCreateList.Location = new System.Drawing.Point(518, 79);
            this.bntCreateList.Margin = new System.Windows.Forms.Padding(4);
            this.bntCreateList.Name = "bntCreateList";
            this.bntCreateList.Size = new System.Drawing.Size(296, 52);
            this.bntCreateList.TabIndex = 5;
            this.bntCreateList.Text = "Abfahrtsliste erstellen";
            this.bntCreateList.UseVisualStyleBackColor = true;
            this.bntCreateList.Click += new System.EventHandler(this.bntcreatelist_Click);
            // 
            // lblPlaceFrom
            // 
            this.lblPlaceFrom.AutoSize = true;
            this.lblPlaceFrom.Location = new System.Drawing.Point(28, 58);
            this.lblPlaceFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaceFrom.Name = "lblPlaceFrom";
            this.lblPlaceFrom.Size = new System.Drawing.Size(56, 25);
            this.lblPlaceFrom.TabIndex = 9;
            this.lblPlaceFrom.Text = "Von:";
            // 
            // tabverbindungsuchen
            // 
            this.tabverbindungsuchen.Controls.Add(this.listConnectionTo);
            this.tabverbindungsuchen.Controls.Add(this.listConnectionFrom);
            this.tabverbindungsuchen.Controls.Add(this.lblErrorOne);
            this.tabverbindungsuchen.Controls.Add(this.lblDate);
            this.tabverbindungsuchen.Controls.Add(this.lblTime);
            this.tabverbindungsuchen.Controls.Add(this.txtConnectionTo);
            this.tabverbindungsuchen.Controls.Add(this.txtConnectionFrom);
            this.tabverbindungsuchen.Controls.Add(this.txtTime);
            this.tabverbindungsuchen.Controls.Add(this.dateTimePicker);
            this.tabverbindungsuchen.Controls.Add(this.btnSearchConnection);
            this.tabverbindungsuchen.Controls.Add(this.lblConnectionTo);
            this.tabverbindungsuchen.Controls.Add(this.lblConnectionFrom);
            this.tabverbindungsuchen.Location = new System.Drawing.Point(8, 39);
            this.tabverbindungsuchen.Margin = new System.Windows.Forms.Padding(4);
            this.tabverbindungsuchen.Name = "tabverbindungsuchen";
            this.tabverbindungsuchen.Padding = new System.Windows.Forms.Padding(4);
            this.tabverbindungsuchen.Size = new System.Drawing.Size(1385, 418);
            this.tabverbindungsuchen.TabIndex = 0;
            this.tabverbindungsuchen.Text = "Verbindung suchen";
            this.tabverbindungsuchen.UseVisualStyleBackColor = true;
            // 
            // listConnectionTo
            // 
            this.listConnectionTo.FormattingEnabled = true;
            this.listConnectionTo.ItemHeight = 25;
            this.listConnectionTo.Location = new System.Drawing.Point(493, 123);
            this.listConnectionTo.Name = "listConnectionTo";
            this.listConnectionTo.Size = new System.Drawing.Size(314, 279);
            this.listConnectionTo.TabIndex = 14;
            this.listConnectionTo.DoubleClick += new System.EventHandler(this.listconnectionto_DoubleClick);
            // 
            // listConnectionFrom
            // 
            this.listConnectionFrom.FormattingEnabled = true;
            this.listConnectionFrom.ItemHeight = 25;
            this.listConnectionFrom.Location = new System.Drawing.Point(38, 123);
            this.listConnectionFrom.Name = "listConnectionFrom";
            this.listConnectionFrom.Size = new System.Drawing.Size(314, 279);
            this.listConnectionFrom.TabIndex = 13;
            this.listConnectionFrom.DoubleClick += new System.EventHandler(this.listconnectionfrom_DoubleClick);
            this.listConnectionFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListFromKeyControll);
            // 
            // lblErrorOne
            // 
            this.lblErrorOne.AutoSize = true;
            this.lblErrorOne.Location = new System.Drawing.Point(424, 260);
            this.lblErrorOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorOne.Name = "lblErrorOne";
            this.lblErrorOne.Size = new System.Drawing.Size(0, 25);
            this.lblErrorOne.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1029, 246);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 25);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "&Datum:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1029, 168);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 25);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "&Zeit:";
            // 
            // txtConnectionTo
            // 
            this.txtConnectionTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtConnectionTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtConnectionTo.Location = new System.Drawing.Point(493, 85);
            this.txtConnectionTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtConnectionTo.Name = "txtConnectionTo";
            this.txtConnectionTo.Size = new System.Drawing.Size(314, 31);
            this.txtConnectionTo.TabIndex = 4;
            this.txtConnectionTo.TextChanged += new System.EventHandler(this.txtconnectionto_TextChanged);
            // 
            // txtConnectionFrom
            // 
            this.txtConnectionFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtConnectionFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtConnectionFrom.Location = new System.Drawing.Point(38, 85);
            this.txtConnectionFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtConnectionFrom.Name = "txtConnectionFrom";
            this.txtConnectionFrom.Size = new System.Drawing.Size(314, 31);
            this.txtConnectionFrom.TabIndex = 2;
            this.txtConnectionFrom.TextChanged += new System.EventHandler(this.txtconnectionfrom_TextChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(1034, 194);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(244, 39);
            this.txtTime.TabIndex = 6;
            this.txtTime.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(1034, 275);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(244, 31);
            this.dateTimePicker.TabIndex = 8;
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(1034, 49);
            this.btnSearchConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(296, 67);
            this.btnSearchConnection.TabIndex = 11;
            this.btnSearchConnection.Text = "Verbindung suchen ->";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnsearchconnection_Click);
            // 
            // lblConnectionTo
            // 
            this.lblConnectionTo.AutoSize = true;
            this.lblConnectionTo.Location = new System.Drawing.Point(488, 56);
            this.lblConnectionTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionTo.Name = "lblConnectionTo";
            this.lblConnectionTo.Size = new System.Drawing.Size(68, 25);
            this.lblConnectionTo.TabIndex = 3;
            this.lblConnectionTo.Text = "&Nach:";
            // 
            // lblConnectionFrom
            // 
            this.lblConnectionFrom.AutoSize = true;
            this.lblConnectionFrom.Location = new System.Drawing.Point(32, 56);
            this.lblConnectionFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionFrom.Name = "lblConnectionFrom";
            this.lblConnectionFrom.Size = new System.Drawing.Size(56, 25);
            this.lblConnectionFrom.TabIndex = 1;
            this.lblConnectionFrom.Text = "&Von:";
            // 
            // tabortsuchen
            // 
            this.tabortsuchen.Controls.Add(this.tabverbindungsuchen);
            this.tabortsuchen.Controls.Add(this.tabPage1);
            this.tabortsuchen.Location = new System.Drawing.Point(12, 13);
            this.tabortsuchen.Margin = new System.Windows.Forms.Padding(4);
            this.tabortsuchen.Name = "tabortsuchen";
            this.tabortsuchen.SelectedIndex = 0;
            this.tabortsuchen.Size = new System.Drawing.Size(1401, 465);
            this.tabortsuchen.TabIndex = 1;
            // 
            // SBBApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1426, 479);
            this.Controls.Add(this.tabortsuchen);
            this.Controls.Add(this.lblvon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(990, 386);
            this.Name = "SBBApp";
            this.Text = "SBB Fahrplan";
            this.Shown += new System.EventHandler(this.SBBApp_Shown);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabverbindungsuchen.ResumeLayout(false);
            this.tabverbindungsuchen.PerformLayout();
            this.tabortsuchen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listPlaceFrom;
        private System.Windows.Forms.TextBox txtPlaceFrom;
        private System.Windows.Forms.Button bntCreateList;
        private System.Windows.Forms.Label lblPlaceFrom;
        private System.Windows.Forms.TabPage tabverbindungsuchen;
        private System.Windows.Forms.ListBox listConnectionTo;
        private System.Windows.Forms.ListBox listConnectionFrom;
        private System.Windows.Forms.Label lblErrorOne;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtConnectionTo;
        private System.Windows.Forms.TextBox txtConnectionFrom;
        private System.Windows.Forms.RichTextBox txtTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Label lblConnectionTo;
        private System.Windows.Forms.Label lblConnectionFrom;
        private System.Windows.Forms.TabControl tabortsuchen;
    }
}

