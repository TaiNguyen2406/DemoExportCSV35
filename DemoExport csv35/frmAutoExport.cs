using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoExport_csv35
{
    public partial class frmAutoExport : Form
    {
        public frmAutoExport()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //dgv.DataSource = TaoBang();
            //if (dgv.Columns.Count >0)
            //{
            //    dgv.Columns[0].Width = 80;
            //    dgv.Columns[1].Width = 80;
            //    for (int i = 2; i < dgv.ColumnCount - 1; i++)
            //    {
            //        dgv.Columns[i].Width = 40;
            //    }
            //}
          
        }
        //static int seed = Environment.TickCount;
        //static readonly ThreadLocal<Random> random =
        //    new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));
        private DataTable TaoBang()
        {
            DataTable dt = new DataTable();
            string[] tenmay = new string[] { "LL9", "LA9", "MA22", "M22", "SA19" };
            int[] soluong = new int[] { 1, 2, 20, 2, 2 };
            string[] tencot = new string[] { "Reheat voltage", "Reheat current", "Anneal voltage", "Anneal current", "Cooling water temp", "Line speed", "Oil temp of gear box", "Line speed Drawing motor", "Line speed Capstan motor", "Line speed Coiler motor", "Line speed Anneal motor", "Vibration take up", "Length counter", "Capstan Motor current", "Take up Motor current", "Anneal Motor current", "Coiler Motor current", "Drawing motor current" };
            dt.Columns.Add("Date", typeof(String));
            dt.Columns.Add("Time", typeof(String));
            for (int i = 0; i <= tenmay.Length - 1; i++)
            {
                int dem = 1;
                while (dem <= soluong[i])
                {
                    for (int j = 0; j <= tencot.Length - 1; j++)
                    {

                        if (i == 0)
                        {
                            if ((j >= 5 && j <= 9) || j == 12 || j == 13 || j == 16 || j == 17)
                            {
                                dt.Columns.Add(tenmay[i] + "-" + soluong[i] + "-" + tencot[j], typeof(Decimal));
                            }
                        }
                        if (i == 1)
                        {
                            if ((j >= 2 && j <= 10) || j == 12 || j == 15 || j == 16 || j == 17)
                            {
                                dt.Columns.Add(tenmay[i] + "-" + dem + "-" + tencot[j], typeof(Decimal));
                            }
                        }
                        if (i == 2)
                        {
                            if ((j >= 0 && j <= 5) || j == 11 || j == 12 || j == 14 || j == 17)
                            {
                                dt.Columns.Add(tenmay[i] + "-" + dem + "-" + tencot[j], typeof(Decimal));
                            }
                        }
                        if (i == 3)
                        {
                            if (j == 5 || j == 12 || j == 14 || j == 17)
                            {
                                dt.Columns.Add(tenmay[i] + "-" + dem + "-" + tencot[j], typeof(Decimal));
                            }
                        }
                        if (i == 4)
                        {
                            if ((j >= 2 && j <= 5) || j == 12 || j == 14 || j == 17)
                            {
                                dt.Columns.Add(tenmay[i] + "-" + dem + "-" + tencot[j], typeof(Decimal));
                            }
                        }



                    }
                    dem += 1;
                }
            }
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["Date"] = DateTime.Now.ToString("dd/MM/yyyy");
            dt.Rows[0]["Time"] = DateTime.Now.ToString("HH:mm:ss");
            for (int i = 2; i <= dt.Columns.Count - 1; i++)
            {
                Random rnd = new Random();
                if (i <= 5)
                {
                    dt.Rows[0][i] = rnd.Next(1000, 10000);
                }
                else
                {
                    dt.Rows[0][i] = rnd.Next(0, 500);
                }

            }
            //Thread t = new Thread(() =>
            //{
            //    CheckForIllegalCrossThreadCalls = false;
            //    for (int i = 2; i <= dt.Columns.Count - 1; i++)
            //    {
            //        Random rnd = new Random();
            //        if (i <= 5)
            //        {
            //            dt.Rows[0][i] = rnd.Next(1000, 10000);
            //        }
            //        else
            //        {
            //            dt.Rows[0][i] = rnd.Next(0, 500);
            //        }

            //    }
            //    isOk = true;
            //});
            //t.Start();
            //while(isOk !=true)
            //{
            //    return null;
            //}
            return dt;
        }
        public void Export(DataTable dt)
        {

            StringBuilder sb = new StringBuilder();

            string[] columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field =>
                  string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\"")).ToArray();
                sb.AppendLine(string.Join(",", fields));

            }
            //modify
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV|*.csv|All file|*.*";
            save.FilterIndex = 1;
            DateTime hientai = DateTime.Now;
            string strDirLocalt = "./csv/";
            Directory.CreateDirectory(strDirLocalt);
            File.WriteAllText(strDirLocalt + hientai.ToString("dd-MM-yyyy HHmmss") + ".csv", sb.ToString());
            string[] filePaths = Directory.GetFiles(strDirLocalt);
            foreach (string filePath in filePaths)
            {
                string name = new FileInfo(filePath).Name;
                name = name.ToLower();
                string fileTime = name.Split(null)[0];
                string[] fileTime2 = fileTime.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                DateTime tg = new DateTime(Int32.Parse(fileTime2[2]), Int32.Parse(fileTime2[1]), Int32.Parse(fileTime2[0]));
                DateTime thoigian = hientai.AddDays(-30);
                if (tg <= thoigian)
                {
                    File.Delete(filePath);
                }

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dt==null)
            {
                return;
            }
            dt = TaoBang();
           // dgv.DataSource = dt;
            Export(dt);
            timer1.Interval = Convert.ToInt32(txtThoiGian.Text)*1000;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                mnuStop.Text = "Start";
            }
            else
            {
                timer1.Enabled = true;
                mnuStop.Text = "Stop";
            }
        }

    }
}
