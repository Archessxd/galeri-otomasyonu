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
    public partial class Form1 : Form
    {
        FormAracSat aracsat = new FormAracSat();
        FormSatisKaydiGoruntule satiskaydi = new FormSatisKaydiGoruntule();
        FormAracKaydıEkle arackaydi = new FormAracKaydıEkle();

        //db araçları
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        OleDbDataAdapter adapter;
        string komutStringi;
        DataTable dt = new DataTable();

        //degiskenler
        int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //satış kaydı
            satiskaydi.ShowDialog();       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //arac sat
            aracsat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //arac kaydı ekle
            arackaydi.ShowDialog();
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(txtMarka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtMarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            numYil.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            cbKasa.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            numMotorGucu.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            numMotorHacmi.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            cbVites.SelectedItem = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dtAlimTarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtAlimFiyati.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtHasarDurumu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            
            if(txtHasarDurumu.Text == "0")
            {
                txtHasarFiyati.Text = "0";
            }
            else
            {
                txtHasarFiyati.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            }

            txtKm.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }

        void gridYenile()
        {
            try
            {
                komutStringi = "select * from mevcutaraclar";
                adapter = new OleDbDataAdapter(komutStringi,con);
                dt.Clear();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                MessageBox.Show("Bir Hata ile karşılaşıldı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridYenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //(marka, model, yil, kasa_tipi, motor_gucu, motor_hacmi, vites, renk, alim_tarihi, alim_fiyati, hasar_durumu, hasar_fiyati, km)
                
                komutStringi = "update mevcutaraclar set marka=@marka,model=@model,yil=@yil,kasa_tipi=@kasa_tipi,motor_gucu=@motor_gucu,motor_hacmi=@motor_hacmi,vites=@vites,renk=@renk,alim_tarihi=@alim_tarihi,alim_fiyati=@alim_fiyati,hasar_durumu=@hasar_durumu,hasar_fiyati=@hasar_fiyati,km=@km where id=@id";
                OleDbCommand komut2 = new OleDbCommand(komutStringi, con);
                //komut2.Parameters.AddWithValue("@id", id);
                komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut2.Parameters.AddWithValue("@model", txtModel.Text);
                komut2.Parameters.AddWithValue("@yil", numYil.Value.ToString());
                komut2.Parameters.AddWithValue("@kasa_tipi", cbKasa.SelectedItem);
                komut2.Parameters.AddWithValue("@motor_gucu", numMotorGucu.Value.ToString());
                komut2.Parameters.AddWithValue("@motor_hacmi", numMotorHacmi.Value.ToString());
                komut2.Parameters.AddWithValue("@vites", cbVites.SelectedItem);
                komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut2.Parameters.AddWithValue("@alim_tarihi", dtAlimTarihi.Text);
                komut2.Parameters.AddWithValue("@alim_fiyati", Convert.ToUInt32(txtAlimFiyati.Text));
                komut2.Parameters.AddWithValue("@hasar_durumu", txtHasarDurumu.Text);
                komut2.Parameters.AddWithValue("@hasar_fiyati", Convert.ToInt32(txtHasarFiyati.Text));
                komut2.Parameters.AddWithValue("@km", Convert.ToInt32(txtKm.Text));
                komut2.Parameters.AddWithValue("@id", id);
                DialogResult dialog = MessageBox.Show("güncelleme işlemi yapmak istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    komut2.ExecuteNonQuery();
                    con.Close();
                    gridYenile();
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


        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                komutStringi = "delete * from mevcutaraclar where id=@id";
                OleDbCommand komut2 = new OleDbCommand(komutStringi,con);
                komut2.CommandText = komutStringi;
                komut2.Parameters.AddWithValue("@id", id);
                


                DialogResult dialog = MessageBox.Show("silme işlemi yapmak istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    komut2.ExecuteNonQuery();
                    con.Close();
                    gridYenile();
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

        private void button1_Click(object sender, EventArgs e)
        {
            gridYenile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
