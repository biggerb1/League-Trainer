using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_show_CS_Trainer_Click(object sender, EventArgs e)
        {
            Creep_Score_Trainer cs = new Creep_Score_Trainer();
            cs.Show();
        }

        private void Button_show_map_awareness_trainer_Click(object sender, EventArgs e)
        {

        }
    }
}
