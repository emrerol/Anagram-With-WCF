using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AnagramService
{
    // NOT: "Service1" sınıf adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    public class Service1 : IService1
    {
        public string Kontrol(string kelime1, string kelime2)
        {
            char[] dizi1 = kelime1.ToLower().ToCharArray();
            char[] dizi2 = kelime2.ToLower().ToCharArray();

            Array.Sort(dizi1);
            Array.Sort(dizi2);

            string ilkKelime = new string(dizi1);
            string ikinciKelime = new string(dizi2);
            string sonuc;

            if (ilkKelime==ikinciKelime)
            {
                sonuc = "Anagram";
            }
            else
            {
                sonuc = "Anagram Değil";
            }

            return sonuc;
        }
    }
}
