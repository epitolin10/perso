using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtemp
{
    public class Releve
    {
        double temperature { get; set; }
        double humidité { get; set; }
        double precipitation { get; set; }
        double Vents { get; set; }
        string etat { get; set; }

        public Releve leReleve { get; set; }

        public Releve(double temperature, double humidité, double precipitation, double Vents)
        {
            this.temperature = temperature;
            this.humidité = humidité;
            this.precipitation = precipitation;
            this.Vents = Vents;


        }
    }
}
