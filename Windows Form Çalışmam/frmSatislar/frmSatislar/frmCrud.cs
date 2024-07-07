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

namespace frmSatislar
{
    public partial class frmCrud : Form
    {
        SqlConnection conn;
        int urunId;

        public frmCrud()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmdFiyatEkle = new SqlCommand("INSERT INTO FIYATLAR (ALISFIYAT,SATISFIYAT) VALUES (@ALISFIYAT,@SATISFIYAT)", conn);

            cmdFiyatEkle.Parameters.AddWithValue("@ALISFIYAT", Convert.ToDouble(txtAlisFiyat.Text));
            cmdFiyatEkle.Parameters.AddWithValue("@SATISFIYAT", Convert.ToDouble(txtSatisFiyat.Text));

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmdFiyatEkle.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            SqlDataAdapter adpId = new SqlDataAdapter("SELECT MAX (ID) FROM FIYATLAR", conn);
            DataTable tblFiyatId = new DataTable();
            adpId.Fill(tblFiyatId);

            SqlDataAdapter adpBirimId = new SqlDataAdapter("SELECT ID FROM BIRIMLER WHERE BIRIM ='" + cmbBirim.Text + "'", conn);
            DataTable tblBirimId = new DataTable();
            adpBirimId.Fill(tblBirimId);

            SqlCommand cmdUrunEkle = new SqlCommand("INSERT INTO URUNLER (URUNKOD,URUNAD,BIRIMID,FIYATID) VALUES (@URUNKOD,@URUNAD,@BIRIMID,@FIYATID)", conn);
            cmdUrunEkle.Parameters.AddWithValue("@URUNKOD", txtUrunKod.Text);
            cmdUrunEkle.Parameters.AddWithValue("@URUNAD", txtAd.Text);
            cmdUrunEkle.Parameters.AddWithValue("@BIRIMID", tblBirimId.Rows[0][0]);
            cmdUrunEkle.Parameters.AddWithValue("@FIYATID", tblFiyatId.Rows[0][0]);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmdUrunEkle.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            spVeriCek2();
        }

        private void spVeriCek2()
        {
            SqlCommand cmdSorgu = new SqlCommand();
            cmdSorgu.Connection = conn; 
            cmdSorgu.CommandTimeout = 1800000000;
            cmdSorgu.CommandText = "URUN_CEK";

            cmdSorgu.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpSorgu = new SqlDataAdapter();
            adpSorgu.SelectCommand = cmdSorgu;
            DataTable tblSorgu = new DataTable();
            adpSorgu.Fill(tblSorgu);
            dataGridView2.DataSource = tblSorgu;

            dataGridView2.Columns[0].Visible = false;

        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source='EMRULLAH\\SQLEXPRESS';Initial Catalog = 'PIKSEL_PROJE'; User=sa ; Password =1");
            SqlDataAdapter adpBirim = new SqlDataAdapter("SELECT BIRIM FROM BIRIMLER", conn);
            DataTable tblBirim = new DataTable();
            adpBirim.Fill(tblBirim);

            for (int i = 0; i < tblBirim.Rows.Count; i++)
            {
                cmbBirim.Items.Add(tblBirim.Rows[i][0].ToString());
            }
            cmbBirim.SelectedIndex = 0;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            spVeriCek2();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Silmek istediğine Emin misin bro", "Uyarı", MessageBoxButtons.YesNo);
            if (sil == DialogResult.Yes)
            {
                SqlCommand cmdSil = new SqlCommand("DELETE FROM URUNLER WHERE ID='" + dataGridView2.CurrentRow.Cells[0].Value + "'", conn);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmdSil.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Ürünü Sildin Rahatladın mı");
                spVeriCek2();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            /*
            SqlCommand cmdGuncelle = new SqlCommand("UPDATE URUNLER SET URUNAD ='" + txtAd.Text + "',URUNKOD ='" + txtUrunKod.Text + "'WHERE ID ='" + urunId + "'UPDATE FIYATLAR SET ALISFIYAT= '" + Convert.ToInt32(txtAlisFiyat.Text) + "',SATISFIYAT='" + Convert.ToInt32(txtSatisFiyat.Text) + "' WHERE ID =(SELECT FIYATID FROM URUNLER WHERE ID =" + urunId + ")", conn);
            */

            SqlCommand cmdGuncelle = new SqlCommand("UPDATE URUNLER SET URUNAD =@URUNAD,URUNKOD=@URUNKOD,BIRIMID=@BIRIMID WHERE ID='" + dataGridView2.CurrentRow.Cells[0].Value + "'", conn);
            cmdGuncelle.Parameters.AddWithValue("@URUNAD", txtAd.Text);
            cmdGuncelle.Parameters.AddWithValue("@URUNKOD", txtUrunKod.Text);
            cmdGuncelle.Parameters.AddWithValue("@BIRIMID", Birim(cmbBirim.Text));

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmdGuncelle.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            MessageBox.Show("GÜNCELLEME YAPILDI");

            txtAd.Text = "";
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            txtUrunKod.Text = "";

            spVeriCek2();
        }

        private string Birim(string birimAdi)
        {
            SqlDataAdapter adpBirimId = new SqlDataAdapter("SELECT ID FROM BIRIMLER WHERE BIRIM'" + birimAdi + "'", conn);
            DataTable tblBirimId = new DataTable();
            adpBirimId.Fill(tblBirimId);

            return tblBirimId.Rows[0][0].ToString();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            urunId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            txtUrunKod.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            cmbBirim.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtSatisFiyat.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtAlisFiyat.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                SqlCommand cmdGuncelle = new SqlCommand("UPDATE URUNLER SET URUNAD ='" + dataGridView2.Rows[i].Cells[1].Value + "',URUNKOD ='" + dataGridView2.Rows[i].Cells[2].Value + "'WHERE ID ='" + dataGridView2.Rows[i].Cells[0].Value + "'UPDATE FIYATLAR SET ALISFIYAT= '" + Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value) + "',SATISFIYAT='" + Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value) + "' WHERE ID =(SELECT FIYATID FROM URUNLER WHERE ID =" + dataGridView2.Rows[i].Cells[0].Value + ")", conn);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmdGuncelle.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            spVeriCek2();
        }

        private void frmCrud_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
