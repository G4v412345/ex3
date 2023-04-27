using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class CountryMedal
    {
        public string country;
        public int ath;
        public int goldM;
        public int silvM;
        public int bronM; 
        public CountryMedal(string country, int ath, int goldM, int silvM, int bronM)
        {
            this.country = country;
            this.ath = ath;
            this.goldM = goldM;
            this.silvM = silvM;
            this.bronM = bronM; 
        } 
        public string GetInformation()
        {
            string info;
            info = "Страна: " + this.country + "; Кол. спортсменов: " + this.ath + "; Кол. зол. мед.: " + this.goldM + "; Кол. сер. мед.: " + this.silvM + ";Кол. брон. мед.: " + this.bronM;
            return info; 
        }
    }
}
