using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces
{
    class Janela
    {
        private bool botaoFechar;
        private bool botaoMax;
        private bool botaoMin;
        private string titulo;
        private int posX;
        private int posY;

        public bool BotaoFechar { get => botaoFechar; set => botaoFechar = value; }
        public bool BotaoMax { get => botaoMax; set => botaoMax = value; }
        public bool BotaoMin { get => botaoMin; set => botaoMin = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }

        public Janela(bool fechar, bool max, bool min, string titulo, int x, int y)
        {
            BotaoFechar = fechar;
            BotaoMax = max;
            BotaoMin = min;
            Titulo = titulo;
            PosX = x;
            PosY = y;
        }
        
        public Janela()
        {

        }

        public void MoverJanela(int x, int y)
        {
            PosX = x;
            PosY = y;
        }
    }
}
