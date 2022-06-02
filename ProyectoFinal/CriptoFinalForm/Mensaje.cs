using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoFinalForm
{
    public class Mensaje
    {
        private String texto;

        public Mensaje(string texto)
        {
            this.texto = texto;
        }

        public byte[] getMensajeParaDesencriptarEnBytes()
        {
            return Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(this.texto)));
        }

        public byte[] getMensajeParaEncriptarEnBytes()
        {
            return Convert.FromBase64String(Convert.ToBase64String(Encoding.Default.GetBytes(this.texto)));
        }


    }
}
