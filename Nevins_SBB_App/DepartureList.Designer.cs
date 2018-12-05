namespace Nevins_SBB_App
{
    partial class DepartureList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartureList));
            this.gridView = new System.Windows.Forms.DataGridView();
            this.lbllistfrom = new System.Windows.Forms.Label();
            this.txtlistfrom = new System.Windows.Forms.RichTextBox();
            this.bntCancel = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 88);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowTemplate.Height = 33;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridView.Size = new System.Drawing.Size(1260, 703);
            this.gridView.TabIndex = 1;
            this.gridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentDoubleClick);
            // 
            // lbllistfrom
            // 
            this.lbllistfrom.AutoSize = true;
            this.lbllistfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.lbllistfrom.Location = new System.Drawing.Point(347, 34);
            this.lbllistfrom.Name = "lbllistfrom";
            this.lbllistfrom.Size = new System.Drawing.Size(74, 33);
            this.lbllistfrom.TabIndex = 2;
            this.lbllistfrom.Text = "Von:";
            // 
            // txtlistfrom
            // 
            this.txtlistfrom.Location = new System.Drawing.Point(455, 20);
            this.txtlistfrom.Name = "txtlistfrom";
            this.txtlistfrom.ReadOnly = true;
            this.txtlistfrom.Size = new System.Drawing.Size(280, 47);
            this.txtlistfrom.TabIndex = 3;
            this.txtlistfrom.Text = "";
            // 
            // bntCancel
            // 
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancel.Location = new System.Drawing.Point(1018, 797);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(254, 56);
            this.bntCancel.TabIndex = 4;
            this.bntCancel.Text = "Abbrechen";
            this.bntCancel.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(7, 813);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(532, 25);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "*Doppelklick auf eine Zeile um Routenplaner zu öffnen";
            // 
            // DepartureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntCancel;
            this.ClientSize = new System.Drawing.Size(1288, 875);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.txtlistfrom);
            this.Controls.Add(this.lbllistfrom);
            this.Controls.Add(this.gridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartureList";
            this.Text = "Abfahrtsliste_ausgabe";
            this.Shown += new System.EventHandler(this.DepartureList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label lbllistfrom;
        private System.Windows.Forms.RichTextBox txtlistfrom;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Label lblInfo;
    }
}