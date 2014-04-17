using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ornek_1
{
    class Audi:IOrnek
    {
        public string getMarka()
        {
            return "Audi";
        }

        private string _model = "A4";

        public string model
        {
            get { return _model; }
        }

        private int _maxHiz;

        public int maxHiz
        {
            get
            {
                return _maxHiz;
            }
            set
            {
                _maxHiz = value;
            }
        }

        public int Gosterge(int deger)
        {
            return deger;
        }
        
        public void BilgiYaz()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" Marka : " +getMarka()+"\n");
            Console.WriteLine(" Model : " + _model + "\n");
            Console.WriteLine(" Max Hiz : " + _maxHiz + " km/h" + "\n");
            Console.WriteLine(" Gösterge : " + _maxHiz + " km/h" + "\n");
            Console.ReadLine();
        }

    }
}
