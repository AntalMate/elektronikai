using System;
using System.Collections.Generic;
using System.Text;

namespace elektronikai
{
    public interface IKapcsolhato
    {
        public bool Bekapcsolva { get; set; }
        public void Bekapcsol();
        public void Kikapcsol();
    }
}
