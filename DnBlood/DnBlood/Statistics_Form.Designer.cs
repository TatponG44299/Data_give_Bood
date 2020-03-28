namespace DnBlood
{
    partial class Statistics_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.IDP_textBox = new System.Windows.Forms.TextBox();
            this.IDC_textBox = new System.Windows.Forms.TextBox();
            this.IDP_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.C_button = new System.Windows.Forms.Button();
            this.B_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.B_button);
            this.panel1.Controls.Add(this.C_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IDP_label);
            this.panel1.Controls.Add(this.IDC_textBox);
            this.panel1.Controls.Add(this.IDP_textBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 142);
            this.panel2.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(154, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(275, 69);
            this.label.TabIndex = 5;
            this.label.Text = "บันทึกสถิติ";
            // 
            // IDP_textBox
            // 
            this.IDP_textBox.BackColor = System.Drawing.Color.Silver;
            this.IDP_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDP_textBox.Location = new System.Drawing.Point(260, 206);
            this.IDP_textBox.Multiline = true;
            this.IDP_textBox.Name = "IDP_textBox";
            this.IDP_textBox.Size = new System.Drawing.Size(291, 45);
            this.IDP_textBox.TabIndex = 1;
            this.IDP_textBox.TextChanged += new System.EventHandler(this.IDP_textBox_TextChanged);
            // 
            // IDC_textBox
            // 
            this.IDC_textBox.BackColor = System.Drawing.Color.Silver;
            this.IDC_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDC_textBox.Location = new System.Drawing.Point(260, 300);
            this.IDC_textBox.Multiline = true;
            this.IDC_textBox.Name = "IDC_textBox";
            this.IDC_textBox.Size = new System.Drawing.Size(291, 45);
            this.IDC_textBox.TabIndex = 2;
            this.IDC_textBox.TextChanged += new System.EventHandler(this.IDC_textBox_TextChanged);
            // 
            // IDP_label
            // 
            this.IDP_label.AutoSize = true;
            this.IDP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDP_label.Location = new System.Drawing.Point(38, 206);
            this.IDP_label.Name = "IDP_label";
            this.IDP_label.Size = new System.Drawing.Size(183, 32);
            this.IDP_label.TabIndex = 3;
            this.IDP_label.Text = "รหัสโครงการ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(38, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "รหัสผู้บริจาค :";
            // 
            // C_button
            // 
            this.C_button.Location = new System.Drawing.Point(451, 386);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(100, 34);
            this.C_button.TabIndex = 5;
            this.C_button.Text = "ยืนยัน";
            this.C_button.UseVisualStyleBackColor = true;
            this.C_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // B_button
            // 
            this.B_button.Location = new System.Drawing.Point(313, 386);
            this.B_button.Name = "B_button";
            this.B_button.Size = new System.Drawing.Size(100, 34);
            this.B_button.TabIndex = 6;
            this.B_button.Text = "ยกเลิก";
            this.B_button.UseVisualStyleBackColor = true;
            this.B_button.Click += new System.EventHandler(this.B_button_Click);
            // 
            // Statistics_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Statistics_Form";
            this.Text = "Statistics_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox IDP_textBox;
        private System.Windows.Forms.TextBox IDC_textBox;
        private System.Windows.Forms.Label IDP_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button C_button;
        private System.Windows.Forms.Button B_button;
    }
}