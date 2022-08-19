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
    public partial class Analiza : Form
    {
        public Analiza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            cbxAutor.DataSource = Autor.UcitajComboBox();
            cbxAutor.ValueMember = "Sifra";
            cbxAutor.DisplayMember = "PunoIme";
            cbxAutor.SelectedIndex = -1;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (cbxAutor.SelectedIndex !=-1)
            {
                int sifra = (int)cbxAutor.SelectedValue;
                int period = (int)numGod.Value;
                DataTable dt = Statistika.Chart(period, sifra);

                dataGridView1.DataSource = dt;
                chart1.DataSource = dt;

                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chart1.Series[0].XValueMember = "Godina";
                chart1.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chart1.Series[0].YValueMembers = "Broj";
            }
            else
            {
                MessageBox.Show("Izaberite nekog od autora.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
