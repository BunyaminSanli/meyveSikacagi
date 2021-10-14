
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevi
{
    class SikacakKati : IMeyve
    {
        //random bir verim değeri üreten fonk
        public int VerimHesapla()
        {
            Random rst = new Random();
            int gram = rst.Next(80, 95);
            return gram;
        }

        //gelen nesnenin gram ve verim değerini kullanarak elde edilen ıktının gramını geri döndüren fonk
        public int GramajHesapla(Meyve meyve)
        {
            int gram = meyve.Gram * meyve.Verim / 100;
            return gram;
        }
    }
}
