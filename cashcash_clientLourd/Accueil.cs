using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashcash_clientLourd
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btnPageTechniciens_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIntervention form2 = new FormIntervention();
            form2.Show();
        }

        private void BtnPageContrat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContrat formContrat = new FormContrat();
            formContrat.Show();
        }

        private void btnPageTechniciens_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormTechnicien formTech = new FormTechnicien();
            formTech.Show();
        }
    }
}
