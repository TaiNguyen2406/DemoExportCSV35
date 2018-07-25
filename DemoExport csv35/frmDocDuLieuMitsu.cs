using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslCommunication.Profinet.Melsec;
using HslCommunication;

namespace DemoExport_csv35
{
    public partial class frmDocDuLieuMitsu : Form
    {
        public frmDocDuLieuMitsu()
        {
            InitializeComponent();
        }
        private MelsecMcNet melsec_net = null;

        private void frmDocDuLieuMitsu_Load(object sender, EventArgs e)
        {
            Connect();
        }
        private void Connect()
        {
            // specify plc ip address and port
            melsec_net = new MelsecMcNet(txtIP.Text, Decimal.ToInt32(nudPort.Value ));
            OperateResult connect = melsec_net.ConnectServer();
            if (connect.IsSuccess)
            {
                // success
                lblStatus.Text = "Connected";
            }
            else
            {
                // failed
                lblStatus.Text = "DisConnected";
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<=9999;i++)
            {
                melsec_net = new MelsecMcNet(txtIP.Text, i);
                OperateResult connect = melsec_net.ConnectServer();
                if (connect.IsSuccess)
                {
                    // success
                    lblStatus.Text = "Connected" +i.ToString ();
                }
                else
                {
                    // failed
                    lblStatus.Text = "Offline";
                }
            }
           
        }
    }
}
