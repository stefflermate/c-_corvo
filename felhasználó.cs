using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szoftech2_U945X9_Beadandó
{
    public partial class felhasználó : UserControl
    {
        Butor_rendelesEntities6 context = new Butor_rendelesEntities6();
        public felhasználó()
        {
            InitializeComponent();
            fizetésiMódBindingSource.DataSource = context.FizetésiMód.ToList();
        }

        private void felhasználó_Load(object sender, EventArgs e)
        {
            Felhasználófeltöltés();
            Rendeléslistázás();
        }

        private void Rendeléslistázás()
        {
            var vásárló = ((vásárlók)vásárlókBindingSource.Current).VásárlóFK;

            var rendelései = from i in context.Rendelés
                             where i.VásárlóFK == vásárló
                             select i.Rendelés_Dátum;
            listBox1.DataSource = rendelései.ToList();
        }

        private void Felhasználófeltöltés()
        {
            var felhasználók = from i in context.Vásárló
                               select new vásárlók { 
                                    VásárlóFK = i.VásárlóSK,
                                    Név = i.Név,
                                    Cím = i.Cím,
                                    Emailcím = i.Email_cím
                               };
            vásárlókBindingSource.DataSource = felhasználók.ToList();
        }

        //-------------------Vásárló felvétel-----------------//

        private void button1_Click(object sender, EventArgs e)
        {
            Vásárló újvásárló = new Vásárló();
            újvásárló.Név = textBoxnév.Text;
            újvásárló.Cím = textBoxcim.Text;
            újvásárló.Email_cím = textBoxemailcim.Text;

            context.Vásárló.Add(újvásárló);
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült menteni");
            }
            Felhasználófeltöltés();
        }

        //-------------------Vásárló törlés-----------------//

        private void buttontörlés_Click(object sender, EventArgs e)
        {
            var ID = ((vásárlók)vásárlókBindingSource.Current).VásárlóFK;
            
            var törlendővásárló = (from i in context.Vásárló
                                   where i.VásárlóSK == ID
                                   select i).FirstOrDefault();

            context.Vásárló.Remove(törlendővásárló);
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Töröld elöször a rendeléseit a vásárlónak!");
            }
            Felhasználófeltöltés();

        }

        //-------------------Rendelés felvétel-----------------//

        byte RendelésÚjSK = 18;
        private void button2_Click(object sender, EventArgs e)
        {
            var FIZETÉSIFK = (((FizetésiMód)comboBoxFizetés.SelectedItem).Mód).ToString();

            Byte? fizmód = (from i in context.FizetésiMód
                           where i.Mód == FIZETÉSIFK
                           select i.FizetésimódSK).FirstOrDefault();

            Rendelés ÚjR = new Rendelés();
           
            ÚjR.VásárlóFK = ((vásárlók)vásárlókBindingSource.Current).VásárlóFK;
            ÚjR.Rendelés_Dátum = dateTimePicker1.Value;
            ÚjR.FizetésimódFK = fizmód;
            ÚjR.Összeszerelés = bool.Parse(textBoxÖsszeszereéls.Text);
            ÚjR.RendelésSK = RendelésÚjSK;
            RendelésÚjSK++;

            context.Rendelés.Add(ÚjR);
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült menteni");
            }
            Rendeléslistázás();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rendeléslistázás();
        }

        //-------------------Validálás-----------------//

        private void textBoxÖsszeszereéls_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxÖsszeszereéls, "");
        }

        private void textBoxÖsszeszereéls_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^(true|false)$");
            if (!r.IsMatch(textBoxÖsszeszereéls.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxÖsszeszereéls, "Vagy true vagy false");
            }
        }
    }
}
