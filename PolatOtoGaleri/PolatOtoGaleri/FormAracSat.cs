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

namespace PolatOtoGaleri
{
    public partial class FormAracSat : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        OleDbDataAdapter adapter;
        OleDbCommand komut = new OleDbCommand();
        string komutStringi;
        DataTable dt = new DataTable();

        int id;
        public FormAracSat()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.Rows.Count!=0)
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                
                
                DialogResult dialog = MessageBox.Show("seçili aracı satmak istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (dialog == DialogResult.Yes)
                {
                    komut.Connection = con;
                    con.Open();
                    komutStringi = "insert into satilanaraclar(marka,model,yil,kasa_tipi,motor_gucu,motor_hacmi,vites,renk,alim_tarihi,alim_fiyati,hasar_durumu,hasar_fiyati,satis_tarihi,satis_fiyati) values(@marka,@model,@yil,@kasa_tipi,@motor_gucu,@motor_hacmi,@vites,@renk,@alim_tarihi,@alim_fiyati,@hasar_durumu,@hasar_fiyati,@satis_tarihi,@satis_fiyati)";
                    komut.CommandText = komutStringi;
                    komut.Parameters.AddWithValue("@marka", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    komut.Parameters.AddWithValue("@model", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    komut.Parameters.AddWithValue("@yil", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    komut.Parameters.AddWithValue("@kasa_tipi", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    komut.Parameters.AddWithValue("@motor_gucu", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    komut.Parameters.AddWithValue("@motor_hacmi", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    komut.Parameters.AddWithValue("@vites", dataGridView1.CurrentRow.Cells[7].Value.ToString());
                    komut.Parameters.AddWithValue("@renk", dataGridView1.CurrentRow.Cells[8].Value.ToString());
                    komut.Parameters.AddWithValue("@alim_tarihi", dataGridView1.CurrentRow.Cells[9].Value.ToString());
                    komut.Parameters.AddWithValue("@alim_fiyati", Convert.ToUInt32(dataGridView1.CurrentRow.Cells[10].Value.ToString()));
                    komut.Parameters.AddWithValue("@hasar_durumu", dataGridView1.CurrentRow.Cells[11].Value.ToString());
                    komut.Parameters.AddWithValue("@hasar_fiyati", Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value.ToString()));
                    komut.Parameters.AddWithValue("@satis_tarihi", Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")));
                    komut.Parameters.AddWithValue("@satis_fiyati", Convert.ToInt32(textBox1.Text));
                    komut.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    OleDbCommand komut2 = new OleDbCommand("delete * from mevcutaraclar where id=@id", con);
                    komut2.Parameters.AddWithValue("@id", id);
                    komut2.ExecuteNonQuery();
                    con.Close();
                    gridYenile();
                    MessageBox.Show("satış işlemi başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("işlem iptal edildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                //MessageBox.Show("bir hata ile karşılaşıldı");
                MessageBox.Show(ex.Message);

            }
        }

        void satilanAracEkle()
        {
            
  
            komutStringi = "insert into satilanaraclar(marka,model,yil,kasa_tipi,motor_gucu,motor_hacmi,vites,renk,alim_tarihi,alim_fiyati,hasar_durumu,hasar_fiyati,satis_tarihi,satis_fiyati) values(@marka,@model,@yil,@kasa_tipi,@motor_gucu,@motor_hacmi,@vites,@renk,@alim_tarihi,@alim_fiyati,@hasar_durumu,@hasar_fiyati,@satis_tarihi,@satis_fiyati)";
            komut.CommandText = komutStringi;
            komut.Parameters.AddWithValue("@marka", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            komut.Parameters.AddWithValue("@model", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            komut.Parameters.AddWithValue("@yil", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            komut.Parameters.AddWithValue("@kasa_tipi", dataGridView1.CurrentRow.Cells[4].Value.ToString());
            komut.Parameters.AddWithValue("@motor_gucu", dataGridView1.CurrentRow.Cells[5].Value.ToString());
            komut.Parameters.AddWithValue("@motor_hacmi", dataGridView1.CurrentRow.Cells[6].Value.ToString());
            komut.Parameters.AddWithValue("@vites", dataGridView1.CurrentRow.Cells[7].Value.ToString());
            komut.Parameters.AddWithValue("@renk", dataGridView1.CurrentRow.Cells[8].Value.ToString());
            komut.Parameters.AddWithValue("@alim_tarihi", dataGridView1.CurrentRow.Cells[9].Value.ToString());
            komut.Parameters.AddWithValue("@alim_fiyati", Convert.ToUInt32(dataGridView1.CurrentRow.Cells[10].Value.ToString()));
            komut.Parameters.AddWithValue("@hasar_durumu", dataGridView1.CurrentRow.Cells[11].Value.ToString());
            komut.Parameters.AddWithValue("@hasar_fiyati", Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value.ToString()));
            komut.Parameters.AddWithValue("@satis_tarihi", Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")));
            komut.Parameters.AddWithValue("@satis_fiyati", Convert.ToInt32(textBox1.Text));
            komut.ExecuteNonQuery();
            
        }

        void mevcutAraciSil()
        {
            komutStringi = "DELETE * FROM mevcutaraclar WHERE id=@id";
            komut.CommandText = komutStringi;
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            
        }
        void gridYenile()
        {
            try
            {
                dt.Clear();
                komutStringi = "select * from mevcutaraclar";
                adapter = new OleDbDataAdapter(komutStringi, con);
                
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Bir Hata ile karşılaşıldı");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count!=0)
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void FormAracSat_Load(object sender, EventArgs e)
        {
            gridYenile();
        }
    }
}
