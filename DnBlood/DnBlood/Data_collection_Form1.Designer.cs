namespace DnBlood
{
    partial class Data_collection_Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.M_button = new System.Windows.Forms.Button();
            this.S_button = new System.Windows.Forms.Button();
            this.E_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.E_button);
            this.panel1.Controls.Add(this.S_button);
            this.panel1.Controls.Add(this.M_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 640);
            this.panel1.TabIndex = 0;
            // 
            // M_button
            // 
            this.M_button.BackColor = System.Drawing.Color.IndianRed;
            this.M_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.M_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.M_button.Location = new System.Drawing.Point(190, 241);
            this.M_button.Name = "M_button";
            this.M_button.Size = new System.Drawing.Size(382, 97);
            this.M_button.TabIndex = 0;
            this.M_button.Text = "จัดการโครงการ";
            this.M_button.UseVisualStyleBackColor = false;
            this.M_button.Click += new System.EventHandler(this.M_button_Click);
            // 
            // S_button
            // 
            this.S_button.BackColor = System.Drawing.Color.IndianRed;
            this.S_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.S_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.S_button.Location = new System.Drawing.Point(190, 368);
            this.S_button.Name = "S_button";
            this.S_button.Size = new System.Drawing.Size(382, 97);
            this.S_button.TabIndex = 1;
            this.S_button.Text = "จัดเก็บข้อมูลสถิติ";
            this.S_button.UseVisualStyleBackColor = false;
            this.S_button.Click += new System.EventHandler(this.S_button_Click);
            // 
            // E_button
            // 
            this.E_button.BackColor = System.Drawing.Color.IndianRed;
            this.E_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.E_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E_button.Location = new System.Drawing.Point(190, 496);
            this.E_button.Name = "E_button";
            this.E_button.Size = new System.Drawing.Size(382, 97);
            this.E_button.TabIndex = 2;
            this.E_button.Text = "ออกจากโปรแกรม";
            this.E_button.UseVisualStyleBackColor = false;
            this.E_button.Click += new System.EventHandler(this.E_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "การจัดการข้อมูล";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 191);
            this.panel2.TabIndex = 4;
            // 
            // Data_collection_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 640);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Data_collection_Form1";
            this.Text = "Data_collection_Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button E_button;
        private System.Windows.Forms.Button S_button;
        private System.Windows.Forms.Button M_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}