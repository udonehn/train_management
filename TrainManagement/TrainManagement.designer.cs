namespace ADOForm
{
    partial class TrainManagement
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editRail = new System.Windows.Forms.Button();
            this.railOpenBtn = new System.Windows.Forms.Button();
            this.arriveStat = new System.Windows.Forms.ComboBox();
            this.delRail = new System.Windows.Forms.Button();
            this.railInfo = new System.Windows.Forms.DataGridView();
            this.addRail = new System.Windows.Forms.Button();
            this.deparStat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.railId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateTrainBtn = new System.Windows.Forms.Button();
            this.trainOpenBtn = new System.Windows.Forms.Button();
            this.delTrain = new System.Windows.Forms.Button();
            this.trainInfo = new System.Windows.Forms.DataGridView();
            this.TAddBtn = new System.Windows.Forms.Button();
            this.trainType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.arrivTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deparTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.railNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trainId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.seatNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.railInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editRail);
            this.groupBox1.Controls.Add(this.railOpenBtn);
            this.groupBox1.Controls.Add(this.arriveStat);
            this.groupBox1.Controls.Add(this.delRail);
            this.groupBox1.Controls.Add(this.railInfo);
            this.groupBox1.Controls.Add(this.addRail);
            this.groupBox1.Controls.Add(this.deparStat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.railId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(558, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "노선 정보";
            // 
            // editRail
            // 
            this.editRail.Location = new System.Drawing.Point(259, 81);
            this.editRail.Name = "editRail";
            this.editRail.Size = new System.Drawing.Size(75, 23);
            this.editRail.TabIndex = 15;
            this.editRail.Text = "노선수정";
            this.editRail.UseVisualStyleBackColor = true;
            this.editRail.Click += new System.EventHandler(this.editRail_Click);
            // 
            // railOpenBtn
            // 
            this.railOpenBtn.Location = new System.Drawing.Point(120, 376);
            this.railOpenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.railOpenBtn.Name = "railOpenBtn";
            this.railOpenBtn.Size = new System.Drawing.Size(110, 25);
            this.railOpenBtn.TabIndex = 14;
            this.railOpenBtn.Text = "노선 조회";
            this.railOpenBtn.UseVisualStyleBackColor = true;
            this.railOpenBtn.Click += new System.EventHandler(this.railOpenBtn_Click);
            // 
            // arriveStat
            // 
            this.arriveStat.FormattingEnabled = true;
            this.arriveStat.Location = new System.Drawing.Point(187, 56);
            this.arriveStat.Name = "arriveStat";
            this.arriveStat.Size = new System.Drawing.Size(81, 20);
            this.arriveStat.TabIndex = 26;
            // 
            // delRail
            // 
            this.delRail.Location = new System.Drawing.Point(259, 377);
            this.delRail.Name = "delRail";
            this.delRail.Size = new System.Drawing.Size(75, 23);
            this.delRail.TabIndex = 25;
            this.delRail.Text = "노선삭제";
            this.delRail.UseVisualStyleBackColor = true;
            this.delRail.Click += new System.EventHandler(this.delRail_Click);
            // 
            // railInfo
            // 
            this.railInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.railInfo.Location = new System.Drawing.Point(6, 111);
            this.railInfo.Name = "railInfo";
            this.railInfo.RowHeadersWidth = 51;
            this.railInfo.RowTemplate.Height = 23;
            this.railInfo.Size = new System.Drawing.Size(328, 258);
            this.railInfo.TabIndex = 0;
            this.railInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.railInfo_CellClick);
            this.railInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.railInfo_CellContentClick);
            // 
            // addRail
            // 
            this.addRail.Location = new System.Drawing.Point(178, 80);
            this.addRail.Name = "addRail";
            this.addRail.Size = new System.Drawing.Size(75, 23);
            this.addRail.TabIndex = 23;
            this.addRail.Text = "노선추가";
            this.addRail.UseVisualStyleBackColor = true;
            this.addRail.Click += new System.EventHandler(this.addRail_Click);
            // 
            // deparStat
            // 
            this.deparStat.FormattingEnabled = true;
            this.deparStat.Location = new System.Drawing.Point(100, 55);
            this.deparStat.Name = "deparStat";
            this.deparStat.Size = new System.Drawing.Size(81, 20);
            this.deparStat.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "도착역";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "출발역";
            // 
            // railId
            // 
            this.railId.Location = new System.Drawing.Point(19, 55);
            this.railId.Name = "railId";
            this.railId.Size = new System.Drawing.Size(75, 21);
            this.railId.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "노선번호";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.seatNum);
            this.groupBox2.Controls.Add(this.updateTrainBtn);
            this.groupBox2.Controls.Add(this.trainOpenBtn);
            this.groupBox2.Controls.Add(this.delTrain);
            this.groupBox2.Controls.Add(this.trainInfo);
            this.groupBox2.Controls.Add(this.TAddBtn);
            this.groupBox2.Controls.Add(this.trainType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.arrivTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.deparTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.railNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trainId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "열차정보";
            // 
            // updateTrainBtn
            // 
            this.updateTrainBtn.Location = new System.Drawing.Point(446, 82);
            this.updateTrainBtn.Name = "updateTrainBtn";
            this.updateTrainBtn.Size = new System.Drawing.Size(75, 23);
            this.updateTrainBtn.TabIndex = 14;
            this.updateTrainBtn.Text = "열차수정";
            this.updateTrainBtn.UseVisualStyleBackColor = true;
            this.updateTrainBtn.Click += new System.EventHandler(this.updateTrainBtn_Click);
            // 
            // trainOpenBtn
            // 
            this.trainOpenBtn.Location = new System.Drawing.Point(158, 377);
            this.trainOpenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trainOpenBtn.Name = "trainOpenBtn";
            this.trainOpenBtn.Size = new System.Drawing.Size(110, 25);
            this.trainOpenBtn.TabIndex = 13;
            this.trainOpenBtn.Text = "열차 조회";
            this.trainOpenBtn.UseVisualStyleBackColor = true;
            this.trainOpenBtn.Click += new System.EventHandler(this.trainOpenBtn_Click);
            // 
            // delTrain
            // 
            this.delTrain.Location = new System.Drawing.Point(446, 375);
            this.delTrain.Name = "delTrain";
            this.delTrain.Size = new System.Drawing.Size(75, 23);
            this.delTrain.TabIndex = 12;
            this.delTrain.Text = "열차삭제";
            this.delTrain.UseVisualStyleBackColor = true;
            this.delTrain.Click += new System.EventHandler(this.delTrain_Click);
            // 
            // trainInfo
            // 
            this.trainInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainInfo.Location = new System.Drawing.Point(6, 111);
            this.trainInfo.Name = "trainInfo";
            this.trainInfo.RowHeadersWidth = 51;
            this.trainInfo.RowTemplate.Height = 23;
            this.trainInfo.Size = new System.Drawing.Size(515, 258);
            this.trainInfo.TabIndex = 0;
            this.trainInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainInfo_CellClick);
            this.trainInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainInfo_CellContentClick);
            // 
            // TAddBtn
            // 
            this.TAddBtn.Location = new System.Drawing.Point(365, 83);
            this.TAddBtn.Name = "TAddBtn";
            this.TAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TAddBtn.TabIndex = 10;
            this.TAddBtn.Text = "열차추가";
            this.TAddBtn.UseVisualStyleBackColor = true;
            this.TAddBtn.Click += new System.EventHandler(this.TAddBtn_Click);
            // 
            // trainType
            // 
            this.trainType.FormattingEnabled = true;
            this.trainType.Items.AddRange(new object[] {
            "KTX",
            "SRT",
            "무궁화"});
            this.trainType.Location = new System.Drawing.Point(93, 56);
            this.trainType.Name = "trainType";
            this.trainType.Size = new System.Drawing.Size(81, 20);
            this.trainType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "도착시간";
            // 
            // arrivTime
            // 
            this.arrivTime.Location = new System.Drawing.Point(342, 56);
            this.arrivTime.Name = "arrivTime";
            this.arrivTime.Size = new System.Drawing.Size(75, 21);
            this.arrivTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "출발시간";
            // 
            // deparTime
            // 
            this.deparTime.Location = new System.Drawing.Point(261, 57);
            this.deparTime.Name = "deparTime";
            this.deparTime.Size = new System.Drawing.Size(75, 21);
            this.deparTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "노선번호";
            // 
            // railNum
            // 
            this.railNum.Location = new System.Drawing.Point(180, 57);
            this.railNum.Name = "railNum";
            this.railNum.Size = new System.Drawing.Size(75, 21);
            this.railNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "열차종류";
            // 
            // trainId
            // 
            this.trainId.Location = new System.Drawing.Point(12, 55);
            this.trainId.Name = "trainId";
            this.trainId.Size = new System.Drawing.Size(75, 21);
            this.trainId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "열차번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "좌석 수";
            // 
            // seatNum
            // 
            this.seatNum.Location = new System.Drawing.Point(423, 57);
            this.seatNum.Name = "seatNum";
            this.seatNum.Size = new System.Drawing.Size(75, 21);
            this.seatNum.TabIndex = 15;
            // 
            // TrainManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrainManagement";
            this.Text = "열차 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.railInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox arriveStat;
        private System.Windows.Forms.Button delRail;
        private System.Windows.Forms.DataGridView railInfo;
        private System.Windows.Forms.Button addRail;
        private System.Windows.Forms.ComboBox deparStat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox railId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delTrain;
        private System.Windows.Forms.DataGridView trainInfo;
        private System.Windows.Forms.Button TAddBtn;
        private System.Windows.Forms.ComboBox trainType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox arrivTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deparTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox railNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trainId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button railOpenBtn;
        private System.Windows.Forms.Button trainOpenBtn;
        private System.Windows.Forms.Button updateTrainBtn;
        private System.Windows.Forms.Button editRail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox seatNum;
    }
}

