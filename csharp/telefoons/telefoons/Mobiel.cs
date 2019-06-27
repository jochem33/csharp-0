using System;


namespace telefoons
{
    public class Mobiel
    {
        public string soort;
        public string model;
        public string os;
        public string CEO;
        public float price;

        public Mobiel(string nSoort, string nModel, string nOs, string nCEO, float nPrice)
        {
            soort = nSoort;
            model = nModel;
            os = nOs;
            CEO = nCEO;
            price = nPrice;
        }
    }
}
