namespace Virtual_Ass_Teach.Forms
{
    partial class Memorundum_upload
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
            this.memorandumDV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtmemorundum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.memorandumDV)).BeginInit();
            this.SuspendLayout();
            // 
            // memorandumDV
            // 
            this.memorandumDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memorandumDV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.memorandumDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memorandumDV.Location = new System.Drawing.Point(45, 41);
            this.memorandumDV.Name = "memorandumDV";
            this.memorandumDV.Size = new System.Drawing.Size(657, 513);
            this.memorandumDV.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(749, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "browser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(749, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(749, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 61);
            this.button3.TabIndex = 1;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtmemorundum
            // 
            this.txtmemorundum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtmemorundum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmemorundum.ForeColor = System.Drawing.Color.Maroon;
            this.txtmemorundum.Location = new System.Drawing.Point(749, 41);
            this.txtmemorundum.Name = "txtmemorundum";
            this.txtmemorundum.Size = new System.Drawing.Size(280, 26);
            this.txtmemorundum.TabIndex = 2;
            // 
            // Memorundum_upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 627);
            this.Controls.Add(this.txtmemorundum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memorandumDV);
            this.Name = "Memorundum_upload";
            this.Text = "Memorundum_upload";
            this.Load += new System.EventHandler(this.Memorundum_upload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memorandumDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memorandumDV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtmemorundum;
    }
}