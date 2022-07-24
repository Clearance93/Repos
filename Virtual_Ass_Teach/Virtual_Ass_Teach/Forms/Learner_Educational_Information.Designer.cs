namespace Virtual_Ass_Teach.Forms
{
    partial class Learner_Educational_Information
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEdu_VAT_Nu = new System.Windows.Forms.TextBox();
            this.EducationDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EducationDV)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(655, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(329, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEdu_VAT_Nu
            // 
            this.txtEdu_VAT_Nu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEdu_VAT_Nu.BackColor = System.Drawing.SystemColors.Control;
            this.txtEdu_VAT_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdu_VAT_Nu.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtEdu_VAT_Nu.Location = new System.Drawing.Point(24, 620);
            this.txtEdu_VAT_Nu.Multiline = true;
            this.txtEdu_VAT_Nu.Name = "txtEdu_VAT_Nu";
            this.txtEdu_VAT_Nu.Size = new System.Drawing.Size(299, 40);
            this.txtEdu_VAT_Nu.TabIndex = 6;
            // 
            // EducationDV
            // 
            this.EducationDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationDV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.EducationDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EducationDV.Location = new System.Drawing.Point(24, 12);
            this.EducationDV.Name = "EducationDV";
            this.EducationDV.Size = new System.Drawing.Size(966, 589);
            this.EducationDV.TabIndex = 5;
            // 
            // Learner_Educational_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1035, 738);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEdu_VAT_Nu);
            this.Controls.Add(this.EducationDV);
            this.Name = "Learner_Educational_Information";
            this.Text = "Learner_Educational_Information";
            this.Load += new System.EventHandler(this.Learner_Educational_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EducationDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEdu_VAT_Nu;
        private System.Windows.Forms.DataGridView EducationDV;
    }
}