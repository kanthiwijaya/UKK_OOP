using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BetaMart
{
    public partial class Form1 : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Mapel Kelas 12\UKK\KK3\Database1.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "select count (*) from DataLogin where Username='" + txt_username.Text + "'and Password='" + txt_password.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(perintah, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Username and password is correct");
                koneksi.Close();
                koneksi.Dispose();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect try again..");
            }
        }
    }
}
