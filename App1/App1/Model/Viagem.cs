using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1.Model
{
    public class Viagem
    {
        
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }

        public double Distancia { get; set; }
        public double Consumo { get; set; }
        public double Valor_Litro_Combustivel { get; set; }

        public double Total_Viagem
        {
            get { return (Distancia / Consumo) * Valor_Litro_Combustivel; }
        }
    }
}
