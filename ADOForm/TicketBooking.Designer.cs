
namespace ADOForm
{
    partial class TicketBooking
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
            this.name = new System.Windows.Forms.Label();
            this.memid = new System.Windows.Forms.Label();
            this.userBk = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bkTrain = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.depStat = new System.Windows.Forms.ComboBox();
            this.arriStat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.seatInfo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tiketbtn = new System.Windows.Forms.Button();
            this.tiketinfo1 = new System.Windows.Forms.Label();
            this.tiketinfo2 = new System.Windows.Forms.Label();
            this.tiketinfo3 = new System.Windows.Forms.Label();
            this.tiketinfo4 = new System.Windows.Forms.Label();
            this.tiketinfo5 = new System.Windows.Forms.Label();
            this.tiketinfo6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.seatSelectbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bkTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("굴림", 13F);
            this.name.Location = new System.Drawing.Point(33, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 18);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // memid
            // 
            this.memid.AutoSize = true;
            this.memid.Font = new System.Drawing.Font("굴림", 13F);
            this.memid.Location = new System.Drawing.Point(33, 56);
            this.memid.Name = "memid";
            this.memid.Size = new System.Drawing.Size(21, 18);
            this.memid.TabIndex = 3;
            this.memid.Text = "id";
            // 
            // userBk
            // 
            this.userBk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBk.Location = new System.Drawing.Point(36, 122);
            this.userBk.Name = "userBk";
            this.userBk.RowHeadersWidth = 51;
            this.userBk.RowTemplate.Height = 23;
            this.userBk.Size = new System.Drawing.Size(343, 277);
            this.userBk.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(455, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "출발역";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13F);
            this.label6.Location = new System.Drawing.Point(556, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "도착역";
            // 
            // bkTrain
            // 
            this.bkTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bkTrain.Location = new System.Drawing.Point(385, 122);
            this.bkTrain.Name = "bkTrain";
            this.bkTrain.RowHeadersWidth = 51;
            this.bkTrain.RowTemplate.Height = 23;
            this.bkTrain.Size = new System.Drawing.Size(482, 277);
            this.bkTrain.TabIndex = 7;
            this.bkTrain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bkTrain_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depStat
            // 
            this.depStat.FormattingEnabled = true;
            this.depStat.Location = new System.Drawing.Point(458, 80);
            this.depStat.Name = "depStat";
            this.depStat.Size = new System.Drawing.Size(69, 20);
            this.depStat.TabIndex = 9;
            // 
            // arriStat
            // 
            this.arriStat.FormattingEnabled = true;
            this.arriStat.Location = new System.Drawing.Point(559, 80);
            this.arriStat.Name = "arriStat";
            this.arriStat.Size = new System.Drawing.Size(69, 20);
            this.arriStat.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13F);
            this.label7.Location = new System.Drawing.Point(889, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "선택 좌석 정보";
            // 
            // seatInfo
            // 
            this.seatInfo.AutoSize = true;
            this.seatInfo.Font = new System.Drawing.Font("굴림", 13F);
            this.seatInfo.Location = new System.Drawing.Point(889, 281);
            this.seatInfo.Name = "seatInfo";
            this.seatInfo.Size = new System.Drawing.Size(80, 18);
            this.seatInfo.TabIndex = 13;
            this.seatInfo.Text = "좌석선택";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(961, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "예매";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tiketbtn
            // 
            this.tiketbtn.Location = new System.Drawing.Point(150, 405);
            this.tiketbtn.Name = "tiketbtn";
            this.tiketbtn.Size = new System.Drawing.Size(93, 34);
            this.tiketbtn.TabIndex = 15;
            this.tiketbtn.Text = "티켓 조회";
            this.tiketbtn.UseVisualStyleBackColor = true;
            this.tiketbtn.Click += new System.EventHandler(this.tiketbtn_Click);
            // 
            // tiketinfo1
            // 
            this.tiketinfo1.AutoSize = true;
            this.tiketinfo1.Font = new System.Drawing.Font("굴림", 13F);
            this.tiketinfo1.Location = new System.Drawing.Point(889, 94);
            this.tiketinfo1.Name = "tiketinfo1";
            this.tiketinfo1.Size = new System.Drawing.Size(80, 18);
            this.tiketinfo1.TabIndex = 16;
            this.tiketinfo1.Text = "열차번호";
            // 
            // tiketinfo2
            // 
            this.tiketinfo2.AutoSize = true;
            this.tiketinfo2.Font = new System.Drawing.Font("굴림", 13F);
            this.tiketinfo2.Location = new System.Drawing.Point(975, 94);
            this.tiketinfo2.Name = "tiketinfo2";
            this.tiketinfo2.Size = new System.Drawing.Size(80, 18);
            this.tiketinfo2.TabIndex = 17;
            this.tiketinfo2.Text = "열차종류";
            // 
            // tiketinfo3
            // 
            this.tiketinfo3.AutoSize = true;
            this.tiketinfo3.Font = new System.Drawing.Font("굴림", 13F);
            this.tiketinfo3.Location = new System.Drawing.Point(889, 143);
            this.tiketinfo3.Name = "tiketinfo3";
            this.tiketinfo3.Size = new System.Drawing.Size(62, 18);
            this.tiketinfo3.TabIndex = 18;
            this.tiketinfo3.Text = "출발역";
            // 
            // tiketinfo4
            // 
            this.tiketinfo4.AutoSize = true;
            this.tiketinfo4.Font = new System.Drawing.Font("굴림", 13F);
            this.tiketinfo4.Location = new System.Drawing.Point(993, 143);
            this.tiketinfo4.Name = "tiketinfo4";
            this.tiketinfo4.Size = new System.Drawing.Size(62, 18);
            this.tiketinfo4.TabIndex = 19;
            this.tiketinfo4.Text = "도착역";
            // 
            // tiketinfo5
            // 
            this.tiketinfo5.AutoSize = true;
            this.tiketinfo5.Font = new System.Drawing.Font("굴림", 13F);
            this.tiketinfo5.Location = new System.Drawing.Point(889, 188);
            this.tiketinfo5.Name = "tiketinfo5";
            this.tiketinfo5.Size = new System.Drawing.Size(80, 18);
            this.tiketinfo5.TabIndex = 20;
            this.tiketinfo5.Text = "출발시간";
            // 
            // tiketinfo6
            // 
            this.tiketinfo6.AutoSize = true;
            this.tiketinfo6.Font = new System.Drawing.Font("굴림", 13F);
            this.tiketinfo6.Location = new System.Drawing.Point(889, 238);
            this.tiketinfo6.Name = "tiketinfo6";
            this.tiketinfo6.Size = new System.Drawing.Size(80, 18);
            this.tiketinfo6.TabIndex = 21;
            this.tiketinfo6.Text = "도착시간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 13F);
            this.label8.Location = new System.Drawing.Point(958, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "▶";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 13F);
            this.label10.Location = new System.Drawing.Point(968, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "▼";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.paymentLabel.Location = new System.Drawing.Point(889, 321);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(80, 18);
            this.paymentLabel.TabIndex = 27;
            this.paymentLabel.Text = "결제수단";
            // 
            // paymentBtn
            // 
            this.paymentBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.paymentBtn.Location = new System.Drawing.Point(1086, 321);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(75, 23);
            this.paymentBtn.TabIndex = 26;
            this.paymentBtn.Text = "선택";
            this.paymentBtn.UseVisualStyleBackColor = true;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // seatSelectbtn
            // 
            this.seatSelectbtn.Location = new System.Drawing.Point(774, 405);
            this.seatSelectbtn.Name = "seatSelectbtn";
            this.seatSelectbtn.Size = new System.Drawing.Size(93, 34);
            this.seatSelectbtn.TabIndex = 28;
            this.seatSelectbtn.Text = "좌석선택";
            this.seatSelectbtn.UseVisualStyleBackColor = true;
            this.seatSelectbtn.Click += new System.EventHandler(this.seatSelectbtn_Click);
            // 
            // TicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.seatSelectbtn);
            this.Controls.Add(this.paymentBtn);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tiketinfo6);
            this.Controls.Add(this.tiketinfo5);
            this.Controls.Add(this.tiketinfo4);
            this.Controls.Add(this.tiketinfo3);
            this.Controls.Add(this.tiketinfo2);
            this.Controls.Add(this.tiketinfo1);
            this.Controls.Add(this.tiketbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.seatInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arriStat);
            this.Controls.Add(this.depStat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bkTrain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userBk);
            this.Controls.Add(this.memid);
            this.Controls.Add(this.name);
            this.Name = "TicketBooking";
            this.Text = "예매";
            this.Load += new System.EventHandler(this.book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bkTrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label memid;
        private System.Windows.Forms.DataGridView userBk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView bkTrain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox depStat;
        private System.Windows.Forms.ComboBox arriStat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label seatInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tiketbtn;
        private System.Windows.Forms.Label tiketinfo1;
        private System.Windows.Forms.Label tiketinfo2;
        private System.Windows.Forms.Label tiketinfo3;
        private System.Windows.Forms.Label tiketinfo4;
        private System.Windows.Forms.Label tiketinfo5;
        private System.Windows.Forms.Label tiketinfo6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Button seatSelectbtn;
    }
}