namespace Dashboard_01
{
    partial class notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.matbtn = new System.Windows.Forms.Button();
            this.notebtn = new System.Windows.Forms.Button();
            this.qzbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.matbtn);
            this.panel1.Controls.Add(this.notebtn);
            this.panel1.Controls.Add(this.qzbtn);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 100);
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "LEARNEX";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1210, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 97);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1348, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 89);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // matbtn
            // 
            this.matbtn.BackColor = System.Drawing.Color.Transparent;
            this.matbtn.FlatAppearance.BorderSize = 0;
            this.matbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matbtn.ForeColor = System.Drawing.Color.White;
            this.matbtn.Location = new System.Drawing.Point(856, 0);
            this.matbtn.Name = "matbtn";
            this.matbtn.Size = new System.Drawing.Size(192, 98);
            this.matbtn.TabIndex = 3;
            this.matbtn.Text = "MATERIALS";
            this.matbtn.UseVisualStyleBackColor = false;
            this.matbtn.Click += new System.EventHandler(this.matbtn_Click);
            // 
            // notebtn
            // 
            this.notebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.notebtn.FlatAppearance.BorderSize = 0;
            this.notebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebtn.ForeColor = System.Drawing.Color.White;
            this.notebtn.Location = new System.Drawing.Point(698, 3);
            this.notebtn.Name = "notebtn";
            this.notebtn.Size = new System.Drawing.Size(152, 97);
            this.notebtn.TabIndex = 2;
            this.notebtn.Text = "NOTES";
            this.notebtn.UseVisualStyleBackColor = false;
            this.notebtn.Click += new System.EventHandler(this.notebtn_Click);
            // 
            // qzbtn
            // 
            this.qzbtn.BackColor = System.Drawing.Color.Transparent;
            this.qzbtn.FlatAppearance.BorderSize = 0;
            this.qzbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qzbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qzbtn.ForeColor = System.Drawing.Color.White;
            this.qzbtn.Location = new System.Drawing.Point(536, 3);
            this.qzbtn.Name = "qzbtn";
            this.qzbtn.Size = new System.Drawing.Size(156, 95);
            this.qzbtn.TabIndex = 1;
            this.qzbtn.Text = "QUIZES";
            this.qzbtn.UseVisualStyleBackColor = false;
            this.qzbtn.Click += new System.EventHandler(this.qzbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Transparent;
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.Location = new System.Drawing.Point(370, 0);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(142, 102);
            this.homebtn.TabIndex = 0;
            this.homebtn.Text = "HOME";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 863);
            this.Controls.Add(this.panel1);
            this.Name = "notes";
            this.Text = "Notes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button matbtn;
        private System.Windows.Forms.Button notebtn;
        private System.Windows.Forms.Button qzbtn;
        private System.Windows.Forms.Button homebtn;
    }
}