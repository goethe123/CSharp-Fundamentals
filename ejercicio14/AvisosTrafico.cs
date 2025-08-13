using System;
using System.Collections.Generic;
namespace ejercicio14
{
    public class AvisosTrafico : IAvisos
    {

        private string remitente;
        private string mensaje;

        private string fecha;
        public string getFeha()
        {
            return fecha;
        }

        public void mostrarAvisos()
        {
            Console.WriteLine("el mensaje {0} ha sido enviado por {1} en la fecha de {2}", mensaje, remitente, fecha);
        }

        public AvisosTrafico()
        {
            remitente = "DGMT";

            mensaje = "sancion cometida pague antes de 3 dias y se le dara un descuento";

            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
    }
}