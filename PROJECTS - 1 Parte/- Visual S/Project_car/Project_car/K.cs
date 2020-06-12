using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project_car
{
    class K
    {
        public string modelo, marca, cor, motorizacao;
        public int ano_fabricacao, velocidade_max, quantidade_marchas, marcha_atual = 1;

        public void Acelerar(PictureBox picCarro)
        {
            int i = picCarro.Left;
            var t = Task.Delay(5000);

            if (picCarro.Left == 43)
            { 
                while(picCarro.Left <= 384)
                {
                    Thread.Sleep(10 - marcha_atual * 2);
                    picCarro.Left = i;
                    i++;
                }
            }
            else /*if (picCarro.Left != 43)*/
            {
                while (i >= 43)
                {
                    Thread.Sleep(10 - marcha_atual * 2);
                    picCarro.Left = i;
                    i--;
                }
            }
        }
        public void Virar(PictureBox picCarro)
        {
            Image flipImage = picCarro.Image;
            flipImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            picCarro.Image = flipImage;
        }
        public void Buzinar()
        {
            System.Media.SystemSounds.Beep.Play();
        }
        public int Troca_marcha(string acao)
        {
            if (acao == "+" && marcha_atual < 5)
                marcha_atual += 1;

            if (acao == "-" && marcha_atual > 1)
                marcha_atual -= 1;

            return marcha_atual;
        }
        public void Acerder_farois(PictureBox picCarro)
        {
            picCarro.BorderStyle = (picCarro.BorderStyle == BorderStyle.FixedSingle) ? BorderStyle.None : BorderStyle.FixedSingle;
        }
        public void putFicha(Label lblModelo, Label lblAnoFabricacao, Label lblCor, Label lblMarca, Label lblMotorizacao, Label lblVelocidadeMax,Label lblQuantMarchas) {
            lblModelo.Text = modelo;
            lblAnoFabricacao.Text = ano_fabricacao.ToString(); 
            lblCor.Text = cor;
            lblMarca.Text = marca;
            lblMotorizacao.Text = motorizacao;
            lblVelocidadeMax.Text = velocidade_max.ToString();
            lblQuantMarchas.Text = quantidade_marchas.ToString();
        }
        public void exibir_foto(PictureBox picMonza, PictureBox picUno) {
            /* geito simples
            if (modelo == "Monza") {
                picMonza.Visible = false;
                picUno.Visible = true;
            }
            if (modelo == "uno") {
                picMonza.Visible = true;
                picUno.Visible = false;
            }*/

            // Por: Operador Ternário
            picMonza.Visible = (modelo == "Monza") ? true : false;
            picUno.Visible = (modelo == "uno") ? true : false;

        }
        public void troca_foto(PictureBox car)
        { //para saber onde esses arquivos estão va prorerties -> Resourses (double click)
            if (modelo == "Monza")
                car.Image = Properties.Resources.Monza;
            if (modelo == "uno")
                car.Image = Properties.Resources.FIAT_UNO;
        }

        public string n_t(int number) {
            string abc = Convert.ToString(number);
            return abc;
        }
    }
}
