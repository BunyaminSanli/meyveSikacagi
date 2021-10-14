
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevi
{
    abstract class Meyve
    {
        //meyvelerin ortak özellikleri için olusturulan fieldlar ve get set metotları
        private string _resimYol;
        private string _ad;
        private int _verim;
        private int _vitaminA;
        private int _vitaminC;
        private int _gram;

        private int _id;
        public int Id { get => _id; set => _id = value; }

        public string Ad { get => _ad; set => _ad = value; }
        public int Verim { get => _verim; set => _verim = value; }
        public int VitaminA { get => _vitaminA; set => _vitaminA = value; }
        public int VitaminC { get => _vitaminC; set => _vitaminC = value; }
        public int Gram { get => _gram; set => _gram = value; }
        public string ResimYol { get => _resimYol; set => _resimYol = value; }

        //random gram üreten fonsiyon
        public int GramOlustur()
        {
            Random rst = new Random();
            int gram = rst.Next(70, 120);
            return gram;
        }

        //gelen nesnenin değerlerini kullanarak vçıktıdaki vitamin A değerini hesaplayan metot
        public int VitaminHesaplaA(Meyve meyve)
        {
            int vitamin = (meyve.Gram * meyve.VitaminA * meyve.Verim) / 10000;
            return vitamin;
        }

        //gelen nesnenin değerlerini kullanarak vçıktıdaki vitamin C değerini hesaplayan metot
        public int VitaminHesaplaC(Meyve meyve)
        {
            int vitamin = (meyve.Gram * meyve.VitaminC * meyve.Verim) / 10000;
            return vitamin;
        }
    }
}
