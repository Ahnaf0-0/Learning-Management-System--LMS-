namespace Frame_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mDFHASNATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tARIKULISLAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aHNAFHASANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDFHASNATToolStripMenuItem,
            this.tARIKULISLAMToolStripMenuItem,
            this.aHNAFHASANToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 100);
            // 
            // mDFHASNATToolStripMenuItem
            // 
            this.mDFHASNATToolStripMenuItem.Name = "mDFHASNATToolStripMenuItem";
            this.mDFHASNATToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.mDFHASNATToolStripMenuItem.Text = "MD_F_HASNAT";
            // 
            // tARIKULISLAMToolStripMenuItem
            // 
            this.tARIKULISLAMToolStripMenuItem.Name = "tARIKULISLAMToolStripMenuItem";
            this.tARIKULISLAMToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.tARIKULISLAMToolStripMenuItem.Text = "TARIKUL_ISLAM";
            // 
            // aHNAFHASANToolStripMenuItem
            // 
            this.aHNAFHASANToolStripMenuItem.Name = "aHNAFHASANToolStripMenuItem";
            this.aHNAFHASANToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.aHNAFHASANToolStripMenuItem.Text = "AHNAF_HASAN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(943, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click Here..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1221";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDFHASNATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tARIKULISLAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aHNAFHASANToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

