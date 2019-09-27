using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces
{
    class Combobox
    {
        private List<string> opcoes;
        private int itemAtual;

        public int ItemAtual { get => itemAtual; set => itemAtual = value; }

        public Combobox(int item)
        {
            ItemAtual = item;

        }
    }
}
