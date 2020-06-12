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
            picBox.Left = 43;
        }

        K MeuCarro = new K();
        private void btnUno(object sender, EventArgs e)
        {

            MeuCarro.modelo = "uno";
            MeuCarro.ano_fabricacao = 2005;
            MeuCarro.cor = "azul";
            MeuCarro.marca = "exa";
            MeuCarro.motorizacao = "1.8";
            MeuCarro.velocidade_max = 120;
            MeuCarro.quantidade_marchas = 6;

            MeuCarro.putFicha(lblModelo,lblAnoFabricacao, lblCor,lblMarca,lblMotorizacao,lblVelocidadeMax, lblQuantMarchas);

            MeuCarro.exibir_foto(picMonza, picUno);

            MeuCarro.troca_foto(picBox);
            /* versão 1
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
            picUno.Visible = true; */


        }

        private void btnMonza(object sender, EventArgs e)
        {

            MeuCarro.modelo = "Monza";
            MeuCarro.ano_fabricacao = 1999;
            MeuCarro.cor = "Branco";
            MeuCarro.marca = "volks";
            MeuCarro.motorizacao = "1.3";
            MeuCarro.velocidade_max = 100;
            MeuCarro.quantidade_marchas = 4;

            MeuCarro.putFicha(lblModelo, lblAnoFabricacao, lblCor, lblMarca, lblMotorizacao, lblVelocidadeMax, lblQuantMarchas);

            MeuCarro.exibir_foto(picMonza, picUno);

            MeuCarro.troca_foto(picBox);
        }

        private void btnBuzinar_Click(object sender, EventArgs e)
        {
            MeuCarro.Buzinar();
        }

        private void btnFarois_Click(object sender, EventArgs e)
        {
            MeuCarro.Acerder_farois(picBox);
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            MeuCarro.Acelerar(picBox);
        }

        private void btnVirar_Click(object sender, EventArgs e)
        {
            MeuCarro.Virar(picBox);
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            lblMarchaA.Text = MeuCarro.Troca_marcha("+").ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            lblMarchaA.Text = MeuCarro.Troca_marcha("-").ToString();
        }
    }
}
