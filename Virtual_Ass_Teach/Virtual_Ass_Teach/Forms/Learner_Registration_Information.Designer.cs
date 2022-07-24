namespace Virtual_Ass_Teach.Forms
{
    partial class Learner_Registration_Information
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtL_VAT_Id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LearnerDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LearnerDV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(409, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtL_VAT_Id
            // 
            this.txtL_VAT_Id.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtL_VAT_Id.BackColor = System.Drawing.SystemColors.Control;
            this.txtL_VAT_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL_VAT_Id.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtL_VAT_Id.Location = new System.Drawing.Point(56, 560);
            this.txtL_VAT_Id.Multiline = true;
            this.txtL_VAT_Id.Name = "txtL_VAT_Id";
            this.txtL_VAT_Id.Size = new System.Drawing.Size(347, 39);
            this.txtL_VAT_Id.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(718, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LearnerDV
            // 
            this.LearnerDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LearnerDV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.LearnerDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LearnerDV.Location = new System.Drawing.Point(56, 23);
            this.LearnerDV.Name = "LearnerDV";
            this.LearnerDV.Size = new System.Drawing.Size(985, 503);
            this.LearnerDV.TabIndex = 6;
            // 
            // Learner_Registration_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1081, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtL_VAT_Id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LearnerDV);
            this.Name = "Learner_Registration_Information";
            this.Text = "Learner_Registration_Information";
            this.Load += new System.EventHandler(this.Learner_Registration_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LearnerDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtL_VAT_Id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView LearnerDV;
    }
}