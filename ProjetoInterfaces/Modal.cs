using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces
{
    class Modal : Janela, IDimensionavel
    {
        private int maxAlt;
        private int maxLarg;
        private int atualAlt;
        private int atualLarg;

        public int MaxAlt { get => maxAlt; set => maxAlt = value; }
        public int MaxLarg { get => maxLarg; set => maxLarg = value; }
        public int AtualAlt { get => atualAlt; set => atualAlt = value; }
        public int AtualLarg { get => atualLarg; set => atualLarg = value; }

        public Modal(int mA, int mL, int aA, int aL, bool fechar, bool max, bool min, string titulo, int x, int y) : base(fechar, max, min, titulo, x, y)
        {
            MaxAlt = mA;
            MaxLarg = mL;
            AtualAlt = aA;
            AtualLarg = aL;
        }
        public Modal(bool fechar, bool max, bool min, string titulo, int x, int y) : base(fechar, max, min, titulo, x, y)
        {

        }

        public Modal()
        {
        }

        public void FullScreen()
        {
            AtualAlt = MaxAlt;
            AtualLarg = MaxLarg;
        }
        public void SetLargura(int n)
        {
            if (n >= 1 && n <= MaxAlt)
                AtualLarg = n;
        }
        public void SetAltura(int n)
        {
            if (n >= 1 && n <= MaxLarg)
                AtualAlt = n;
        }
        private void AlterarTitulo(string t)
        {
            Titulo = t;
        }
    }
}

