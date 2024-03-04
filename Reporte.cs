using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso1
{
    class Reporte
    {
        string nombreEmpleado;
        int mes;
        decimal sieldoMensual;

        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public int Mes { get => mes; set => mes = value; }
        public decimal SieldoMensual { get => sieldoMensual; set => sieldoMensual = value; }
    }
}
