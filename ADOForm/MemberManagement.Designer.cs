namespace ADOForm
{
    partial class MemberManagement
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
            this.memberInfo = new System.Windows.Forms.DataGridView();
            this.memberOpenBtn = new System.Windows.Forms.Button();
            this.ticketInfo = new System.Windows.Forms.DataGridView();
            this.detailInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.memberInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // memberInfo
            // 
            this.memberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberInfo.Location = new System.Drawing.Point(12, 12);
            this.memberInfo.Name = "memberInfo";
            this.memberInfo.RowHeadersWidth = 51;
            this.memberInfo.RowTemplate.Height = 27;
            this.memberInfo.Size = new System.Drawing.Size(637, 264);
            this.memberInfo.TabIndex = 0;
            this.memberInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberInfo_CellContentClick);
            // 
            // memberOpenBtn
            // 
            this.memberOpenBtn.Location = new System.Drawing.Point(236, 320);
            this.memberOpenBtn.Name = "memberOpenBtn";
            this.memberOpenBtn.Size = new System.Drawing.Size(117, 59);
            this.memberOpenBtn.TabIndex = 1;
            this.memberOpenBtn.Text = "회원 조회";
            this.memberOpenBtn.UseVisualStyleBackColor = true;
            this.memberOpenBtn.Click += new System.EventHandler(this.memberOpenBtn_Click);
            // 
            // ticketInfo
            // 
            this.ticketInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketInfo.Location = new System.Drawing.Point(702, 12);
            this.ticketInfo.Name = "ticketInfo";
            this.ticketInfo.RowHeadersWidth = 51;
            this.ticketInfo.RowTemplate.Height = 27;
            this.ticketInfo.Size = new System.Drawing.Size(470, 264);
            this.ticketInfo.TabIndex = 2;
            this.ticketInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketInfo_CellContentClick);
            // 
            // detailInfo
            // 
            this.detailInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.detailInfo.HideSelection = false;
            this.detailInfo.Location = new System.Drawing.Point(644, 302);
            this.detailInfo.Name = "detailInfo";
            this.detailInfo.Size = new System.Drawing.Size(528, 97);
            this.detailInfo.TabIndex = 4;
            this.detailInfo.UseCompatibleStateImageBehavior = false;
            this.detailInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "승차권번호";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "열차번호";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "출발시각";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "도착시각";
            this.columnHeader4.Width = 83;
            // 
            // MemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.detailInfo);
            this.Controls.Add(this.ticketInfo);
            this.Controls.Add(this.memberOpenBtn);
            this.Controls.Add(this.memberInfo);
            this.Name = "MemberManagement";
            this.Text = "회원 관리";
            ((System.ComponentModel.ISupportInitialize)(this.memberInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView memberInfo;
        private System.Windows.Forms.Button memberOpenBtn;
        private System.Windows.Forms.DataGridView ticketInfo;
        private System.Windows.Forms.ListView detailInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}