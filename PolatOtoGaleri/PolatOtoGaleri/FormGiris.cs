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
    public partial class FormGiris : Form
    {
        Form1 f1 = new Form1();
        FormKayitOl kayit = new FormKayitOl();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();

        public FormGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullaniciMevcutMu(textBox1.Text, textBox2.Text) == true)
            {
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı mevcut değil lütfen kayıt olun.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        bool kullaniciMevcutMu(string uname,string pwd)
        {
            dt.Clear();
            adapter = new OleDbDataAdapter("select * from kullanicilar where uname=@uname and pwd = @pwd",con);
            adapter.SelectCommand.Parameters.AddWithValue("@uname", uname);
            adapter.SelectCommand.Parameters.AddWithValue("@pwd", pwd);
            adapter.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit.ShowDialog();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
