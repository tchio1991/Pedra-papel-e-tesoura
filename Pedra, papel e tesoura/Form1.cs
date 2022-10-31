using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedra__papel_e_tesoura
{
    public partial class Form1 : Form
    {
        Image[] imgCPU = new Image[]
        {
            Properties.Resources.Pedra1,
            Properties.Resources.Papel1,
            Properties.Resources.Tesoura1
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            PicJogador.Image = bt.BackgroundImage;
            Jogada jogadaJogador = RetornaJogadaDoJogador(Convert.ToInt32(bt.Tag));
            Jogada jogadaAdversario = RetornaJogadaDoAdversario();
            Resultado resultado = RetornoGanhador(jogadaJogador, jogadaAdversario);

            if (resultado == Resultado.VitoriaCPU)
            {
                PlacarCPU.Text = (int.Parse(PlacarCPU.Text) + 1).ToString();
            } else if (resultado == Resultado.VitoriaJogador)
            {
                PlacarJogador.Text = (int.Parse(PlacarJogador.Text) + 1).ToString();
            }
        }
         
        private Resultado RetornoGanhador(Jogada jogador, Jogada adversario)
        {
            if(jogador == Jogada.Pedra) {

                if(adversario == Jogada.Papel)
                {
                    return Resultado.VitoriaCPU;
                } else if (jogador == Jogada.Tesoura)
                {
                    return Resultado.VitoriaJogador;
                }

            } else if (jogador == Jogada.Papel)
            {
                if (adversario == Jogada.Pedra)
                {
                    return Resultado.VitoriaJogador;
                } else if (adversario == Jogada.Tesoura)
                {
                    return Resultado.VitoriaCPU;
                }
            } else
            {
                if (adversario == Jogada.Pedra)
                {
                    return Resultado.VitoriaCPU;
                } else if (adversario == Jogada.Papel)
                {
                    return Resultado.VitoriaJogador;
                }
            }

            return Resultado.Empata;
        }
        private Jogada RetornaJogadaDoJogador(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadaDoAdversario()
        {
            Random rmd = new Random();
            int escolha = rmd.Next(3);
            PicCPU.Image = imgCPU[escolha];
            return (Jogada)escolha;

        }
    }

    enum Jogada
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }

    enum Resultado
    {
        VitoriaJogador,
        VitoriaCPU, 
        Empata
        
    }
}
