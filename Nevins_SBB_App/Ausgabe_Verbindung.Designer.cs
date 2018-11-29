namespace Nevins_SBB_App
{
    partial class Ausgabe_Verbindung
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtconnectionfrom = new System.Windows.Forms.RichTextBox();
            this.lbllistfrom = new System.Windows.Forms.Label();
            this.txtconnectionto = new System.Windows.Forms.RichTextBox();
            this.lblconnectionto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 106);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowTemplate.Height = 33;
            this.gridView.Size = new System.Drawing.Size(1318, 618);
            this.gridView.TabIndex = 0;
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
            // Ausgabe_Verbindung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 736);
            this.Controls.Add(this.lblconnectionto);
            this.Controls.Add(this.txtconnectionto);
            this.Controls.Add(this.txtconnectionfrom);
            this.Controls.Add(this.lbllistfrom);
            this.Controls.Add(this.gridView);
            this.Name = "Ausgabe_Verbindung";
            this.Text = "Ausgabe_Verbindung";
            this.Shown += new System.EventHandler(this.Ausgabe_Verbindung_Shown);
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
    }
}