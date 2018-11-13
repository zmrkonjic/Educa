using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatZaSalter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    protected void Ucitavanje_Stranice(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
            Queue<int> queueListic = new Queue<int>();
            Session["TokenQueue"] = queueListic;
            }
        }


        private void btnPrintListic_Click(object sender, EventArgs e)
        {
            Queue<int> listicQueue = (Queue<int>)Session["TokenQueue"];
            lblInfo.Text = "Ispred vas je" + listicQueue.Count.ToString() + "na čekanju";

            if (Session["ZadnjiBrojListica"] == null)
            {
                Session["ZadnjiBrojListica"] = 0;
            }

            int sljedeciBrojListicaIzdan = (int)Session["ZadnjiBrojListica"] + 1;
        }
    }
}
