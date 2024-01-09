
namespace ADOForm
{
    partial class LogIn
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
            this.loginbutton = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(102, 158);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(143, 31);
            this.loginbutton.TabIndex = 31;
            this.loginbutton.Text = "로그인";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(141, 108);
            this.idText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(125, 21);
            this.idText.TabIndex = 30;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(141, 78);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(125, 21);
            this.nameText.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(68, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.Location = new System.Drawing.Point(69, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "이름";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 260);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}