using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szoftech2_U945X9_Beadandó
{
    public partial class UserControl1 : UserControl
    {
        Butor_rendelesEntities6 context = new Butor_rendelesEntities6();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Névkeresés();
            comboBoxTermékkategoria.DataSource = context.Kategoria.ToList();
            comboBoxTermékkategoria.DisplayMember = "Kategoria_név";

        }

        //-------------------Rendelés Kiválasztás-----------------//

        private void textBoxnévkereső_TextChanged(object sender, EventArgs e)
        {
            Névkeresés();
        }

        private void Névkeresés()
        {
            var nevek = from i in context.Vásárló
                        where i.Név.Contains(textBoxnévkereső.Text)
                        select i;
            vásárlóBindingSource.DataSource = nevek.ToList();
        }

        private void listBoxnévfelsoroló_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Dátumfelsorolás();

        }

        private void Dátumfelsorolás()
        {
            if (vásárlóBindingSource.Current == null) return;

            var név = (((Vásárló)vásárlóBindingSource.Current).Név).ToString();

            var dátum = from i in context.Rendelés
                        where i.Vásárló.Név == név
                        select i;
            rendelésBindingSource.DataSource = dátum.ToList();
        }

        private void listBoxrendelésdátum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RendeltTerméklistázás();
        }

        private void RendeltTerméklistázás()
        {
            var dátum = (Rendelés)listBoxrendelésdátum.SelectedItem;

            var termék = from i in context.Rendelt_Termék
                         where i.Rendelés.Rendelés_Dátum == dátum.Rendelés_Dátum
                         select new RendeltTermékek
                         {
                             Név = i.Termék.TermékNév,
                             Mennyiség = (int)i.Mennyiség,
                             Ár = (int)i.Termék.Ár,
                             RendelésAzonosító = (int)i.RendelésFK
                         };
            try
            {
                rendeltTermékekBindingSource.DataSource = termék.ToList();
                var ár = (from i in context.Rendelt_Termék
                          where i.Rendelés.Rendelés_Dátum == dátum.Rendelés_Dátum
                          select (i.Termék.Ár) * (i.Mennyiség)).Sum();

                textBoxÁr.Text = ár.ToString();

                var súly = (from i in context.Rendelt_Termék
                            where i.Rendelés.Rendelés_Dátum == dátum.Rendelés_Dátum
                            select (i.Termék.Súly) * (i.Mennyiség)).Sum();

                textBoxSúly.Text = súly.ToString();

                var összeszerelés = (from i in context.Rendelt_Termék
                                     where i.Rendelés.Rendelés_Dátum == dátum.Rendelés_Dátum
                                     select i.Rendelés.Összeszerelés).FirstOrDefault();

                if (összeszerelés == true)
                {
                    textBoxösszeszerelés.Text = "Igen";
                }
                else
                {
                    textBoxösszeszerelés.Text = "Nem";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ehez a vásárlóhoz nincs rendelés");
            }           

        }

        //---------------------Termékek felsorolása-------------------//

        private void comboBoxTermékkategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var kategoria = ((Kategoria)comboBoxTermékkategoria.SelectedItem);

            var termékek = from i in context.Termék
                           where i.KategoriaFK == kategoria.KategoriaSK
                           select i;

            termékBindingSource.DataSource = termékek.ToList();
        }

        //--------------------Termékek fel és levétele------------------//

        private void buttonhozáadás_Click_1(object sender, EventArgs e)
        {
            var hozáadandó = (Termék)listBoxTermékek.SelectedItem;
            var kiválasztottrendelés = (Rendelés)listBoxrendelésdátum.SelectedItem;

            Rendelt_Termék RD = new Rendelt_Termék();

            RD.TermékFK = hozáadandó.TermékSK;
            RD.Mennyiség = Int32.Parse(textBoxújmennyiség.Text);
            RD.RendelésFK = kiválasztottrendelés.RendelésSK;

            context.Rendelt_Termék.Add(RD);
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült menteni");
            }
            RendeltTerméklistázás();
        }

        private void buttonlevétel_Click_1(object sender, EventArgs e)
        {
            var Azonosító = ((RendeltTermékek)rendeltTermékekBindingSource.Current).RendelésAzonosító;
            var Terméknév = ((RendeltTermékek)rendeltTermékekBindingSource.Current).Név;

            var törlendő = (from i in context.Rendelt_Termék
                            where i.RendelésFK == Azonosító && i.Termék.TermékNév == Terméknév
                            select i).FirstOrDefault();

            context.Rendelt_Termék.Remove(törlendő);

            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült menteni");
            }
            RendeltTerméklistázás();

        }

        private void UserControl1_Enter(object sender, EventArgs e)
        {
            Névkeresés();
        }

        //-------------------Validálás-----------------//

        private void textBoxújmennyiség_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxújmennyiség, "");
        }

        private void textBoxújmennyiség_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{1,2}$");
            if (!r.IsMatch(textBoxújmennyiség.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxújmennyiség, "Számnak kell szerepelnie!");
            }
        }       
    }
}
