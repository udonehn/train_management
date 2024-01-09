using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
namespace ADOForm
{
    public partial class TrainManagement : Form
    {
        private int SelectedRowIndex;//???
        DBClass trainDbc = new DBClass("train");
        DBClass routeDbc = new DBClass("route");
        DBClass stationDbc = new DBClass("station");


        public TrainManagement()
        {
            InitializeComponent();
            trainDbc.DB_Open();
            trainDbc.DB_ObjCreate();
            routeDbc.DB_Open();
            routeDbc.DB_ObjCreate();
            stationDbc.DB_Open("station_Name");
            stationDbc.DB_ObjCreate();

        }

        private void trainOpenBtn_Click(object sender, EventArgs e)
        {
            gettrainDB();

        }

        private void railOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                routeDbc.DS.Clear();
                routeDbc.DBAdapter.Fill(routeDbc.DS, "route");
                railInfo.DataSource = routeDbc.DS.Tables["route"].DefaultView;
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

        private void trainInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void railInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                trainDbc.table = trainDbc.DS.Tables["train"];//*
                DataRow newRow = trainDbc.table.NewRow();
                newRow["train_id"] = Convert.ToInt32(trainId.Text);
                newRow["train_type"] = trainType.Text;
                newRow["route_id"] = railNum.Text;
                newRow["departure_time"] = Convert.ToDateTime(deparTime.Text);
                newRow["arrival_time"] = Convert.ToDateTime(arrivTime.Text);
                newRow["seat_count"] = seatNum.Text;
                //2023-11-26 13:00


                trainDbc.table.Rows.Add(newRow);
                trainDbc.DBAdapter.Update(trainDbc.DS, "train");
                trainDbc.DS.AcceptChanges();
                trainInfo.DataSource = trainDbc.DS.Tables["train"].DefaultView;
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

        private void trainInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable trainTable = trainDbc.DS.Tables["train"];

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
                railNum.Text = currRow["route_id"].ToString();
                trainType.Text = currRow["train_type"].ToString();
                trainId.Text = currRow["train_id"].ToString();
                deparTime.Text = currRow["departure_time"].ToString();
                arrivTime.Text = currRow["arrival_time"].ToString();
                seatNum.Text = currRow["seat_count"].ToString();

                trainDbc.SelectedRowIndex = Convert.ToInt32(currRow["train_id"]);
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

