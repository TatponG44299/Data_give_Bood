namespace DnBlood
{
    partial class Login_Form1
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
            this.background_panel = new System.Windows.Forms.Panel();
            this.Login_button = new System.Windows.Forms.Button();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.Pass_pictureBox = new System.Windows.Forms.PictureBox();
            this.User_textBox = new System.Windows.Forms.TextBox();
            this.User_pictureBox = new System.Windows.Forms.PictureBox();
            this.background_panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).BeginInit();
            this.background_panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // background_panel
            // 
            this.background_panel.BackColor = System.Drawing.Color.LightCoral;
            this.background_panel.Controls.Add(this.Login_button);
            this.background_panel.Controls.Add(this.Pass_textBox);
            this.background_panel.Controls.Add(this.Pass_pictureBox);
            this.background_panel.Controls.Add(this.User_textBox);
            this.background_panel.Controls.Add(this.User_pictureBox);
            this.background_panel.Controls.Add(this.background_panel2);
            this.background_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background_panel.Location = new System.Drawing.Point(0, 0);
            this.background_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.background_panel.Name = "background_panel";
            this.background_panel.Size = new System.Drawing.Size(800, 523);
            this.background_panel.TabIndex = 0;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Login_button.FlatAppearance.BorderSize = 0;
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_button.Location = new System.Drawing.Point(77, 363);
            this.Login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(640, 75);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Pass_textBox.Location = new System.Drawing.Point(176, 270);
            this.Pass_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.Size = new System.Drawing.Size(540, 46);
            this.Pass_textBox.TabIndex = 4;
            this.Pass_textBox.UseSystemPasswordChar = true;
            this.Pass_textBox.TextChanged += new System.EventHandler(this.Pass_textBox_TextChanged);
            // 
            // Pass_pictureBox
            // 
            this.Pass_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pass_pictureBox.Image = global::DnBlood.Properties.Resources._002_key;
            this.Pass_pictureBox.Location = new System.Drawing.Point(77, 270);
            this.Pass_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pass_pictureBox.Name = "Pass_pictureBox";
            this.Pass_pictureBox.Size = new System.Drawing.Size(71, 70);
            this.Pass_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pass_pictureBox.TabIndex = 3;
            this.Pass_pictureBox.TabStop = false;
            // 
            // User_textBox
            // 
            this.User_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.User_textBox.Location = new System.Drawing.Point(176, 167);
            this.User_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User_textBox.Multiline = true;
            this.User_textBox.Name = "User_textBox";
            this.User_textBox.Size = new System.Drawing.Size(541, 68);
            this.User_textBox.TabIndex = 2;
            // 
            // User_pictureBox
            // 
            this.User_pictureBox.Image = global::DnBlood.Properties.Resources._001_user;
            this.User_pictureBox.Location = new System.Drawing.Point(77, 167);
            this.User_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User_pictureBox.Name = "User_pictureBox";
            this.User_pictureBox.Size = new System.Drawing.Size(71, 70);
            this.User_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_pictureBox.TabIndex = 1;
            this.User_pictureBox.TabStop = false;
            // 
            // background_panel2
            // 
            this.background_panel2.BackColor = System.Drawing.Color.Red;
            this.background_panel2.Controls.Add(this.label1);
            this.background_panel2.Location = new System.Drawing.Point(0, 0);
            this.background_panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.background_panel2.Name = "background_panel2";
            this.background_panel2.Size = new System.Drawing.Size(800, 137);
            this.background_panel2.TabIndex = 0;
            this.background_panel2.TabStop = true;
            this.background_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.background_panel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.background_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login_Form1";
            this.Text = "Login_Form1";
            this.background_panel.ResumeLayout(false);
            this.background_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).EndInit();
            this.background_panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.Panel background_panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pass_pictureBox;
        private System.Windows.Forms.TextBox User_textBox;
        private System.Windows.Forms.PictureBox User_pictureBox;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Button Login_button;
    }
}