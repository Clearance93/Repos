namespace Virtual_Ass_Teach.Forms
{
    partial class Assignment_MArks
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
            this.Assignment_MarksDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Assignment_MarksDV)).BeginInit();
            this.SuspendLayout();
            // 
            // Assignment_MarksDV
            // 
            this.Assignment_MarksDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Assignment_MarksDV.BackgroundColor = System.Drawing.Color.Cyan;
            this.Assignment_MarksDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Assignment_MarksDV.Location = new System.Drawing.Point(117, 24);
            this.Assignment_MarksDV.Name = "Assignment_MarksDV";
            this.Assignment_MarksDV.Size = new System.Drawing.Size(811, 588);
            this.Assignment_MarksDV.TabIndex = 0;
            // 
            // Assignment_MArks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1008, 650);
            this.Controls.Add(this.Assignment_MarksDV);
            this.Name = "Assignment_MArks";
            this.Text = "Assignment_MArks";
            this.Load += new System.EventHandler(this.Assignment_MArks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Assignment_MarksDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Assignment_MarksDV;
    }
}