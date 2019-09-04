using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y.Arıkolonisi
{
    class Kaynak
    {
        static Random rnd = Form1.rnd;

        public int kaynaksayısı, kaynakboyutu, limit;
        public double bestfitness = 0;
        public double[,] kaynak;
        public double[] uygunlukdeger;
        public double[] fitnessdeger;
        public double[] pdegeri;
        public double[] limitsayacı;


        public Kaynak(int kaynaksayısı, int kaynakboyutu, double altdeger, double ustdeger)
        {

            this.kaynaksayısı = kaynaksayısı / kaynakboyutu;
            this.kaynakboyutu = kaynakboyutu;

            this.fitnessdeger = new double[kaynaksayısı];
            limitsayacı = new double[kaynaksayısı];
            kaynaklarıolustur(kaynaksayısı, kaynakboyutu, altdeger, ustdeger);
            limit = (kaynaksayısı * kaynakboyutu) / 2;

        }
        public double[] kaynakolustur(int boyut, double altdeger, double ustdeger)
        {

            double[] kaynak = new double[boyut];
            double rastgele;
            bool benzersiz= false;

            for (int i = 0; i < boyut; i++)
            {

                rastgele = (altdeger + (ustdeger - altdeger) * rnd.NextDouble());
                foreach (var item in kaynak)
                {
                    if (item != rastgele)
                    {
                        kaynak[i] = rastgele;
                        benzersiz = true;
                    }
                }
                if (benzersiz == false)
                {
                    i--;
                }

                
            }

            return kaynak;
        }
        public double[,] kaynaklarıolustur(int kaynaksayısı, int kaynakboyutu, double altdeger, double ustdeger)
        {


            kaynak = new double[kaynaksayısı, kaynakboyutu];

            for (int i = 0; i < kaynaksayısı; i++)
            {
                double[] kaynak = kaynakolustur(kaynakboyutu, altdeger, ustdeger);

                for (int j = 0; j < kaynakboyutu; j++)
                {
                    this.kaynak[i, j] = kaynak[j];
                }
            }

            uygunlukvefitnesshesabı();

            return kaynak;
        }


        public void uygunlukvefitnesshesabı()
        {
            uygunlukdeger = new double[this.kaynaksayısı];
            fitnessdeger = new double[this.kaynaksayısı];

            for (int i = 0; i < kaynaksayısı; i++)
            {
                uygunlukdeger[i] = Ackleyfunction.ACKLEYSFUNCTION(kaynak[i, 0], kaynak[i, 1]);
                fitnessdeger[i] = fitnessHesapla(uygunlukdeger[i]);
            }

        }


        double fitnessHesapla(double sayi)
        {
            if (sayi >= 0)
            {
                sayi = 1 / (1 + sayi);
            }
            else
            {
                sayi = 1 + Math.Abs(sayi);

            }
            return sayi;
        }

        public void Cozumdegerlerihesapla()
        {
            for (int i = 0; i < kaynaksayısı; i++)
            {
                tekilcozumdegerihesapla(i);
            }
        }


        void tekilcozumdegerihesapla(int i)
        {
            double[] gecicicozum = new double[kaynakboyutu];
            double geciciFitness;
            double geciciUygunluk;
            for (int j = 0; j < kaynakboyutu; j++)
            {
                gecicicozum[j] = (kaynak[i, j] + (2 * rnd.NextDouble() - 1) * (kaynak[i, j] - ((i == kaynaksayısı - 1) ? kaynak[0, j] : kaynak[i + 1, j])));

                if (gecicicozum[j] > Ackleyfunction.ustdeger) gecicicozum[j] = Ackleyfunction.ustdeger;
                else if (gecicicozum[j] < Ackleyfunction.aldeger) gecicicozum[j] = Ackleyfunction.aldeger;

                kaynak[i, j] = gecicicozum[j];
            }



            geciciUygunluk = Ackleyfunction.ACKLEYSFUNCTION(kaynak[i, 0], kaynak[i, 1]);
            geciciFitness = fitnessHesapla(geciciUygunluk);

            if (geciciFitness < fitnessdeger[i])
            {
                limitsayacı[i] += 1;
            }
            else
            {
                for (int j = 0; i < kaynakboyutu; i++)
                {
                    kaynak[i, j] = gecicicozum[j];
                }

                fitnessdeger[i] = geciciFitness;
                uygunlukdeger[i] = geciciUygunluk;
                limitsayacı[i] = 0;
            }

        }


        public void kasifkaynakara()
        {

            for (int i = 0; i < limitsayacı.Length; i++)
            {
                if (limitsayacı[i] > limit)
                {
                    double[] yenikaynak = kaynakolustur(kaynakboyutu, Ackleyfunction.aldeger, Ackleyfunction.ustdeger);
                    double yenikaynakuygunluk = Ackleyfunction.ACKLEYSFUNCTION(yenikaynak[0], yenikaynak[1]);
                    double yenikaynakFitness = fitnessHesapla(yenikaynakuygunluk);
                    if (yenikaynakFitness > bestfitness)
                    {
                        kaynak[i, 0] = yenikaynak[0];
                        kaynak[i, 1] = yenikaynak[1];
                    }
                }
            }

        }





        public void Phesabı()
        {
           
            pdegeri = new double[fitnessdeger.Length];
            double fitnessToplam = 0;
            for (int i = 0; i < fitnessdeger.Length; i++)
            {
                fitnessToplam += fitnessdeger[i];
            }
            for (int i = 0; i < fitnessdeger.Length; i++)
            {
                pdegeri[i] = fitnessdeger[i] / fitnessToplam;
            }

        }
        //gözcü arılar bölümü

        public int ruletsecimi(double[] pdegeri, Random rnd)
        {
            int secilen = 0;
            double toplam = pdegeri[0];

            for (int i = 1; i < pdegeri.Length; i++)
            {
                toplam += pdegeri[i];
                if (rnd.NextDouble() <= (pdegeri[i] / toplam)) secilen = i;
            }

            return secilen;
        }

        public void Gozcuarı()
        {

            int secim = 0;
            for (int i = 0; i < pdegeri.Length; i++)
            {
                secim = ruletsecimi(pdegeri, rnd);
                tekilcozumdegerihesapla(secim);
            }
            bestfitness = Max(fitnessdeger);
        }


        private double Max(double[] fitnesslar)
        {
            double buyuk = fitnesslar[0];

            for (int i = 0; i < fitnesslar.Length; i++)
            {
                if (buyuk < fitnesslar[i])
                { buyuk = fitnesslar[i]; }
            }
            return buyuk;
        }
    }
}
