using Oracle.DataAccess.Client; //ADO.Net 개체 참조
using System;
using System.Collections.Generic;
using System.Data; //DataSet 개체 참조
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //MessageBox 개체 참조


namespace ADOForm
{
    public class DBClass // 사용자 클래스 정의
    {
        private int selectedRowIndex;//수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int selectedKeyValue; // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드

        public OracleDataAdapter dBAdapter; //Data Provider인 DBAdapter 입니다.
        public DataSet dS;// DataSet 객체입니다.
        public OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다.
        public DataTable table;// DataTable 객체입니다.
        public String tableName;

        public DBClass(String tableName)
        {
            this.tableName = tableName;
        }

        public int SelectedRowIndex { get { return selectedRowIndex; } set { selectedRowIndex = value; } }

        public int SelectedKeyValue { get { return selectedKeyValue; } set { selectedKeyValue = value; } }

        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }

        public DataSet DS { get { return dS; } set { dS = value; } }

        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }

        public DataTable Table { get { return table; } set { table = value; } }

        public void DB_Open()
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select * from " + tableName;

                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_Open(string selection)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select " + selection + " from " + tableName;

                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_ObjCreate()
        {
            Table = new DataTable();
        }

        public void DB_Read(string selection, string where, List<string> list)
        {

            list.Clear();
            string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
            string queryString = "select " + selection + " from " + tableName + " where " + where;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand(queryString, connection);
                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    // 데이터 읽어와서 리스트에 넣기
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
            }


        }

        public void GetBkInfo(string where)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select * from " + tableName + " where " +where;

                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
    }//DBClass 정의 끝
}
