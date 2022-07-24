namespace Virtual_Ass_Teach.Forms
{
    partial class Learner_s_Register
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
            this.txtLearner = new System.Windows.Forms.TextBox();
            this.Learner_infoDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Learner_infoDV)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(638, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(638, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLearner
            // 
            this.txtLearner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLearner.BackColor = System.Drawing.SystemColors.Control;
            this.txtLearner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearner.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtLearner.Location = new System.Drawing.Point(638, 128);
            this.txtLearner.Multiline = true;
            this.txtLearner.Name = "txtLearner";
            this.txtLearner.Size = new System.Drawing.Size(341, 54);
            this.txtLearner.TabIndex = 6;
            // 
            // Learner_infoDV
            // 
            this.Learner_infoDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Learner_infoDV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.Learner_infoDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Learner_infoDV.Location = new System.Drawing.Point(12, 44);
            this.Learner_infoDV.Name = "Learner_infoDV";
            this.Learner_infoDV.Size = new System.Drawing.Size(588, 543);
            this.Learner_infoDV.TabIndex = 5;
            // 
            // Learner_s_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1018, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLearner);
            this.Controls.Add(this.Learner_infoDV);
            this.Name = "Learner_s_Register";
            this.Text = "Learner_s_Register";
            this.Load += new System.EventHandler(this.Learner_s_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Learner_infoDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLearner;
        private System.Windows.Forms.DataGridView Learner_infoDV;
    }
}