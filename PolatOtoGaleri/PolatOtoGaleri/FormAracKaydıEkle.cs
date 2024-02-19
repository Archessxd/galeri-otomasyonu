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
    public partial class FormAracKaydıEkle : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        OleDbCommand komut = new OleDbCommand();
        string komutStringi;
        DataTable dt = new DataTable();

        public FormAracKaydıEkle()
        {
            InitializeComponent();
        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                komut.Connection = con;
                komutStringi = "insert into mevcutaraclar(marka,model,yil,kasa_tipi,motor_gucu,motor_hacmi,vites,renk,alim_tarihi,alim_fiyati,hasar_durumu,hasar_fiyati,km) values(@marka,@model,@yil,@kasa_tipi,@motor_gucu,@motor_hacmi,@vites,@renk,@alim_tarihi,@alim_fiyati,@hasar_durumu,@hasar_fiyati,@km)";
                komut.CommandText = komutStringi;
                komut.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut.Parameters.AddWithValue("@model", txtModel.Text);
                komut.Parameters.AddWithValue("@yil", numYil.Value.ToString());
                komut.Parameters.AddWithValue("@kasa_tipi", cbKasa.SelectedItem);
                komut.Parameters.AddWithValue("@motor_gucu", numMotorGucu.Value.ToString());
                komut.Parameters.AddWithValue("@motor_hacmi", numMotorHacmi.Value.ToString());
                komut.Parameters.AddWithValue("@vites", cbVites.SelectedItem);
                komut.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut.Parameters.AddWithValue("@alim_tarihi", dtAlimTarihi.Text);
                komut.Parameters.AddWithValue("@alim_fiyati", Convert.ToUInt32(txtAlimFiyati.Text));
                komut.Parameters.AddWithValue("@hasar_durumu", txtHasarDurumu.Text);
                komut.Parameters.AddWithValue("@hasar_fiyati", Convert.ToInt32(txtHasarFiyati.Text));
                komut.Parameters.AddWithValue("@km", Convert.ToInt32(txtKm.Text));

                DialogResult dialog = MessageBox.Show("yeni arç eklemek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("ekleme işlemi başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("işlem iptal edildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("bir hata ile karşılaşıldı");
                MessageBox.Show(ex.Message);

            }
        }
    }
}
