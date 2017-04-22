using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "Data Source=xe;User ID=FAIZAL;Persist Security Info=True;Password=FAIZAL;";
            OracleCommand cmd = new OracleCommand("SELECT * FROM PEGAWAI", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "PEGAWAI");
            this.dg1.DataSource = ds.Tables["PEGAWAI"];
            con.Close();
        }
    }
}
