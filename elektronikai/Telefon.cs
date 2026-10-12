using System;
using System.Collections.Generic;
using System.Text;

namespace elektronikai
{
    public class Telefon : IKapcsolhato, IToltheto
    {
        public int ToltottsegiSzint { get; set; }
        public bool Bekapcsolva { get; set; }

        public Telefon()
        {
            ToltottsegiSzint = 50;
            Bekapcsolva = false;
        }
        public void Bekapcsol()
        {
            if (ToltottsegiSzint > 0)
            {
                Bekapcsolva = true;
            }

        }
        public void Kikapcsol()
        {
            Bekapcsolva = false;
        }

        public void Toltes(int mennyiseg)
        {
            if (mennyiseg < 0)
            {
                return;
            }
            ToltottsegiSzint += mennyiseg;
            if (ToltottsegiSzint > 100)
            {
                ToltottsegiSzint = 100;
            }
        }

        public override string? ToString()
        {
            return "Telefon " + (Bekapcsolva ? "Be" : "Ki") + $" {ToltottsegiSzint}%";
        }
    }
}
