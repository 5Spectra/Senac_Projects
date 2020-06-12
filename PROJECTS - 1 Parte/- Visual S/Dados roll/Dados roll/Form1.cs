using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados_roll
{
    public partial class Form1 : Form
    {
        //dados e seus nº | 1 D20 | 2 D16 | 3 D12 | 4 D10 | 5 D8 | 6 D6 | 7 D4 | 8 D2 |
        public int dado, botton_clicked;

        public Form1()
        {
            InitializeComponent();
        }

        private void T_TextChanged(object sender, EventArgs e)
        {
            Num.Text = T.Text;
            conta.Text = T.Text;
        }

        private void dado20_Click(object sender, EventArgs e)
        {

            //dado = V20.Value;
            botton_clicked = 1;
        }

        //conta xxx + xx + xx
        /*for (int i = 0; vezes > ){
        
        }*/
        private void values_to_vetor()
        {
            //dado = V20.Value;

        }
        private void fazendo_vezes() {
           // for (int i = 1; 1 < V20; ) { }
        }

        private void convert_updown() {
            // NOME antigo mais C no final (convertido)
            int V20C = (int)V20.Value;
            int V16C = (int)V16.Value;
            int V12C = (int)V12.Value;
            int V10C = (int)V10.Value;
            int V8C = (int)V8.Value;
            int V6C = (int)V6.Value;
            int V4C = (int)V4.Value;
            int V2C = (int)V2.Value;

            int M20C = (int)M20.Value;
            int M16C = (int)M16.Value;
            int M12C = (int)M12.Value;
            int M10C = (int)M10.Value;
            int M8C = (int)M8.Value;
            int M6C = (int)M6.Value;
            int M4C = (int)M4.Value;
            int M2C = (int)M2.Value;

            int O20C = (int)O20.Value;
            int O16C = (int)O16.Value;
            int O12C = (int)O12.Value;
            int O10C = (int)O10.Value;
            int O8C = (int)O8.Value;
            int O6C = (int)O6.Value;
            int O4C = (int)O4.Value;
            int O2C = (int)O2.Value;

        }

    }
}
