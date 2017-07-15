using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole gr = new GameRole();
            gr.InitState();
            gr.StateDisplay();

            RoleStateCaretaker rsc = new RoleStateCaretaker();
            rsc.RoleMemento = gr.SaveState();

            gr.Fight();
            gr.StateDisplay();

            gr.RecoveryState(rsc.RoleMemento);
            gr.StateDisplay();

            Console.ReadKey();
        }
    }
}


