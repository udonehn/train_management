using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ADOForm
{
    public partial class TicketBooking : Form
    {

        new LogIn login;
        public TrainManagement TrainManagement;

        DBClass traininfo = new DBClass("bktrainInfo");
        DBClass ticketinfo = new DBClass("ticketInfo");
        DBClass tiketDbc = new DBClass("ticket");
        DBClass bookseatinfo = new DBClass("seat");
        string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
        int paymentId;

        public TicketBooking( TrainManagement trainManagement)
        {
            InitializeComponent();
            TrainManagement = trainManagement;
            tiketDbc.DB_Open();
            tiketDbc.DB_ObjCreate();
            ticketinfo.DB_Open();
            ticketinfo.DB_ObjCreate();
            bookseatinfo.DB_Open();
            bookseatinfo.DB_ObjCreate();
        }

        private void book_Load(object sender, EventArgs e)
        {
            login = (LogIn)Owner;
            TrainManagement.getstationName();
            for (int i = 0; i < TrainManagement.stationList.Count; i++)
            {
                depStat.Items.Add(TrainManagement.stationList[i]);
                arriStat.Items.Add(TrainManagement.stationList[i]);
            }

            name.Text = login.userN;
            memid.Text = login.userI;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string infostr = "출발역 = '" + depStat.Text + "' and 도착역 = '" + arriStat.Text + "'";
            traininfo.GetBkInfo(infostr);
            traininfo.DB_ObjCreate();
            try
            {
                traininfo.DS.Clear();
                traininfo.DBAdapter.Fill(traininfo.DS, "bktrainInfo");
                bkTrain.DataSource = traininfo.DS.Tables["bktrainInfo"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public int train_id_;
        public string seat_info_;
        private void bkTrain_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataTable trainTable = traininfo.DS.Tables["bktrainInfo"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > trainTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = trainTable.Rows[e.RowIndex];
                train_id_ = Convert.ToInt32(currRow["열차번호"]);
                tiketinfo1.Text = train_id_.ToString();
                tiketinfo2.Text = currRow["열차종류"].ToString();
                tiketinfo3.Text = currRow["출발역"].ToString();
                tiketinfo4.Text = currRow["도착역"].ToString();
                tiketinfo5.Text = currRow["출발시간"].ToString();
                tiketinfo6.Text = currRow["도착시간"].ToString();

            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public string seatNum;
        public string carNum;

        private void seatSelectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SeatSelect seatSelect = new SeatSelect();
                seatSelect.Owner = this;
                seatSelect.ShowDialog();
                seatSelect.Dispose();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }

            seatInfo.Text = seat_info_;
        }
        private void tiketbtn_Click(object sender, EventArgs e)
        {
            getbkInfo();
        }

        private void getbkInfo()
        {
            try
            {
                ticketinfo.DS.Clear();
                ticketinfo.DBAdapter.Fill(ticketinfo.DS, "ticketInfo");
                userBk.DataSource = ticketinfo.DS.Tables["ticketInfo"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        //예매버튼
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tiketDbc.DS.Clear();
                tiketDbc.DBAdapter.Fill(tiketDbc.DS, "ticket");
                tiketDbc.table = tiketDbc.DS.Tables["ticket"];
                DataRow newRow = tiketDbc.table.NewRow();
                newRow["ticket_id"] = Convert.ToInt32(tiketinfo1.Text + carNum + seatNum);
                newRow["train_id"] = Convert.ToInt32(tiketinfo1.Text);
                newRow["payment_id"] = Convert.ToInt32(paymentId);
                newRow["member_id"] = Convert.ToInt32(memid.Text);
                newRow["seatInfo"] = seatInfo.Text;

                tiketDbc.table.Rows.Add(newRow);
                tiketDbc.DBAdapter.Update(tiketDbc.DS, "ticket");
                tiketDbc.DS.AcceptChanges();
                getbkInfo();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            Payment paymentForm = new Payment();
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                paymentId = paymentForm.SelectedPaymentId;

                if (paymentId == 1)
                {
                    paymentLabel.Text = "카드";
                }
                if (paymentId == 2)
                {
                    paymentLabel.Text = "무통장 입금";
                }
                if (paymentId == 3)
                {
                    paymentLabel.Text = "간편결제";
                }
                if (paymentId == 4)
                {
                    paymentLabel.Text = "포인트 결제";
                }
            }
        }
    }
}
