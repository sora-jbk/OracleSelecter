using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Threading;
using Oracle.ManagedDataAccess.Client;

namespace prepare_oracle
{
    public partial class ControlOracle : Form
    {
        public ControlOracle()
        {
            InitializeComponent();
            OracleStatus.Text = "Unknown";
            getTableName();
        }


        private async void bt_StartOracle_Click(object sender, EventArgs e)
        {
            OracleStatus.Text = "Starting";
            ProcessStartInfo StartOracle = new ProcessStartInfo();
            StartOracle.FileName = "cmd.exe";
            StartOracle.Arguments = "/c ";
            StartOracle.Arguments += "C:/SQL/StartOracle.bat";
            StartOracle.CreateNoWindow = true;
            StartOracle.UseShellExecute = false;
            Process.Start(StartOracle);
            var Started = Process.Start(StartOracle);
            Started.WaitForExit();
            OracleStatus.Text = "Started";

            await Task.Delay(2000);
            ProcessStartInfo StartSqlPlus = new ProcessStartInfo();
            StartSqlPlus.FileName
                = "C:/app/oracle/product/19.3.0/dbhome_1/bin/sqlplus.exe";
            StartSqlPlus.Arguments = " info/pro";
            Process.Start(StartSqlPlus);


        }


        private async void bt_StoptOracle_Click(object sender, EventArgs e)
        {
            OracleStatus.Text = "Stopping";
            ProcessStartInfo StopOracle = new ProcessStartInfo();
            StopOracle.FileName = "C:/SQL/ControlOracle.bat";
            StopOracle.Verb = "RunAs";
            StopOracle.CreateNoWindow = true;
            StopOracle.UseShellExecute = false;
            var Stopped = Process.Start(StopOracle);
            Stopped.WaitForExit();
            OracleStatus.Text = "Stopped";

        }
        private void bt_GetTable_Click(object sender, EventArgs e)
        {
            String SelectSQL = SetSelectSQL();
            PrintTable(SelectSQL, Setcolnums());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public String SetSelectSQL()
        {
            String SelectSQL = "SELECT ";
            int i;
            Console.WriteLine("MSG>>--cheked columns--");
            for (i = 0; i < colname.CheckedItems.Count; i++)
            {
                SelectSQL += colname.CheckedItems[i].ToString();
                if (i < colname.CheckedItems.Count - 1)
                {
                    SelectSQL += ",";
                }
                else
                {
                    SelectSQL += " ";
                }
                Console.WriteLine(colname.CheckedItems[i].ToString());
            }
            Console.WriteLine("----");
            SelectSQL += "FROM " + Table_Name.Text;
            Console.WriteLine("MSG>>--SQL--\n" +
                SelectSQL
                + "\n------------");
            //SelectSQL = "SELECT ENAME FROM EMP";
            return SelectSQL;
        }

        public List<int> Setcolnums()
        {
            List<int> list = new List<int>() { };

            for(int i = 0;i < colname.CheckedItems.Count;i++)
            {
                list.Add(i);
            }

            return list;
        }


        public void PrintTable(String sql, List<int> id)
        {
            sql = sql.ToUpper();
            try
            {
                using (OracleConnection conn = new OracleConnection())
                {
                    conn.ConnectionString =
                        "User ID=info; Password=pro; Data Source=localhost/ORCL";
                    conn.Open();
                    Form2 form2 = new Form2();
                    form2.FTable.ColumnCount = 1;
                    form2.FTable.RowCount = 1;
                    using (OracleCommand cmd = new OracleCommand(sql))
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            ResultText.Text = null;
                            form2.FTable.RowCount = 1;
                            form2.FTable.ColumnCount = id.Count;
                            int j = 0;
                            while (reader.Read())
                            {
                                form2.FTable.Rows.Add();
                                foreach (int i in id)
                                {
                                    if(sql.Contains("TABLE_NAME FROM USER_TAB_COLUMNS"))
                                    {
                                        TNameSelecter.Items.Add(reader[i]);
                                    }
                                    else if (sql.Contains("COLUMN_NAME FROM USER_TAB_COLUMNS"))
                                    {
                                        ResultText.Text += reader[i] + "\t";
                                        colname.Items.Add(reader[i]);
                                    }
                                    else
                                    {
                                        form2.FTable.Rows[j].Cells[i].
                                        Value = reader[i];
                                    }
                                    Console.WriteLine("MSG>>i= "+ i );

                                }
                                j++;
                                ResultText.Text += "\r\n";
                            }
                            if (!sql.Contains("USER_TAB_COLUMNS")){
                                form2.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        public void PrintTable(String sql)
        {
            PrintTable(sql,new List<int> { 0 });
        }

        public void getTableName()
        {
            PrintTable("SELECT DISTINCT TABLE_NAME FROM USER_TAB_COLUMNS", new List<int>{ 0});
        }

        private void GetColName_Click(object sender, EventArgs e)
        {
                            colname.Items.Clear();
            if (TNameSelecter.SelectedIndex != -1)
            {
                PrintTable("SELECT COLUMN_NAME FROM USER_TAB_COLUMNS WHERE TABLE_NAME = '" + Table_Name.Text + "'", new List<int> { 0 });
            }
            else
            {

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TNameSelecter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
