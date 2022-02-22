using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole.Principal
{
    public partial class F_Home : Form
    {
        public F_Home()
        {
            InitializeComponent();
        }

        private void F_Home_Load(object sender, EventArgs e)
        {
            DateTime toDay = new DateTime();
            toDay = DateTime.Now;
            int nbrPartici = (from i in Program.autoEcoleDB.Paiements
                              select i).Count();
            int nbrPayment = (from i in Program.autoEcoleDB.Paiements
                              where i.createAt.Value.Month == toDay.Month
                              select i).Count();
            Label_Participant.Text = "" + nbrPartici;
            Label_payment.Text = "" + nbrPayment;
            Lable_thisM.Text = toDay.Month + " / " + toDay.Year;
        }

        private void Btn_participant_Click(object sender, EventArgs e)
        {

        }

        private void Btn_payment_Click(object sender, EventArgs e)
        {

        }


    }
}
