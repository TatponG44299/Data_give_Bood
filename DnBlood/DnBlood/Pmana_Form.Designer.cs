namespace DnBlood
{
    partial class Pmana_Form
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
            this.Loca_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_button = new System.Windows.Forms.Button();
            this.C_button = new System.Windows.Forms.Button();
            this.MP_textBox = new System.Windows.Forms.TextBox();
            this.MP_label = new System.Windows.Forms.Label();
            this.NP_textBox = new System.Windows.Forms.TextBox();
            this.NP_label = new System.Windows.Forms.Label();
            this.IDP_label = new System.Windows.Forms.Label();
            this.IDP_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Loca_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.B_button);
            this.panel1.Controls.Add(this.C_button);
            this.panel1.Controls.Add(this.MP_textBox);
            this.panel1.Controls.Add(this.MP_label);
            this.panel1.Controls.Add(this.NP_textBox);
            this.panel1.Controls.Add(this.NP_label);
            this.panel1.Controls.Add(this.IDP_label);
            this.panel1.Controls.Add(this.IDP_textBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 588);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Loca_textBox
            // 
            this.Loca_textBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Loca_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Loca_textBox.Location = new System.Drawing.Point(282, 384);
            this.Loca_textBox.Multiline = true;
            this.Loca_textBox.Name = "Loca_textBox";
            this.Loca_textBox.Size = new System.Drawing.Size(293, 36);
            this.Loca_textBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(65, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "สถานที่ :";
            // 
            // B_button
            // 
            this.B_button.Location = new System.Drawing.Point(323, 503);
            this.B_button.Name = "B_button";
            this.B_button.Size = new System.Drawing.Size(107, 38);
            this.B_button.TabIndex = 8;
            this.B_button.Text = "ยกเลิก";
            this.B_button.UseVisualStyleBackColor = true;
            this.B_button.Click += new System.EventHandler(this.B_button_Click);
            // 
            // C_button
            // 
            this.C_button.Location = new System.Drawing.Point(467, 503);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(107, 38);
            this.C_button.TabIndex = 7;
            this.C_button.Text = "ตกลง";
            this.C_button.UseVisualStyleBackColor = true;
            this.C_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // MP_textBox
            // 
            this.MP_textBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MP_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MP_textBox.Location = new System.Drawing.Point(282, 447);
            this.MP_textBox.Multiline = true;
            this.MP_textBox.Name = "MP_textBox";
            this.MP_textBox.Size = new System.Drawing.Size(293, 36);
            this.MP_textBox.TabIndex = 6;
            this.MP_textBox.TextChanged += new System.EventHandler(this.MP_textBox_TextChanged);
            // 
            // MP_label
            // 
            this.MP_label.AutoSize = true;
            this.MP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MP_label.Location = new System.Drawing.Point(65, 447);
            this.MP_label.Name = "MP_label";
            this.MP_label.Size = new System.Drawing.Size(179, 36);
            this.MP_label.TabIndex = 5;
            this.MP_label.Text = "ผู้รับผิดชอบ :";
            this.MP_label.Click += new System.EventHandler(this.MP_label_Click);
            // 
            // NP_textBox
            // 
            this.NP_textBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NP_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.NP_textBox.Location = new System.Drawing.Point(282, 316);
            this.NP_textBox.Multiline = true;
            this.NP_textBox.Name = "NP_textBox";
            this.NP_textBox.Size = new System.Drawing.Size(293, 36);
            this.NP_textBox.TabIndex = 4;
            this.NP_textBox.TextChanged += new System.EventHandler(this.NP_textBox_TextChanged);
            // 
            // NP_label
            // 
            this.NP_label.AutoSize = true;
            this.NP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.NP_label.Location = new System.Drawing.Point(65, 316);
            this.NP_label.Name = "NP_label";
            this.NP_label.Size = new System.Drawing.Size(182, 36);
            this.NP_label.TabIndex = 3;
            this.NP_label.Text = "ชื่อโครงการ :";
            this.NP_label.Click += new System.EventHandler(this.NP_label_Click);
            // 
            // IDP_label
            // 
            this.IDP_label.AutoSize = true;
            this.IDP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDP_label.Location = new System.Drawing.Point(65, 244);
            this.IDP_label.Name = "IDP_label";
            this.IDP_label.Size = new System.Drawing.Size(197, 36);
            this.IDP_label.TabIndex = 2;
            this.IDP_label.Text = "รหัสโครงการ :";
            this.IDP_label.Click += new System.EventHandler(this.IDP_label_Click);
            // 
            // IDP_textBox
            // 
            this.IDP_textBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IDP_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDP_textBox.Location = new System.Drawing.Point(282, 244);
            this.IDP_textBox.Multiline = true;
            this.IDP_textBox.Name = "IDP_textBox";
            this.IDP_textBox.Size = new System.Drawing.Size(293, 36);
            this.IDP_textBox.TabIndex = 1;
            this.IDP_textBox.TextChanged += new System.EventHandler(this.IDP_textBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 126);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "จัดการโครงการ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pmana_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 537);
            this.Controls.Add(this.panel1);
            this.Name = "Pmana_Form";
            this.Text = "Pmana_Form";
            this.Load += new System.EventHandler(this.Pmana_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox IDP_textBox;
        private System.Windows.Forms.Label IDP_label;
        private System.Windows.Forms.Label NP_label;
        private System.Windows.Forms.TextBox NP_textBox;
        private System.Windows.Forms.Label MP_label;
        private System.Windows.Forms.TextBox MP_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_button;
        private System.Windows.Forms.Button C_button;
        private System.Windows.Forms.TextBox Loca_textBox;
        private System.Windows.Forms.Label label2;
    }
}