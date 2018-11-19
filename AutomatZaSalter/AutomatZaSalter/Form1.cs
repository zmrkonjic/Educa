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
    public static class Session
    {
        public static int zadnjiBrojListica;
        public static int listicQueue;
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    protected void Ucitavanje_Stranice(int listicQueue)
        {
            if (listicQueue == null)
            {
            Queue<int> queueListic = new Queue<int>();
            listicQueue = queueListic;
            }
        }


        private void btnPrintListic_Click(object sender, EventArgs e, int listicQueue, int zadnjiBrojListica)
        {
            Queue<int> lq = (Queue<int>)listicQueue;
            lblInfo.Text = "Ispred vas je" + lq.Count.ToString() + "na čekanju";

            if (zadnjiBrojListica == null)
            {
                zadnjiBrojListica = 0;
            }

            var sljedeciBrojListicaIzdan = zadnjiBrojListica + 1;
            zadnjiBrojListica = sljedeciBrojListicaIzdan;
            lq.Enqueue(sljedeciBrojListicaIzdan);
        }
            DodajListicuListBox(lq);

            private void DodajListicuListBox(Queue<int> lq)
            {
                listTokens.Items.Clear();
                foreach (int token in lq)
                {
                    listTokens.Items.Add(token.ToString());
                }
            }
        
    }
}
