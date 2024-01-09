namespace ADOForm
{
    partial class SignUp
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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Font = new System.Drawing.Font("굴림", 13F);
            this.signUpBtn.Location = new System.Drawing.Point(111, 173);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(180, 52);
            this.signUpBtn.TabIndex = 0;
            this.signUpBtn.Text = "회원가입";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(178, 107);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(142, 25);
            this.idText.TabIndex = 30;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(178, 69);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(142, 25);
            this.nameText.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(75, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.Location = new System.Drawing.Point(76, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "이름";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 287);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUpBtn);
            this.Name = "SignUp";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}