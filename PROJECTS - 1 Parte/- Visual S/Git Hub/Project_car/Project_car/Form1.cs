using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUno(object sender, EventArgs e)
        {
            K carro1 = new K();

            //setando as variasveis
            carro1.modelo = "uno";
            carro1.ano_fabricacao = 2005;
            carro1.cor = "azul";
            carro1.marca = "exa";
            carro1.motorizacao = "1.8";
            carro1.velocidade_max = 120;
            carro1.quantidade_marchas = 6;

            // colocar no ficha
            lblModelo.Text = carro1.modelo;
            lblAnoFabricacao.Text = carro1.ano_fabricacao.ToString(); //ou poderia usar o Convert da na mesma 
            lblCor.Text = carro1.cor;
            lblMarca.Text = carro1.marca;
            lblMotorizacao.Text = carro1.motorizacao;
            lblVelocidadeMax.Text = Convert.ToString(carro1.velocidade_max);
            lblQuantMarchas.Text = Convert.ToString(carro1.quantidade_marchas);

            picMonza.Visible = false;
            picUno.Visible = true;

            
        }

        private void btnMonza(object sender, EventArgs e)
        {
            K carro2 = new K();

            //setando as variasveis
            carro2.modelo = "Monza";
            carro2.ano_fabricacao = 1999;
            carro2.cor = "Branco";
            carro2.marca = "volks";
            carro2.motorizacao = "1.3";
            carro2.velocidade_max = 100;
            carro2.quantidade_marchas = 4;

            // colocar no ficha
            lblModelo.Text = carro2.modelo;
            lblAnoFabricacao.Text = carro2.ano_fabricacao.ToString(); //ou poderia usar o Convert da na mesma 
            lblCor.Text = carro2.cor;
            lblMarca.Text = carro2.marca;
            lblMotorizacao.Text = carro2.motorizacao;
            lblVelocidadeMax.Text = Convert.ToString(carro2.velocidade_max);
            lblQuantMarchas.Text = Convert.ToString(carro2.quantidade_marchas);

            picMonza.Visible = true;
            picUno.Visible = false;

        }
    }
}
