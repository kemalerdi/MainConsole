﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete Eklendi" + urun.Adi);
            
        }

        public void Ekle2(string urunAdi, string aciklama, int id)
        {
            Console.WriteLine("Sepete Eklendi");

        }
    }
}
