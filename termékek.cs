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
    public partial class termékek : UserControl
    {
        Butor_rendelesEntities6 context = new Butor_rendelesEntities6();
        public termékek()
        {
            InitializeComponent();
        }

        private void termékek_Load(object sender, EventArgs e)
        {
            termékBindingSource.DataSource = context.Termék.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            termékBindingSource.EndEdit();
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült menteni");

            }
            dataGridView1.Refresh();
        }
    }
}
