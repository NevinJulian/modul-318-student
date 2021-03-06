﻿namespace Nevins_SBB_App
{
    partial class DisplayConnections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayConnections));
            this.gridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtconnectionfrom = new System.Windows.Forms.RichTextBox();
            this.lbllistfrom = new System.Windows.Forms.Label();
            this.txtconnectionto = new System.Windows.Forms.RichTextBox();
            this.lblconnectionto = new System.Windows.Forms.Label();
            this.bntCancel = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 106);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowTemplate.Height = 33;
            this.gridView.Size = new System.Drawing.Size(1318, 718);
            this.gridView.TabIndex = 0;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // txtconnectionfrom
            // 
            this.txtconnectionfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.txtconnectionfrom.Location = new System.Drawing.Point(204, 27);
            this.txtconnectionfrom.Name = "txtconnectionfrom";
            this.txtconnectionfrom.ReadOnly = true;
            this.txtconnectionfrom.Size = new System.Drawing.Size(280, 47);
            this.txtconnectionfrom.TabIndex = 5;
            this.txtconnectionfrom.Text = "";
            // 
            // lbllistfrom
            // 
            this.lbllistfrom.AutoSize = true;
            this.lbllistfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.lbllistfrom.Location = new System.Drawing.Point(124, 41);
            this.lbllistfrom.Name = "lbllistfrom";
            this.lbllistfrom.Size = new System.Drawing.Size(74, 33);
            this.lbllistfrom.TabIndex = 4;
            this.lbllistfrom.Text = "Von:";
            // 
            // txtconnectionto
            // 
            this.txtconnectionto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.txtconnectionto.Location = new System.Drawing.Point(778, 27);
            this.txtconnectionto.Name = "txtconnectionto";
            this.txtconnectionto.ReadOnly = true;
            this.txtconnectionto.Size = new System.Drawing.Size(280, 47);
            this.txtconnectionto.TabIndex = 6;
            this.txtconnectionto.Text = "";
            // 
            // lblconnectionto
            // 
            this.lblconnectionto.AutoSize = true;
            this.lblconnectionto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.lblconnectionto.Location = new System.Drawing.Point(681, 41);
            this.lblconnectionto.Name = "lblconnectionto";
            this.lblconnectionto.Size = new System.Drawing.Size(91, 33);
            this.lblconnectionto.TabIndex = 7;
            this.lblconnectionto.Text = "Nach:";
            // 
            // bntCancel
            // 
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancel.Location = new System.Drawing.Point(1076, 845);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(254, 56);
            this.bntCancel.TabIndex = 8;
            this.bntCancel.Text = "Abbrechen";
            this.bntCancel.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(7, 861);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(532, 25);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "*Doppelklick auf eine Zeile um Routenplaner zu öffnen";
            // 
            // DisplayConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntCancel;
            this.ClientSize = new System.Drawing.Size(1340, 913);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.lblconnectionto);
            this.Controls.Add(this.txtconnectionto);
            this.Controls.Add(this.txtconnectionfrom);
            this.Controls.Add(this.lbllistfrom);
            this.Controls.Add(this.gridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayConnections";
            this.Text = "Ausgabe_Verbindung";
            this.Shown += new System.EventHandler(this.DisplayConnection_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.RichTextBox txtconnectionfrom;
        private System.Windows.Forms.Label lbllistfrom;
        private System.Windows.Forms.RichTextBox txtconnectionto;
        private System.Windows.Forms.Label lblconnectionto;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Label lblInfo;
    }
}