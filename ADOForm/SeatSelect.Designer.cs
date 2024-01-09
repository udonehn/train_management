
namespace ADOForm
{
    partial class SeatSelect
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
            this.carrNum = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.seatlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seatInfo = new System.Windows.Forms.Label();
            this.seatSbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carrNum
            // 
            this.carrNum.AutoSize = true;
            this.carrNum.Font = new System.Drawing.Font("굴림", 13F);
            this.carrNum.Location = new System.Drawing.Point(118, 467);
            this.carrNum.Name = "carrNum";
            this.carrNum.Size = new System.Drawing.Size(44, 18);
            this.carrNum.TabIndex = 24;
            this.carrNum.Text = "호차";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 12F);
            this.button4.Location = new System.Drawing.Point(198, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "▶";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 12F);
            this.button3.Location = new System.Drawing.Point(10, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "◀";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // seatlist
            // 
            this.seatlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.seatlist.HideSelection = false;
            this.seatlist.Location = new System.Drawing.Point(12, 12);
            this.seatlist.Name = "seatlist";
            this.seatlist.Size = new System.Drawing.Size(264, 449);
            this.seatlist.TabIndex = 0;
            this.seatlist.UseCompatibleStateImageBehavior = false;
            this.seatlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "좌";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "석";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "선";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "택";
            this.columnHeader4.Width = 65;
            // 
            // seatInfo
            // 
            this.seatInfo.AutoSize = true;
            this.seatInfo.Font = new System.Drawing.Font("굴림", 13F);
            this.seatInfo.Location = new System.Drawing.Point(12, 519);
            this.seatInfo.Name = "seatInfo";
            this.seatInfo.Size = new System.Drawing.Size(86, 18);
            this.seatInfo.TabIndex = 26;
            this.seatInfo.Text = "좌석 정보";
            // 
            // seatSbtn
            // 
            this.seatSbtn.Location = new System.Drawing.Point(164, 513);
            this.seatSbtn.Name = "seatSbtn";
            this.seatSbtn.Size = new System.Drawing.Size(109, 34);
            this.seatSbtn.TabIndex = 27;
            this.seatSbtn.Text = "좌석선택";
            this.seatSbtn.UseVisualStyleBackColor = true;
            this.seatSbtn.Click += new System.EventHandler(this.seatSbtn_Click);
            // 
            // SeatSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 564);
            this.Controls.Add(this.seatSbtn);
            this.Controls.Add(this.seatInfo);
            this.Controls.Add(this.carrNum);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.seatlist);
            this.Controls.Add(this.button3);
            this.Name = "SeatSelect";
            this.Text = "SeatSelect";
            this.Load += new System.EventHandler(this.SeatSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label carrNum;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView seatlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label seatInfo;
        private System.Windows.Forms.Button seatSbtn;
    }
}