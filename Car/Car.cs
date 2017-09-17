using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {

        public void start()
        {
            this.sur();
            this.doldur();
            this.local();
            this.global();
        }

        private double km;
        private double benzin = 40;
        private double isledilenBenzin;
        private double elaveBenzin;
        private double localKm;
        private double globalKm;
        private string chekLocal;

        private void sur()
        {
            Console.Write("yolun uzunlugunu daxil edin: ");
            this.km = Convert.ToDouble(Console.ReadLine());
            this.isledilenBenzin = this.km / 100 * 8;
            if (this.isledilenBenzin <= this.benzin) 
            {
                this.benzin = this.benzin - this.isledilenBenzin;
                Console.WriteLine("verilen km: "+this.km+" qaliq benzin: "+this.benzin);
                this.localKm = this.km;
                this.globalKm = this.km;
                
            }
            else
            {
                Console.WriteLine("yanacaq yetmir");
            }
        }

        private void doldur()
        {
            Console.Write("benzin elave edin: ");
            this.elaveBenzin = Convert.ToDouble(Console.ReadLine());
            if (this.benzin + this.elaveBenzin <= 40)
            {
                this.benzin += this.elaveBenzin;
                Console.WriteLine("bakda olan benzin: "+this.benzin);
            }
            else
            {
                Console.WriteLine("elave edilen benzin miqdari yanacaq hecminden choxdur ! ! !");
            }

        }

        private void local()
        {
            Console.Write("Umumu gedilen yol: {0} km sifirlamaq ucun (YES) qalmasi ucun (NO) daxil edin: ",this.globalKm);
            this.chekLocal = Console.ReadLine();
            while(chekLocal != "YES")
            {
                Console.WriteLine("duzgun secim daxil edin ! ! !");
                this.chekLocal = Console.ReadLine();
            }
            this.localKm = 0;
        }

        private void global()
        {
            Console.WriteLine("umumi gedilen yol: "+this.globalKm);
        }
    }
}
