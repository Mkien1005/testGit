using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void load_data()
        {
            string db = "Data Source=DESKTOP-F4JUFNO;Initial Catalog=ql_lichthi;Integrated Security=True";
            SqlConnection con = new SqlConnection(db);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Lich_coi_thi where Ca_Thi = '1' or Ca_Thi = '2' AND NgayThi ='2023-11-20'", con);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            grv1.DataSource = dt;
            con.Close();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Lich_coi_thi where Ca_Thi = '3' or Ca_Thi = '4' AND NgayThi ='2023-11-20'", con);
            DataTable dt2 = new DataTable();
            con.Open();
            sqlDataAdapter.Fill(dt2);
            grv2.DataSource = dt2;
            con.Close();
        }
        private void btnDay1_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
