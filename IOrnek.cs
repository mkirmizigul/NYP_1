using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ornek_1
{
    interface IOrnek
    {
        string getMarka();

        string model { get; }

        int maxHiz { get;set;}

        int Gosterge(int deger);
        
        void BilgiYaz();
    }
}
