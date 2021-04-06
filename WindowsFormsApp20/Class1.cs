using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp20
{
    public class araba : arabaDetay
    {
        public string carRenk = "dafs";
        public int arabaYas;
        public double arabaLimit;
        public int arabaGüc;
        public string durum;
        private double yil;
        private string isim;

        public double YIL
        {
            get { return yil; }

            set{ yil = Math.Abs(value); }
        }

        public string Isım
        {
            get { return isim;}
            set { isim = value.ToUpper(); }
        }
    }
}
