using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOForm
{
    public partial class SeatSelect : Form
    {
        new TicketBooking Parent;

        DBClass tiketDbc = new DBClass("ticket");
        public SeatSelect()
        {
            InitializeComponent();
            tiketDbc.DB_Open();
            tiketDbc.DB_ObjCreate();
        }

        List<string> seatList = new List<string>();
        public void seatSet(int seatrange)
        {
            Parent = (TicketBooking)Owner;
            carrNum.Text = carriNum.ToString()+"호차";
            seatlist.Groups.Clear();
            seatlist.Items.Clear();

            ControlDispose();
            int seat_count = seatrange / 4;

            int num;
            SetHeight(seatlist, 40); //리스트 행 세로높이 조정
            tiketDbc.DB_Read("seatInfo", "train_id = "+Parent.train_id_ , seatList);
            for (int i = 0; i < seat_count + 1; i++)
            {
                ListViewItem lvi = new ListViewItem();
                seatlist.Items.Add(lvi);
                if (i < seat_count + 1) num = 4;
                else num = seatrange % 4;

                for (int j = 0; j < num; j++)
                {
                    seatrange_(lvi, i, j);
                }
            }
        }

        List<Control> ItControl = new List<Control>();

        void ControlDispose()
        {
            for (int iCoun = 0; iCoun < ItControl.Count; iCoun++)
            {
                ItControl[iCoun].Dispose();
            }
            if (ItControl.Count > 0)
            {
                ItControl.Clear();
            }
        }


        private void SetHeight(ListView LV, int height)
        {      // listView 높이 지정     
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            LV.SmallImageList = imgList;
        }

        private void seatrange_(ListViewItem lvi, int i, int j)
        {
            Parent = (TicketBooking)Owner;
            lvi.SubItems.Add(i.ToString());
            Button seatbtn = new Button();
            seatbtn.Text = ((j + 1) + (i * 4)).ToString();
            if (seatList.Count <= 0)
            {
                seatbtn.Click += new EventHandler(bt_click);
            }
            else
            {
                string str = carrNum.Text + seatbtn.Text + "번 좌석";
                foreach (string list in seatList)  //어째서인지 list.Contains(string)이 작동하지않아 차선책으로..
                {
                    if (list.Contains(str))//.Contains(str))
                    {//2호차27번 좌석
                        seatbtn.Enabled = false;
                        seatbtn.BackColor = Color.FromArgb(219, 68, 85);
                    }
                    else
                        seatbtn.Click += new EventHandler(bt_click);
                }
            }
                    
            seatbtn.Parent = seatlist;

            ListViewItem.ListViewSubItem ps = null;

            ps = seatlist.Items[i].SubItems[j];
            Rectangle rt = new Rectangle();
            rt = ps.Bounds;
            seatbtn.SetBounds(rt.X, rt.Y, 40, 40);

                ItControl.Add(seatbtn);
        }

        void bt_click(object s, EventArgs e)
        {
            Parent = (TicketBooking)Owner;
            Button bt = s as Button;
            seatInfo.Text = carrNum.Text + bt.Text + "번 좌석";
            Parent.seat_info_ = seatInfo.Text;
            Parent.seatNum = bt.Text;
            Parent.carNum = carriNum.ToString();
        }

        private void seatSbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int seatC;
        private void SeatSelect_Load(object sender, EventArgs e)
        {
            Parent = (TicketBooking)Owner;
            seatC = Parent.TrainManagement.getTrain_Seat_Count(Parent.train_id_);
            seatSet(seatC); //이후 열차정보에 좌석수 추가하든가 등등으로 바꾸던가 고정으로 가던가 하기

            
        }

        int carriNum = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            if (carriNum > 1)
            {
                carriNum -= 1;
                seatSet(seatC);
            }
            else
                MessageBox.Show("첫번째 차량입니다.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (carriNum < 6)
            {
                carriNum += 1;
                seatSet(seatC);
            }
            else
                MessageBox.Show("마지막 차량입니다.");
        }
    }
}

