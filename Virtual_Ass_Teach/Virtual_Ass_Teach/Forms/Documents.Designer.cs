namespace Virtual_Ass_Teach.Forms
{
    partial class Documents
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
            this.DocumentsDV = new System.Windows.Forms.DataGridView();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentsDV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(38, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(581, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocumentsDV
            // 
            this.DocumentsDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DocumentsDV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.DocumentsDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentsDV.GridColor = System.Drawing.Color.Red;
            this.DocumentsDV.Location = new System.Drawing.Point(38, 41);
            this.DocumentsDV.Name = "DocumentsDV";
            this.DocumentsDV.Size = new System.Drawing.Size(581, 562);
            this.DocumentsDV.TabIndex = 9;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtFilePath.Location = new System.Drawing.Point(654, 83);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(395, 31);
            this.txtFilePath.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(770, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Maroon;
            this.btnOpen.Location = new System.Drawing.Point(815, 497);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 31);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowser.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.ForeColor = System.Drawing.Color.Maroon;
            this.btnBrowser.Location = new System.Drawing.Point(708, 227);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(316, 31);
            this.btnBrowser.TabIndex = 7;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1085, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DocumentsDV);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnBrowser);
            this.Name = "Documents";
            this.Text = "Documents";
            this.Load += new System.EventHandler(this.Documents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentsDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DocumentsDV;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBrowser;
    }
}