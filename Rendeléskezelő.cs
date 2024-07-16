using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szoftech2_U945X9_Beadandó
{
    public partial class Rendeléskezelő : UserControl
    {
        Butor_rendelesEntities6 context = new Butor_rendelesEntities6();
        public Rendeléskezelő()
        {
            InitializeComponent();
        }

        //-------------------Rendelés Kiválasztás-----------------//

        private void Rendeléskezelő_Load(object sender, EventArgs e)
        {
            Névkeresés();
        }

        private void textBoxnévkereső_TextChanged(object sender, EventArgs e)
        {
            Névkeresés();
        }

        private void listBoxnévfelsoroló_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dátumfelsorolás();
        }

        private void Névkeresés()
        {
            var nevek = from i in context.Vásárló
                        where i.Név.Contains(textBoxnévkereső.Text)
                        select i;
            vásárlóBindingSource.DataSource = nevek.ToList();
        }

        private void Dátumfelsorolás()
        {
            if (vásárlóBindingSource.Current == null) return;

            var név = ((Vásárló)vásárlóBindingSource.Current).Név;

            var dátum = from i in context.Rendelés
                        where i.Vásárló.Név == név
                        select i;
            rendelésBindingSource.DataSource = dátum.ToList();
        }

        //-------------------Rendelés törlés-----------------//

        private void buttontörlés_Click(object sender, EventArgs e)
        {
            var rendelésdátum = ((Rendelés)rendelésBindingSource.Current).Rendelés_Dátum;
            var vásárlófk = ((Vásárló)vásárlóBindingSource.Current).VásárlóSK;

            var törlendő = (from i in context.Rendelés
                            where i.Rendelés_Dátum == rendelésdátum && i.VásárlóFK == vásárlófk
                            select i).FirstOrDefault();

            context.Rendelés.Remove(törlendő);
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Elöször törölje az összes ehhez a rendeléshez tartozó terméket!");
            }
            Dátumfelsorolás();
        }

        private void Rendeléskezelő_Enter(object sender, EventArgs e)
        {
            Névkeresés();
        }
    }
}
