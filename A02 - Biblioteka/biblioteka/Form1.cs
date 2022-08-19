using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OAplikaciji form = new OAplikaciji();
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Analiza form = new Analiza();
            form.ShowDialog();
        }

        public void RefreshListView()
        {
            listView1.Items.Clear();
            DataTable dt = Autor.Ucitaj();
            foreach (DataRow red in dt.Rows)
            {
                string[] podaci = new string[5];

                podaci[0] = red[0].ToString();
                podaci[1] = red[1].ToString();
                podaci[2] = red[2].ToString();
                podaci[3] = red[3].ToString();
                podaci[4] = red[4].ToString();

                ListViewItem item = new ListViewItem(podaci);
                listView1.Items.Add(item);
            }
        }

        private void Forma_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string sifra = listView1.SelectedItems[0].Text;
                DataTable dt = Autor.UcitajPolja(sifra);

                txtSifra.Text = dt.Rows[0][0].ToString();
                txtIme.Text = dt.Rows[0][1].ToString();
                txtPrezime.Text = dt.Rows[0][2].ToString();
                masktxtDatRodj.Text = dt.Rows[0][3].ToString();
            }
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            string sifra = txtSifra.Text;
            DataTable dt = Autor.UcitajPolja(sifra);

            try
            {
                if (dt.Rows.Count == 0)
                {
                    txtIme.Text = "";
                    txtPrezime.Text = "";
                    masktxtDatRodj.Text = "";
                }
                else
                {
                    txtIme.Text = dt.Rows[0][1].ToString();
                    txtPrezime.Text = dt.Rows[0][2].ToString();
                    masktxtDatRodj.Text = dt.Rows[0][3].ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text == string.Empty)  return;
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nekog autora iz tabele.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string sifra = txtSifra.Text;

                int.Parse(sifra);
                bool b;
                b = Autor.Obrisi(sifra);
                if (b)
                {
                    MessageBox.Show("Autor uspesno obrisan.", "Obrisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshListView();
                    txtSifra.Text = string.Empty;
                    txtIme.Text = string.Empty;
                    txtPrezime.Text = string.Empty;
                    masktxtDatRodj.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Autor nije obrisan.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIme.Text == string.Empty || txtPrezime.Text == string.Empty || !masktxtDatRodj.MaskCompleted)
                {
                    MessageBox.Show("Niste uneli sve podatke. Molimo unesite sve podatke.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string sifra = txtSifra.Text;
                    string ime = txtIme.Text;
                    string prezime = txtPrezime.Text;
                    DateTime datumrodj = Convert.ToDateTime(masktxtDatRodj.Text);

                    int.Parse(sifra);
                    bool b;
                    b = Autor.Dodaj(sifra ,ime, prezime, datumrodj);
                    if (b)
                    {
                        MessageBox.Show("Autor uspesno dodat.", "Dodato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshListView();
                        txtSifra.Text = string.Empty;
                        txtIme.Text = string.Empty;
                        txtPrezime.Text = string.Empty;
                        masktxtDatRodj.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Autor nije dodat. (Mozda autor sa sifrom koju ste uneli vec postoji?)", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste uneli adekvatan format sifre ili datuma. Molimo unesite ponovo.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
