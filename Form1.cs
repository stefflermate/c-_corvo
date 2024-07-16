using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szoftech2_U945X9_Beadandó
{
    public partial class Form1 : Form
    {
        UserControl1 rcu = new UserControl1();
        felhasználó felhasználó = new felhasználó();
        Rendeléskezelő rendkez = new Rendeléskezelő();
        termékek term = new termékek();

        public Form1()
        {
            InitializeComponent();         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(rcu);
            panel1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(felhasználó);
            panel1.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(rendkez);
            panel1.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(term);
            panel1.Dock = DockStyle.Fill;
        }
    }
}
