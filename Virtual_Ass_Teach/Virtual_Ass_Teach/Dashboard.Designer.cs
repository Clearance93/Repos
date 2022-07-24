namespace Virtual_Ass_Teach
{
    partial class Dashboard
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
            this.panelManu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnQuestion_P = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.panelVAT = new System.Windows.Forms.Panel();
            this.labelVAT = new System.Windows.Forms.Label();
            this.panelVitual = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelManu.SuspendLayout();
            this.panelVAT.SuspendLayout();
            this.panelVitual.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManu
            // 
            this.panelManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelManu.Controls.Add(this.btnLogout);
            this.panelManu.Controls.Add(this.btnAssignment);
            this.panelManu.Controls.Add(this.btnQuestion_P);
            this.panelManu.Controls.Add(this.btnAdmin);
            this.panelManu.Controls.Add(this.btnAttendance);
            this.panelManu.Controls.Add(this.panelVAT);
            this.panelManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManu.Location = new System.Drawing.Point(0, 0);
            this.panelManu.Name = "panelManu";
            this.panelManu.Size = new System.Drawing.Size(220, 690);
            this.panelManu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Cyan;
            this.btnLogout.Image = global::Virtual_Ass_Teach.Properties.Resources.logout_rounded_down;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 70);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAssignment
            // 
            this.btnAssignment.FlatAppearance.BorderSize = 0;
            this.btnAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAssignment.Location = new System.Drawing.Point(0, 381);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(220, 80);
            this.btnAssignment.TabIndex = 5;
            this.btnAssignment.Text = "Assignament Dates";
            this.btnAssignment.UseVisualStyleBackColor = true;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // btnQuestion_P
            // 
            this.btnQuestion_P.FlatAppearance.BorderSize = 0;
            this.btnQuestion_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion_P.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuestion_P.Location = new System.Drawing.Point(0, 301);
            this.btnQuestion_P.Name = "btnQuestion_P";
            this.btnQuestion_P.Size = new System.Drawing.Size(220, 80);
            this.btnQuestion_P.TabIndex = 4;
            this.btnQuestion_P.Text = "Authorized Only";
            this.btnQuestion_P.UseVisualStyleBackColor = true;
            this.btnQuestion_P.Click += new System.EventHandler(this.btnQuestion_P_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.Location = new System.Drawing.Point(0, 221);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(220, 80);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAttendance.Location = new System.Drawing.Point(0, 141);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(220, 80);
            this.btnAttendance.TabIndex = 2;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // panelVAT
            // 
            this.panelVAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.panelVAT.Controls.Add(this.labelVAT);
            this.panelVAT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVAT.Location = new System.Drawing.Point(0, 0);
            this.panelVAT.Name = "panelVAT";
            this.panelVAT.Size = new System.Drawing.Size(220, 80);
            this.panelVAT.TabIndex = 1;
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelVAT.Location = new System.Drawing.Point(29, 27);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(138, 13);
            this.labelVAT.TabIndex = 1;
            this.labelVAT.Text = "Virtual Assistance Teaching";
            // 
            // panelVitual
            // 
            this.panelVitual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(131)))));
            this.panelVitual.Controls.Add(this.label2);
            this.panelVitual.Controls.Add(this.label1);
            this.panelVitual.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVitual.Location = new System.Drawing.Point(220, 0);
            this.panelVitual.Name = "panelVitual";
            this.panelVitual.Size = new System.Drawing.Size(786, 80);
            this.panelVitual.TabIndex = 1;
            this.panelVitual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVitual_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(137, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAT Dashboard";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackgroundImage = global::Virtual_Ass_Teach.Properties.Resources.images__9_;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(786, 610);
            this.panelDesktop.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 690);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelVitual);
            this.Controls.Add(this.panelManu);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.panelManu.ResumeLayout(false);
            this.panelVAT.ResumeLayout(false);
            this.panelVAT.PerformLayout();
            this.panelVitual.ResumeLayout(false);
            this.panelVitual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnQuestion_P;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Panel panelVAT;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Panel panelVitual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label2;
    }
}