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
    public partial class OAplikaciji : Form
    {
        public OAplikaciji()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void OAplikaciji_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;

            if (node == treeView1.Nodes[0].Nodes[0])
            {
                richTextBox1.Text = "Na glavnoj formi se nalaze 4 dugmeta: Brisanje, Analiza, O Aplikaciji i Izlaz." +
                                    "\n\nKlikom na dugme 'Brisanje' se brise izabrani autor iz tabele. " +
                                    "\n\nKlikom na dugme 'Dodavanje' se dodaje novi upisan autor u tabelu. " +
                                    "\n\nKlikom na dugme 'Analiza' otvara se nova forma na kojoj se vrsi analiza. " +
                                    "\n\nKlikom na dugme 'O aplikaciji' otvara se nova forma koja sadrzi sve informacije vezane za aplikaciju. " +
                                    "\n\nKlikom na dugme 'Izlaz' se izlazi iz aplikacije." +
                                    "\n\nDa bi ste ucitali autora u polja, kliknite bilo koji red u tabeli.";
            }
            if (node == treeView1.Nodes[0].Nodes[1])
            {
                richTextBox1.Text = "Na formi 'Analiza' se prikazuje koliko su puta dela odabranog autora bila iznajmljena tokom zadatog vremenskog perioda." +
                                    "\n\nVremenski period se zadaje u odnosu na tekuci datum, kao i izabrani broj godina (u kontroli NumericUpDown) unazad." +
                                    "\n\nTabela i grafik se prikazuju klikom na dugme 'Prikazi'.";
            }
            if (node == treeView1.Nodes[0].Nodes[2])
            {
                richTextBox1.Text = "Na formi 'O aplikaciji' se prikazuju sve informacije o aplikaciji kao sto su: O autoru, Uputstvo i Test primeri.";
            }
            if (node == treeView1.Nodes[1].Nodes[0])
            {
                richTextBox1.Text = "Ako se klikne dugme za brisanje a prethodno se ne selektuje neki autor iz tabele, program ce izbaciti obavestenje.";
            }
            if (node == treeView1.Nodes[1].Nodes[1])
            {
                richTextBox1.Text = "Ako se u formi 'Analiza' klikne dugme za prikazivanje u tabeli i pravljenje grafika a prethodno se ne selektuje neki autor iz comboBox-a, program ce izbaciti obavestenje.";
            }
            if (node == treeView1.Nodes[2])
            {
                richTextBox1.Text = "Ime i prezime: Teodora Kanjevac" +
                                    "\nOdeljenje: IV-4" +
                                    "\nSmer: Informacione tehnologije" +
                                    "\nSkola: ETŠ Nikola Tesla" +
                                    "\nGrad: Niš";
            }
        }
    }
}
