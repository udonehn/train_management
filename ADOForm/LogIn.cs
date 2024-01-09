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
    public partial class LogIn : Form
    {
        string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

        public LogIn()
        {
            InitializeComponent();
        }

        public string userN;
        public string userI;

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            OracleConnection myConnection = new OracleConnection(connectionString);
            try
            {
                myConnection.Open();

                string query = "SELECT COUNT(*) FROM member WHERE member_id = :memberID AND name = :name";
                OracleCommand cmd = new OracleCommand(query, myConnection);
                cmd.Parameters.Add(new OracleParameter("memberID", idText.Text));
                cmd.Parameters.Add(new OracleParameter("name", nameText.Text + "           "));

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("로그인 성공\n예매 페이지로 이동합니다");
                    userN = nameText.Text;
                    userI = idText.Text;
                    TrainManagement trainManagement = new TrainManagement();
                    TicketBooking ticketBooking = new TicketBooking(trainManagement);
                    ticketBooking.Owner = this;
                    ticketBooking.Show();

                }
                else
                {
                    MessageBox.Show("등록되지 않은 회원입니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}
