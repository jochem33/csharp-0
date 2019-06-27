using System;

namespace telefoons
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Mobiel iphone = new Mobiel("iphone", "XS", "IOS", "Steve Jobs", 999.99f);
            Mobiel samsung = new Mobiel("galaxy", "S7", "Android", "Kom Dong Jin", 798.99f);
            Mobiel google = new Mobiel("pixel", "3", "Android", "Sundar Pichai", 865.59f);

            Mobiel telefoon = iphone;

            Console.WriteLine(iphone.soort + " door " + iphone.CEO);
            Console.WriteLine(samsung.soort + " door " + samsung.CEO);
            Console.WriteLine(google.soort + " door " + google.CEO);


            Console.WriteLine("Welke mobiel wil je kopen? ");
            string welkeMobiel = Console.ReadLine();
            Console.WriteLine("Hoeveel wil je kopen? ");
            int hoeveel = Convert.ToInt32(Console.ReadLine());

            if (welkeMobiel == iphone.soort || welkeMobiel == iphone.model)
            {
                telefoon = iphone;
            }
            else if (welkeMobiel == samsung.soort || welkeMobiel == samsung.model)
            {
                telefoon = samsung;
            }
            else if (welkeMobiel == google.soort || welkeMobiel == google.model)
            {
                telefoon = google;
            }

            float price = telefoon.price * hoeveel;
            Console.WriteLine("Dat kost: " + price);
            if(price > 900)
            {
                Console.WriteLine("Gefeliciteerd, het kost meer dan 900 euro dus je krijgt gratis verzending!");
            }
        }
    }
}