        private void delTrain_Click(object sender, EventArgs e)
        {
            try
            {
                trainDbc.table = trainDbc.DS.Tables["train"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = trainDbc.table.Columns["train_id"];
                trainDbc.table.PrimaryKey = PrimaryKey;

                DataRow currRow = trainDbc.table.Rows.Find(trainDbc.SelectedRowIndex);
                currRow.Delete();

                trainDbc.DBAdapter.Update(trainDbc.DS.GetChanges(DataRowState.Deleted), "train");
                trainInfo.DataSource = trainDbc.DS.Tables["train"].DefaultView;
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

        private void railInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable routeTable = routeDbc.DS.Tables["route"];

                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > routeTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }

                DataRow currRow = routeTable.Rows[e.RowIndex];
                railId.Text = currRow["route_id"].ToString();
                deparStat.Text = currRow["departure_station"].ToString();
                arriveStat.Text = currRow["arrival_station"].ToString();

                routeDbc.SelectedRowIndex = Convert.ToInt32(currRow["route_id"]);   //시스템적으로 선택한 행 인식
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

        private void addRail_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(deparStat.Text + arriveStat.Text);
                deparStat.Text.Replace(" ", "");
                routeDbc.table = routeDbc.DS.Tables["route"];//*
                DataRow newRow = routeDbc.table.NewRow();
                newRow["route_id"] = Convert.ToInt32(railId.Text);
                newRow["departure_station"] = deparStat.Text;
                newRow["arrival_station"] = arriveStat.Text;

                routeDbc.table.Rows.Add(newRow);
                routeDbc.DBAdapter.Update(routeDbc.DS, "route");
                routeDbc.DS.AcceptChanges();
                railInfo.DataSource = routeDbc.DS.Tables["route"].DefaultView;
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

        private void delRail_Click(object sender, EventArgs e)
        {
            try
            {
                routeDbc.table = routeDbc.DS.Tables["route"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = routeDbc.table.Columns["route_id"];
                routeDbc.table.PrimaryKey = PrimaryKey;

                DataRow currRow = routeDbc.table.Rows.Find(routeDbc.SelectedRowIndex);
                currRow.Delete();

                routeDbc.DBAdapter.Update(routeDbc.DS.GetChanges(DataRowState.Deleted), "route");
                railInfo.DataSource = routeDbc.DS.Tables["route"].DefaultView;
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
        public List<string> stationList = new List<string>();
        public void getstationName()
        {
            stationDbc.DB_Read("station_Name","station_Name is Not NULL", stationList);
        }

        public int getTrain_Seat_Count(int train_id)
        {
            string infostr = "train_id = " + train_id;
            trainDbc.GetBkInfo(infostr);
            trainDbc.DB_ObjCreate();
            trainDbc.DS.Clear();
            trainDbc.DBAdapter.Fill(trainDbc.DS, "train");
            DataTable trainTable = trainDbc.DS.Tables["train"];
            DataRow curr = trainTable.Rows[0];
            return Convert.ToInt32(curr["seat_count"]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getstationName();
            for (int i = 0; i < stationList.Count; i++)
            {
                deparStat.Items.Add(stationList[i]);
                arriveStat.Items.Add(stationList[i]);
            }
        }

        private void updateTrainBtn_Click(object sender, EventArgs e)
        {
            try
            {
                trainDbc.table = trainDbc.DS.Tables["train"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = trainDbc.table.Columns["train_id"];
                trainDbc.table.PrimaryKey = PrimaryKey;

                DataRow currRow = trainDbc.table.Rows.Find(Convert.ToInt32(trainId.Text));

                if (currRow != null)
                {
                    currRow["train_type"] = trainType.Text;
                    currRow["route_id"] = railNum.Text;
                    currRow["departure_time"] = Convert.ToDateTime(deparTime.Text);
                    currRow["arrival_time"] = Convert.ToDateTime(arrivTime.Text);
                    currRow["seat_count"] = Convert.ToDateTime(seatNum.Text);

                    trainDbc.DBAdapter.Update(trainDbc.DS.GetChanges(DataRowState.Modified), "train");
                    trainDbc.DS.AcceptChanges();
                    trainInfo.DataSource = trainDbc.DS.Tables["train"].DefaultView;
                }
                else
                {
                    MessageBox.Show("열차가 존재하지 않습니다.");
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

        private void editRail_Click(object sender, EventArgs e)
        {
            try
            {
                routeDbc.table = routeDbc.DS.Tables["route"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = routeDbc.table.Columns["route_id"];
                routeDbc.table.PrimaryKey = PrimaryKey;

                DataRow currRow = routeDbc.table.Rows.Find(Convert.ToInt32(railId.Text));

                if (currRow != null)
                {
                    currRow["departure_station"] = deparStat.Text;
                    currRow["arrival_station"] = arriveStat.Text;

                    routeDbc.DBAdapter.Update(routeDbc.DS.GetChanges(DataRowState.Modified), "route");
                    routeDbc.DS.AcceptChanges();
                    railInfo.DataSource = routeDbc.DS.Tables["route"].DefaultView;
                }
                else
                {
                    MessageBox.Show("노선이 존재하지 않습니다.");
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
        private void gettrainDB()
        {
            try
            {
                trainDbc.DS.Clear();
                trainDbc.DBAdapter.Fill(trainDbc.DS, "train");
                trainInfo.DataSource = trainDbc.DS.Tables["train"].DefaultView;
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
