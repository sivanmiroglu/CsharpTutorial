using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpTutorial.Tutorials;

namespace CsharpTutorial.Tutorials
{
    public  class AlanHesaplama
    {

        public  int dikdortgenAlanMetodu(int kisakenar, int uzunkenar)
        {
            int dikdörtgenAlani = kisakenar * uzunkenar;
            return dikdörtgenAlani;
        }

        public  int dikdortgenCevreMetodu(int kisakenar, int uzunkenar)
        {
            int dikdörtgenCevresi = (kisakenar + uzunkenar) * 2;
            return dikdörtgenCevresi;

        }
        public  int ucgenAlanMetodu(int tabanuzunlugu, int yukseklik)
        {
            int ucgenAlani = (tabanuzunlugu * yukseklik) / 2;
            return ucgenAlani;
        }
        public  int daireAlanMetodu(double yaricap)
        {
            const double pi = 3.14;
            double daireAlani = pi * yaricap + yaricap;
            return (int)daireAlani;
        }
        public  int kareAlanMetodu(int Kenar)
        {
            int kareAlani = Kenar + Kenar;
            return kareAlani;
        }
        public  int kareCevreHesaplama(int kenar)
        {
            int kareCevresi = kenar * 4;
            return kareCevresi;
        }
        public  double cemberCevreMetodu(double Yaricap)
        {
            const double pi = 3.14;
            double cemberCevresi = 2 * pi * Yaricap;
            return cemberCevresi;
        }
        public  double silindirAlanMetodu(double yaricap, double yukseklik)
        {
            const double pi = 3.14;
            double silindirAlani = (2 * pi * yaricap * yaricap) + (2 * pi * yaricap * yukseklik);
            return silindirAlani;
        }
        public  double silindirHacimMetodu(double yaricap, double yukseklik)
        {
            const double pi = 3.14;
            double silindirHacmi = pi * yaricap * yaricap * yukseklik;
            return silindirHacmi;
        }
    }
}
