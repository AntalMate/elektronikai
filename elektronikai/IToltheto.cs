using System;
using System.Collections.Generic;
using System.Text;

namespace elektronikai
{
    public interface IToltheto
    {
        public int ToltottsegiSzint { get; set; }
        public void Toltes(int mennyiseg);
    }
}
