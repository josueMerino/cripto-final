using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CriptoFinalForm
{
    public class RSA
    {
        private Clave clavesPublicaPrivada;
        private Mensaje mensaje;
        private RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        public RSA(XmlDocument archivoClaves, Mensaje mensaje)
        {
            this.clavesPublicaPrivada = new Clave(archivoClaves);
            this.mensaje = mensaje;
        }

        public String desencriptar()
        {
            rsa.FromXmlString(this.clavesPublicaPrivada.getClavePrivada());
            
            byte[] mensajeDesencriptadoEnBytes = rsa.Decrypt(this.mensaje.getMensajeParaDesencriptarEnBytes(), false);
             
            return Encoding.Default.GetString(mensajeDesencriptadoEnBytes);
        }

        public String encriptar()
        {
            rsa.FromXmlString(this.clavesPublicaPrivada.getClavePublica());
            byte[] mensajeEncriptadoEnBytes = rsa.Encrypt(this.mensaje.getMensajeParaEncriptarEnBytes(), false);
            return Convert.ToBase64String(Encoding.Default.GetBytes(Convert.ToBase64String(mensajeEncriptadoEnBytes)));
        }
    }
}
