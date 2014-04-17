using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ornek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrnek araba = new Audi();

            araba.maxHiz = 240;

            araba.Gosterge(280);

            araba.BilgiYaz();
        }
    }
}
