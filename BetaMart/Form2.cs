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
    public partial class Form2 : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Mapel Kelas 12\UKK\KK3\Database1.accdb");

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                koneksi.Open();
                string perintah = "Insert into DataBarang (Nama, Kode_Barang, Harga, Stok, Tanggal_Ditambahkan) values ('" + txt_nama.Text + "', '" + txt_kode_barang.Text + "', '" + txt_harga.Text + "', '" + txt_stok.Text + "', '" + txt_tanggal.Text + "')";
                OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Tersimpan");
                panelData.Enabled = true;
                txt_id.Clear();
                txt_nama.Clear();
                txt_stok.Clear();
                txt_harga.Clear();
                txt_kode_barang.Clear();
            }
            else
            {
                MessageBox.Show("ID tidak perlu di isi!");
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Tolong isi Data Barang dan ID Barang yang akan di edit!");
            }
            else
            {
                koneksi.Open();
                OleDbCommand cmd = koneksi.CreateCommand();
                string query = "update DataBarang set Nama='" + txt_nama.Text + "' , Stok='" + txt_stok.Text + "' , Harga='" + txt_harga.Text + "' , Kode_Barang='" + txt_kode_barang.Text + "',Tanggal_Ditambahkan='" + txt_tanggal.Text + "' where ID=" + txt_id.Text + "";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Barang berhasil diedit");
                panelData.Enabled = true;
                txt_id.Clear();
                txt_nama.Clear();
                txt_stok.Clear();
                txt_harga.Clear();
                txt_kode_barang.Clear();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.DataBarang' table. You can move, or remove it, as needed.
            ShowData();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "select * from DataBarang where Nama='" + txt_search.Text + "' or Kode_Barang='" + txt_search.Text + "' or Harga='" + txt_search.Text + "' or Stok='" + txt_search.Text + "' or Tanggal_Ditambahkan='" + txt_search.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(perintah, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        void ShowData()
        {
            koneksi.Open();
            string query = "select * from DataBarang";
            OleDbDataAdapter da = new OleDbDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Tolong isi ID bila ingin menghapus!");
            }
            else
            {
                koneksi.Open();
                string perintah = "Delete from DataBarang where ID=" + txt_id.Text;
                OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("data terhapus");
                panelData.Enabled = true;
                txt_id.Clear();
            }
            
        }

        private void panelData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
