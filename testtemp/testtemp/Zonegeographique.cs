using System.Security.Cryptography.X509Certificates;

namespace testtemp
{
    public class Zonegeographique
    {
        double longitude { get; set; }
        double latitude { get; set; }
        string lieuDit { get; set; }
        
        // jointure de releve en 0.1
        public Releve releve { get; set; }
        public Zonegeographique(double longitude, double latitude, string lieuDit, Releve releve )
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.lieuDit = lieuDit;
            this.releve = releve;
        }   
       
    
    }
}

