using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces
{
    class Popup : Janela
    {
        private bool botaoOk;
        private bool botaoCancel;
        public bool BotaoOk { get => botaoOk; set => botaoOk = value; }
        public bool BotaoCancel { get => botaoCancel; set => botaoCancel = value; }

        public Popup(bool botaoOk, bool botaoCancel, bool fechar, bool max, bool min, string titulo, int x, int y ):base(fechar, max, min, titulo, x, y)
        {
            this.botaoOk = botaoOk;
            this.botaoCancel = botaoCancel;
        }

        public Popup()
        {
        }
    }
}
