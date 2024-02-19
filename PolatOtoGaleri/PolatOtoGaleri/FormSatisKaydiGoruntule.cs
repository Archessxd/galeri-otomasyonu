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
    public partial class FormSatisKaydiGoruntule : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        OleDbDataAdapter adapter;
        string komutStringi;
        DataTable dt = new DataTable();

        int id;
        public FormSatisKaydiGoruntule()
        {
            InitializeComponent();
        }

        private void FormSatisKaydiGoruntule_Load(object sender, EventArgs e)
        {
            gridYenile();
        }
        void gridYenile()
        {
            try
            {
                komutStringi = "select * from satilanaraclar";
                adapter = new OleDbDataAdapter(komutStringi, con);
                dt.Clear();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Bir Hata ile karşılaşıldı");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                komutStringi = "delete * from satilanaraclar where id=@id";
                OleDbCommand komut2 = new OleDbCommand(komutStringi,con);
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
                //MessageBox.Show("bir hata ile karşılaşıldı");
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
