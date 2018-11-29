namespace Nevins_SBB_App
{
    partial class Abfahrtsliste_ausgabe
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
            this.lbllistfrom = new System.Windows.Forms.Label();
            this.txtlistfrom = new System.Windows.Forms.RichTextBox();
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
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 88);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowTemplate.Height = 33;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridView.Size = new System.Drawing.Size(1276, 626);
            this.gridView.TabIndex = 1;
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
            // Abfahrtsliste_ausgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 726);
            this.Controls.Add(this.txtlistfrom);
            this.Controls.Add(this.lbllistfrom);
            this.Controls.Add(this.gridView);
            this.Name = "Abfahrtsliste_ausgabe";
            this.Text = "Abfahrtsliste_ausgabe";
            this.Shown += new System.EventHandler(this.Abfahrtsliste_ausgabe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label lbllistfrom;
        private System.Windows.Forms.RichTextBox txtlistfrom;
    }
}