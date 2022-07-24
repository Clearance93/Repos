namespace Virtual_Ass_Teach.Forms
{
    partial class Assignment
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
            this.AssignmentDateDV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentDateDV)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignmentDateDV
            // 
            this.AssignmentDateDV.BackgroundColor = System.Drawing.Color.Cyan;
            this.AssignmentDateDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentDateDV.Location = new System.Drawing.Point(160, 12);
            this.AssignmentDateDV.Name = "AssignmentDateDV";
            this.AssignmentDateDV.Size = new System.Drawing.Size(650, 542);
            this.AssignmentDateDV.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(613, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(160, 564);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(447, 26);
            this.txtDelete.TabIndex = 13;
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(977, 596);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AssignmentDateDV);
            this.Name = "Assignment";
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentDateDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AssignmentDateDV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDelete;
    }
}