using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace RollerKolcsonzo
{
    public class RollerUtazas
    {
        public string Felhasználonev { get; set; }
        public int UtazasiIdoPerc { get; set; }
        public double MegtettKm { get; set; }

        public RollerUtazas(string sor)
        {
            string[] vag = sor.Split(";");
            Felhasználonev = vag[0];
            UtazasiIdoPerc = int.Parse(vag[1]);
            MegtettKm = double.Parse(vag[2]);
        }
        public int FizetendoDij()
        {
            int alapdij = 300;
            return alapdij + UtazasiIdoPerc * 60; 
        }
        public override string ToString()
        {
            return $"{Felhasználonev}: {UtazasiIdoPerc} perc, {MegtettKm} km - Fizetendő: {FizetendoDij()} Ft";
        }
    }

}
