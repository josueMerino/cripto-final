using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CriptoFinalForm
{
    public class Clave
    {
        private XmlNode claves;

        public Clave(XmlDocument claves)
        {
            this.claves = this.getClavesFromXml(claves);
        }

        public String getClavePublica()
        {
            return this.claves.SelectSingleNode("/clave").InnerText;
        }

        public String getClavePrivada()
        {
            return this.claves.SelectSingleNode("/clavePrivada").InnerText;
        }

        private XmlNode getClavesFromXml(XmlDocument claves)
        {
            return claves.DocumentElement.SelectSingleNode("/ALGORITMO");
        }
    }
}
