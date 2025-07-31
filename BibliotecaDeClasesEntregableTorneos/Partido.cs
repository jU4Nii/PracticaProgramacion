using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesEntregableTorneos
{
    public class Partido 
    {

        public Partido(Equipo Equipo1, Equipo Equipo2)
        {
            this.Equipo1 = Equipo1;

            this.Equipo2 = Equipo2;

            EquipoLocal = Equipo1;

        }

        public Equipo Equipo1 { get; set; }

        public Equipo Equipo2 { get; set; }

        public Equipo EquipoLocal {  get; set; }

        public int CantGolesEquipo1 { get; set; }

        public int CantGolesEquipo2 { get; set; }

        public void RegistrarResultado(int golesEquipo1, int golesEquipo2)
        {

            CantGolesEquipo1 = golesEquipo1;

            CantGolesEquipo2 = golesEquipo2;

            Equipo1.GolesAFavor += golesEquipo1;

            Equipo1.GolesEnContra += golesEquipo2;

            Equipo2.GolesAFavor += golesEquipo2;

            Equipo2.GolesEnContra += golesEquipo1;

            if (CantGolesEquipo1 > CantGolesEquipo2) Equipo1.Puntos += 3;
            else if (CantGolesEquipo1 < CantGolesEquipo2) Equipo2.Puntos += 3;
            else
            {
                Equipo1.Puntos += 1;
                Equipo2.Puntos += 1;
            }

            string registro = $"{Equipo1.NombreEquipo} {golesEquipo1} - {golesEquipo2} {Equipo2.NombreEquipo}";

            TablaDePosiciones.HistorialDePartidos.Add(registro);


        }

    }
}
