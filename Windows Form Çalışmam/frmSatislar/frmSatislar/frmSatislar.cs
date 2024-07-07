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

    public partial class frmSatislar : Form
    {
        SqlConnection conn;
        int urunId;

        public frmSatislar()
        {
            InitializeComponent();
        }

        private void frmSatislar_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source='EMRULLAH\\SQLEXPRESS';Initial Catalog = 'PIKSEL_PROJE'; User=sa ; Password =1");
            conn.Open();
            txtAlisAdet.Enabled = false;
            txtSatisAdet.Enabled = false;

            /*
            if (conn.State==ConnectionState.Open)
            {
                MessageBox.Show("başarılı");
            }
            */
        }

        private void btnVeriCek_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adpVeriCek = new SqlDataAdapter("SELECT UR.URUNAD,UR.URUNKOD, [SATIŞ MİKTAR]=(SELECT SUM (MIKTAR) FROM FATURADETAY FDET  INNER JOIN FATURAUST FS ON FS.ID=FDET.FATURAID  WHERE FDET.URUNID=UR.ID AND FS.FATURATIP=7), [ALIŞ MİKTAR]=(SELECT SUM (MIKTAR) FROM FATURADETAY FDET  INNER JOIN FATURAUST FS ON FS.ID=FDET.FATURAID  WHERE FDET.URUNID=UR.ID AND FS.FATURATIP=1), [STOK MİKTAR]=(SELECT SUM (MIKTAR) FROM FATURADETAY FDET  INNER JOIN FATURAUST FS ON FS.ID=FDET.FATURAID  WHERE FDET.URUNID=UR.ID AND FS.FATURATIP=1)-(SELECT SUM (MIKTAR) FROM FATURADETAY FDET  INNER JOIN FATURAUST FS ON FS.ID=FDET.FATURAID  WHERE FDET.URUNID=UR.ID AND FS.FATURATIP=7), [ALIŞ TUTAR]=(SELECT SUM (MIKTAR) FROM FATURADETAY FDET  INNER JOIN FATURAUST FS ON FS.ID=FDET.FATURAID  WHERE FDET.URUNID=UR.ID AND FS.FATURATIP=1)*(SELECT  ALISFIYAT FROM FIYATLAR    WHERE ID = FY.ID), [SATIŞ TUTAR]=(SELECT SUM (MIKTAR) FROM FATURADETAY FDET  INNER JOIN FATURAUST FS ON FS.ID=FDET.FATURAID  WHERE FDET.URUNID=UR.ID AND FS.FATURATIP=7)*(SELECT  SATISFIYAT FROM FIYATLAR    WHERE ID = FY.ID),  [STOK TUTAR]=((SELECT SUM (MIKTAR) FROM FATURADETAY FDET  INNER JOIN FATURAUST FS ON FS.ID=FDET.FATURAID  WHERE FDET.URUNID=UR.ID AND FS.FATURATIP=1)-(SELECT SUM (MIKTAR) FROM FATURADETAY FDET  INNER JOIN FATURAUST FS ON FS.ID=FDET.FATURAID  WHERE FDET.URUNID=UR.ID AND FS.FATURATIP=7))*(SELECT  ALISFIYAT FROM FIYATLAR    WHERE ID = FY.ID) FROM FATURADETAY FTD INNER JOIN FATURAUST FT ON FT.ID = FTD.FATURAID INNER JOIN URUNLER UR ON FTD.URUNID = UR.ID INNER JOIN FIYATLAR FY ON FY.ID = UR.FIYATID WHERE FT.TARIH>='2023-10-01' AND FT.TARIH<='2023-10-20' GROUP BY  UR.URUNAD,UR.URUNKOD,UR.ID ,FY.ID ", conn);
            DataTable tblVeriCek = new DataTable();
            adpVeriCek.Fill(tblVeriCek);
            this.dataGridView2.DataSource = tblVeriCek;

        }

        private void spVeriCek_Click(object sender, EventArgs e)
        {
            spVeriCek2();

        }

        private void spVeriCek2()
        {
            SqlCommand cmdSorgu = new SqlCommand();
            cmdSorgu.Connection = conn;
            cmdSorgu.CommandTimeout = 1800000000;
            cmdSorgu.CommandText = "STOK_HAREKET";
            cmdSorgu.Parameters.AddWithValue("@BASTAR", Convert.ToDateTime(dtBaslangic.Text));
            cmdSorgu.Parameters.AddWithValue("@BITTAR", Convert.ToDateTime(dtBitis.Text));
            cmdSorgu.Parameters.AddWithValue("@URUNAD", txtAd.Text);


            cmdSorgu.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpSorgu = new SqlDataAdapter();
            adpSorgu.SelectCommand = cmdSorgu;
            DataTable tblSorgu = new DataTable();
            adpSorgu.Fill(tblSorgu);
            dataGridView2.DataSource = tblSorgu;

            dataGridView2.Columns[0].Visible = false;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            urunId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            txtAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtAlisFiyat.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtSatisFiyat.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtAlisAdet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txtSatisAdet.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdGuncelle = new SqlCommand("UPDATE URUNLER SET URUNAD ='" + txtAd.Text + "'WHERE ID ='" + urunId + "'UPDATE FIYATLAR SET ALISFIYAT= '" + Convert.ToInt32(txtAlisFiyat.Text) + "',SATISFIYAT='" + Convert.ToInt32(txtSatisFiyat.Text) + "' WHERE ID =(SELECT FIYATID FROM URUNLER WHERE ID =" + urunId + ")", conn);

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
            txtAlisAdet.Text = "";
            txtSatisAdet.Text = "";
            spVeriCek2();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Silmek istediğine Emin misin bro", "Uyarı", MessageBoxButtons.YesNo);
            if (sil==DialogResult.Yes)
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
    }
}
