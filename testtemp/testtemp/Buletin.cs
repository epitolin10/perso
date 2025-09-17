using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtemp
{
    public class Buletin
    {
        DateTime periodediffusion { get; set; }

        public Zonegeographique zonegeographique { get; set; }

        public Buletin(DateTime dt, Zonegeographique zonegeographique)
        {
            this.periodediffusion = dt;
            this.zonegeographique = zonegeographique;
        }
        public bool ajouterzone()
        {
            return false;
        }
        public double Moyennetemperature(string typetemperature, Zonegeographique zonegeographique)
        {
            double moyennetemperature = 0;
            int counter = 0;
            //
            {

            }
        }
        public Releve afficherrelever()
        {
            return 0;
        }
        public Zonegeographique Temperaturemax()
        {
            return 0;
        }
        public Zonegeographique Temperaturemin()
        {
            return 0;
        }
    }   
} 
