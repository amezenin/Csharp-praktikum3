using System;

namespace praktikum3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rystkylik uusRystkylik = new Rystkylik(4, 2);
            uusRystkylik.ArvutaPindala();

            Rystkylik teineRystkylik = new Rystkylik(4, 4);

            bool kasOnVordne = uusRystkylik.KasOnVordne(teineRystkylik);
            bool kasOnRuutEsimene = uusRystkylik.KasOnRuut();
            bool kasOnRuutTeine = teineRystkylik.KasOnRuut();

            Console.WriteLine("Esimese ristkyliku pindala: " + uusRystkylik.ArvutaPindala());
            Console.WriteLine("Esimese ristkyliku pindala: " + teineRystkylik.ArvutaPindala());
            Console.WriteLine("Kas Ristkylikud on vordsed?: " + kasOnVordne);
            Console.WriteLine("Kas esimene ristkylik on ruut?: " + kasOnRuutEsimene);
            Console.WriteLine("Kas teine ristkylik on ruut?: " + kasOnRuutTeine);

            Console.ReadLine();


            //Punkt

            Punkt esimenePunkt = new Punkt(0, 0);
            Punkt teinePunkt = new Punkt(6, 9);

            double esimesePunktiKaugusNullist = esimenePunkt.kaugusNullist();
            double teisePunktiKaugusNullist = teinePunkt.kaugusNullist();

            Console.WriteLine("Kaugus nullist, esimene punkt: " + esimesePunktiKaugusNullist);
            Console.WriteLine("Kaugus nullist, teine punkt: " + teisePunktiKaugusNullist);
            Console.WriteLine("Esimese punkti kaugus teisest punktist: " + esimenePunkt.kaugusTeisest(teinePunkt));
            
            string esimesePunktiAndmed = esimenePunkt.teataAndmed();
            string teisePunktiAndmed = teinePunkt.teataAndmed();
            Console.WriteLine("Esimese punkti andmed: " + esimesePunktiAndmed);
            Console.WriteLine("Teise punkti andmed: " + teisePunktiAndmed);

           

            bool kasEsimenePunktOnAlguspunkt = esimenePunkt.kasOnAlguspunkt();
            bool kasTeinePunktOnAlguspunkt = teinePunkt.kasOnAlguspunkt();

            

            Console.WriteLine("Kas esimene punkt on alguspunkt?: " + kasEsimenePunktOnAlguspunkt);
            Console.WriteLine("Kas teine punkt on alguspunkt?: " + kasTeinePunktOnAlguspunkt);

            Console.ReadLine();

            //KOMPLEKSARV
            Kompleksarv esimeneKompleksarv = new Kompleksarv(7.1, 5.3);
            Kompleksarv teineKompleksarv = new Kompleksarv(5.6, 9.8);

            Kompleksarv liida = esimeneKompleksarv.liida(teineKompleksarv);
            
            //Console.WriteLine("Summa: " + esimeneKompleksarv.liida(teineKompleksarv));
            Console.WriteLine("Lahutus: " + esimeneKompleksarv.lahuta(teineKompleksarv));
            Console.ReadLine();

        }
    }
}
