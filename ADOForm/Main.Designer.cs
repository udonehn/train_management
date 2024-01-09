namespace ADOForm
{
    partial class Main
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bookbtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 10F);
            this.button2.Location = new System.Drawing.Point(69, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "회원관리";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 10F);
            this.button1.Location = new System.Drawing.Point(69, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "열차관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookbtn
            // 
            this.bookbtn.Font = new System.Drawing.Font("굴림", 10F);
            this.bookbtn.Location = new System.Drawing.Point(69, 162);
            this.bookbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookbtn.Name = "bookbtn";
            this.bookbtn.Size = new System.Drawing.Size(116, 40);
            this.bookbtn.TabIndex = 4;
            this.bookbtn.Text = "예매";
            this.bookbtn.UseVisualStyleBackColor = true;
            this.bookbtn.Click += new System.EventHandler(this.bookbtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.signupBtn.Location = new System.Drawing.Point(69, 224);
            this.signupBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(116, 40);
            this.signupBtn.TabIndex = 5;
            this.signupBtn.Text = "회원가입";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 303);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.bookbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "메인 화면";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bookbtn;
        private System.Windows.Forms.Button signupBtn;
    }
}