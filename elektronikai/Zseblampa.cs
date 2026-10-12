using System;
using System.Collections.Generic;
using System.Text;

namespace elektronikai
{
    public class Zseblampa : IKapcsolhato
    {
        public bool Bekapcsolva { get; set; }
        public Zseblampa()
        {
            Bekapcsolva = false;
        }
        public void Bekapcsol()
        {
            Bekapcsolva = true;
        }
        public void Kikapcsol()
        {
            Bekapcsolva = false;
        }

        public override string? ToString()
        {
            return "Zseblámpa " + (Bekapcsolva ? "Be" : "Ki");
        }
    }
}
