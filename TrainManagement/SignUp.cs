using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOForm
{
    public partial class SignUp : Form
    {
        DBClass memberDbc = new DBClass("member");

        public SignUp()
        {
            InitializeComponent();
            memberDbc.DB_Open();
            memberDbc.DB_ObjCreate();

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                memberDbc.DS.Clear();
                memberDbc.DBAdapter.Fill(memberDbc.DS, "member");
                memberDbc.table = memberDbc.DS.Tables["member"];
                DataRow newRow = memberDbc.table.NewRow();
                newRow["NAME"] = nameText.Text;
                newRow["MEMBER_ID"] = idText.Text;

                memberDbc.table.Rows.Add(newRow);
                memberDbc.DBAdapter.Update(memberDbc.DS, "member");
                memberDbc.DS.AcceptChanges();
                MessageBox.Show("회원가입 성공");
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
