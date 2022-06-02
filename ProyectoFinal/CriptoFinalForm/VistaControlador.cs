using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CriptoFinalForm
{
    public class VistaControlador
    {
        private FileStream archivoClaves;
        private FileStream archivoTexto;

        public VistaControlador(FileStream archivo, FileStream archivoMensaje)
        {
            this.archivoClaves = archivo;
            this.archivoTexto = archivoMensaje;
        }

        public String mostrarTextoEncriptado()
        {
            return this.importarTextoEncriptado();
        }

        public String mostrarTextoDesencriptado()
        {
            return this.importarTextoDesencriptado();
        }

        private string importarTextoEncriptado()
        {
            XmlDocument archivoXml = new XmlDocument();
            archivoXml.Load(this.archivoClaves);

            StreamReader archivoTextoPlano = new StreamReader(this.archivoTexto);

            Mensaje informacion = new Mensaje(archivoTextoPlano.ReadToEnd());

            RSA algoritmoDesencriptacion = new RSA(archivoXml, informacion);

            return algoritmoDesencriptacion.encriptar();
        }

        private string importarTextoDesencriptado()
        {
            XmlDocument archivoXml = new XmlDocument();
            archivoXml.Load(this.archivoClaves);

            StreamReader archivoTextoPlano = new StreamReader(this.archivoTexto);

            Mensaje informacion = new Mensaje(archivoTextoPlano.ReadToEnd());

            RSA algoritmoDesencriptacion = new RSA(archivoXml, informacion);

            return algoritmoDesencriptacion.desencriptar();
        }
    }
}
