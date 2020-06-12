namespace Project_car
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblMotorizacao = new System.Windows.Forms.Label();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            this.lblVelocidadeMax = new System.Windows.Forms.Label();
            this.lblQuantMarchas = new System.Windows.Forms.Label();
            this.picMonza = new System.Windows.Forms.PictureBox();
            this.picUno = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnBuzinar = new System.Windows.Forms.Button();
            this.btnFarois = new System.Windows.Forms.Button();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnVirar = new System.Windows.Forms.Button();
            this.lblMarchaA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMonza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(352, 35);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 45);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button Uno";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnUno);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(346, 109);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 45);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "button Monza";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnMonza);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(230, 67);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(52, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "lblModelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(230, 101);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "lblMarca";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(56, 141);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(33, 13);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "lblCor";
            // 
            // lblMotorizacao
            // 
            this.lblMotorizacao.AutoSize = true;
            this.lblMotorizacao.Location = new System.Drawing.Point(56, 101);
            this.lblMotorizacao.Name = "lblMotorizacao";
            this.lblMotorizacao.Size = new System.Drawing.Size(75, 13);
            this.lblMotorizacao.TabIndex = 5;
            this.lblMotorizacao.Text = "lblMotorizacao";
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Location = new System.Drawing.Point(56, 67);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(89, 13);
            this.lblAnoFabricacao.TabIndex = 6;
            this.lblAnoFabricacao.Text = "lblAnoFabricacao";
            // 
            // lblVelocidadeMax
            // 
            this.lblVelocidadeMax.AutoSize = true;
            this.lblVelocidadeMax.Location = new System.Drawing.Point(202, 141);
            this.lblVelocidadeMax.Name = "lblVelocidadeMax";
            this.lblVelocidadeMax.Size = new System.Drawing.Size(90, 13);
            this.lblVelocidadeMax.TabIndex = 7;
            this.lblVelocidadeMax.Text = "lblVelocidadeMax";
            // 
            // lblQuantMarchas
            // 
            this.lblQuantMarchas.AutoSize = true;
            this.lblQuantMarchas.Location = new System.Drawing.Point(138, 35);
            this.lblQuantMarchas.Name = "lblQuantMarchas";
            this.lblQuantMarchas.Size = new System.Drawing.Size(87, 13);
            this.lblQuantMarchas.TabIndex = 8;
            this.lblQuantMarchas.Text = "lblQuantMarchas";
            // 
            // picMonza
            // 
            this.picMonza.Image = global::Project_car.Properties.Resources.Monza;
            this.picMonza.Location = new System.Drawing.Point(163, 354);
            this.picMonza.Name = "picMonza";
            this.picMonza.Size = new System.Drawing.Size(141, 78);
            this.picMonza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonza.TabIndex = 10;
            this.picMonza.TabStop = false;
            // 
            // picUno
            // 
            this.picUno.Image = global::Project_car.Properties.Resources.FIAT_UNO;
            this.picUno.Location = new System.Drawing.Point(24, 355);
            this.picUno.Name = "picUno";
            this.picUno.Size = new System.Drawing.Size(121, 77);
            this.picUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUno.TabIndex = 9;
            this.picUno.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(384, 220);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 65);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 11;
            this.picBox.TabStop = false;
            // 
            // btnBuzinar
            // 
            this.btnBuzinar.Location = new System.Drawing.Point(490, 46);
            this.btnBuzinar.Name = "btnBuzinar";
            this.btnBuzinar.Size = new System.Drawing.Size(75, 23);
            this.btnBuzinar.TabIndex = 12;
            this.btnBuzinar.Text = "Buzinar";
            this.btnBuzinar.UseVisualStyleBackColor = true;
            this.btnBuzinar.Click += new System.EventHandler(this.btnBuzinar_Click);
            // 
            // btnFarois
            // 
            this.btnFarois.Location = new System.Drawing.Point(490, 101);
            this.btnFarois.Name = "btnFarois";
            this.btnFarois.Size = new System.Drawing.Size(75, 23);
            this.btnFarois.TabIndex = 13;
            this.btnFarois.Text = "Fárois";
            this.btnFarois.UseVisualStyleBackColor = true;
            this.btnFarois.Click += new System.EventHandler(this.btnFarois_Click);
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(490, 166);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerar.TabIndex = 14;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(571, 144);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(25, 25);
            this.btnMais.TabIndex = 15;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(571, 188);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(25, 25);
            this.btnMenos.TabIndex = 16;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnVirar
            // 
            this.btnVirar.Location = new System.Drawing.Point(490, 220);
            this.btnVirar.Name = "btnVirar";
            this.btnVirar.Size = new System.Drawing.Size(75, 23);
            this.btnVirar.TabIndex = 17;
            this.btnVirar.Text = "Virar";
            this.btnVirar.UseVisualStyleBackColor = true;
            this.btnVirar.Click += new System.EventHandler(this.btnVirar_Click);
            // 
            // lblMarchaA
            // 
            this.lblMarchaA.AutoSize = true;
            this.lblMarchaA.Location = new System.Drawing.Point(571, 172);
            this.lblMarchaA.Name = "lblMarchaA";
            this.lblMarchaA.Size = new System.Drawing.Size(13, 13);
            this.lblMarchaA.TabIndex = 18;
            this.lblMarchaA.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 311);
            this.Controls.Add(this.lblMarchaA);
            this.Controls.Add(this.btnVirar);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.btnFarois);
            this.Controls.Add(this.btnBuzinar);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.picMonza);
            this.Controls.Add(this.picUno);
            this.Controls.Add(this.lblQuantMarchas);
            this.Controls.Add(this.lblVelocidadeMax);
            this.Controls.Add(this.lblAnoFabricacao);
            this.Controls.Add(this.lblMotorizacao);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picMonza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblMotorizacao;
        private System.Windows.Forms.Label lblAnoFabricacao;
        private System.Windows.Forms.Label lblVelocidadeMax;
        private System.Windows.Forms.Label lblQuantMarchas;
        private System.Windows.Forms.PictureBox picUno;
        private System.Windows.Forms.PictureBox picMonza;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnBuzinar;
        private System.Windows.Forms.Button btnFarois;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnVirar;
        private System.Windows.Forms.Label lblMarchaA;
    }
}

