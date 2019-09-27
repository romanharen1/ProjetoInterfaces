using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Popup p = new Popup();
            p.BotaoCancel = true;
            p.BotaoFechar = true;
            p.BotaoMax = true;
            p.BotaoMin = true;
            p.BotaoOk = true;
            p.PosX = 1000;
            p.PosY = 450;

            Modal m = new Modal();
            m.PosX = 1000;
            m.PosY = 720;
            m.Titulo = "Modal na Moral";
            m.SetAltura(1024);
            m.SetLargura(768);
        }
    }
}
