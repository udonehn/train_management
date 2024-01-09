using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADOForm
{
    public partial class MemberManagement : Form
    {
        private int SelectedRowIndex;//???
        string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
        DBClass trainDbc = new DBClass("train");
        DBClass routeDbc = new DBClass("route");
        DBClass memberDbc = new DBClass("member");
        DBClass paymentDbc = new DBClass("payment");
        DBClass ticketDbc = new DBClass("ticket");
        public MemberManagement()
        {
            InitializeComponent();
            trainDbc.DB_Open();
            trainDbc.DB_ObjCreate();
            routeDbc.DB_Open();
            routeDbc.DB_ObjCreate();
            memberDbc.DB_Open();
            memberDbc.DB_ObjCreate();
            paymentDbc.DB_Open();
            paymentDbc.DB_ObjCreate();
            ticketDbc.DB_Open();
            ticketDbc.DB_ObjCreate();
        }

        private void memberOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                memberDbc.DS.Clear();
                memberDbc.DBAdapter.Fill(memberDbc.DS, "member");
                memberInfo.DataSource = memberDbc.DS.Tables["member"].DefaultView;
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

        private void memberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string memberID;
            try
            {
                DataTable memberTable = memberDbc.DS.Tables["member"];

                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > memberTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }

                DataRow currRow = memberTable.Rows[e.RowIndex];
                memberID = currRow["member_id"].ToString();
                memberDbc.SelectedRowIndex = Convert.ToInt32(currRow["member_id"]);

                load_ticketInfo(memberID);

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

        DataTable ticketDT;
        private void load_ticketInfo(string memberID)
        {
            try
            {
                OracleConnection myConnection = new OracleConnection(connectionString);
                myConnection.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("select member_id, ticket_id, payment_id from ticket where member_id=" + memberID, myConnection);
                ticketDT = new DataTable("ticketInfo");
                oda.Fill(ticketDT);
                myConnection.Close();
                ticketInfo.DataSource = ticketDT;

                ticketInfo.AutoResizeColumns();
                ticketInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ticketInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ticketInfo.AllowUserToAddRows = false;

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

        private void ticketInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ticketID;
            try
            {
                DataTable ticketTable = ticketDT;

                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > ticketTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }

                DataRow currRow = ticketTable.Rows[e.RowIndex];
                ticketID = currRow["ticket_id"].ToString();
                memberDbc.SelectedRowIndex = Convert.ToInt32(currRow["ticket_id"]);
                load_detailInfo(ticketID);

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

        private void load_detailInfo(string ticketID)
        {
            try
            {
                OracleConnection myConnection = new OracleConnection(connectionString);
                string commandString = "select ti.ticket_id, tr.train_id, tr.departure_time, tr.arrival_time from ticket ti, train tr where ti.train_id=tr.train_id and ti.ticket_id=" + ticketID;
                OracleCommand myCommand = new OracleCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;
                OracleDataAdapter DBAdapter = new OracleDataAdapter();
                DBAdapter.SelectCommand = myCommand;
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "RelTable");  // 
                DataTable RelTable = DS.Tables["RelTable"];
                DataRowCollection rows = RelTable.Rows;
                foreach (DataRow dr in rows)
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    for (int i = 1; i < RelTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(dr[i].ToString());
                    }
                    detailInfo.Items.Clear();
                    detailInfo.Items.Add(item);
                }
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
    }
}
