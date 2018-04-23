namespace Gen1
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
            this.m_Preview = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_Dimension = new System.Windows.Forms.TextBox();
            this.m_Sites = new System.Windows.Forms.TextBox();
            this.m_Generate = new System.Windows.Forms.Button();
            this.m_Seed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_Preview
            // 
            this.m_Preview.Location = new System.Drawing.Point(12, 12);
            this.m_Preview.Name = "m_Preview";
            this.m_Preview.Size = new System.Drawing.Size(1083, 658);
            this.m_Preview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 710);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sites";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 684);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dimension";
            // 
            // m_Dimension
            // 
            this.m_Dimension.Location = new System.Drawing.Point(74, 681);
            this.m_Dimension.Name = "m_Dimension";
            this.m_Dimension.Size = new System.Drawing.Size(100, 20);
            this.m_Dimension.TabIndex = 3;
            // 
            // m_Sites
            // 
            this.m_Sites.Location = new System.Drawing.Point(74, 707);
            this.m_Sites.Name = "m_Sites";
            this.m_Sites.Size = new System.Drawing.Size(100, 20);
            this.m_Sites.TabIndex = 4;
            // 
            // m_Generate
            // 
            this.m_Generate.Location = new System.Drawing.Point(180, 684);
            this.m_Generate.Name = "m_Generate";
            this.m_Generate.Size = new System.Drawing.Size(75, 45);
            this.m_Generate.TabIndex = 5;
            this.m_Generate.Text = "Generate";
            this.m_Generate.UseVisualStyleBackColor = true;
            this.m_Generate.Click += new System.EventHandler(this.m_Generate_Click);
            // 
            // m_Seed
            // 
            this.m_Seed.Location = new System.Drawing.Point(74, 733);
            this.m_Seed.Name = "m_Seed";
            this.m_Seed.Size = new System.Drawing.Size(100, 20);
            this.m_Seed.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 777);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_Seed);
            this.Controls.Add(this.m_Generate);
            this.Controls.Add(this.m_Sites);
            this.Controls.Add(this.m_Dimension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_Preview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel m_Preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_Dimension;
        private System.Windows.Forms.TextBox m_Sites;
        private System.Windows.Forms.Button m_Generate;
        private System.Windows.Forms.TextBox m_Seed;
        private System.Windows.Forms.Label label3;
    }
}

