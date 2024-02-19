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
    public partial class FormKayitOl : Form
    {
        OleDbDataAdapter adapter;
        OleDbCommand komut;
        DataTable dt = new DataTable();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");

        public FormKayitOl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kullaniciMevcutMu(textBox1.Text, textBox2.Text) == false)
                {
                    con.Open();
                    komut = new OleDbCommand("insert into kullanicilar(uname,pwd) values(@uname,@pwd)",con);
                    komut.Parameters.AddWithValue("@uname", textBox1.Text);
                    komut.Parameters.AddWithValue("@pwd", textBox2.Text);
                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("kayıt işlemi başarılı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("kullanıcı mevcut lütfen giris yapın.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
        }

        bool kullaniciMevcutMu(string uname, string pwd)
        {
            dt.Clear();
            adapter = new OleDbDataAdapter("select * from kullanicilar where uname=@uname and pwd = @pwd", con);
            adapter.SelectCommand.Parameters.AddWithValue("@uname", uname);
            adapter.SelectCommand.Parameters.AddWithValue("@pwd", pwd);
            adapter.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;

        }
    }
}
