using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextoEncriptado informacion = TextoEncriptado.getTexto();

            //Algoritmo textoResuelto = Algoritmo.desencriptar(informacion);

            //Console.WriteLine(textoResuelto);

            StreamReader file = new StreamReader("../../../informacion.txt");
            string fileContent = file.ReadToEnd();
            file.Close();
            byte[] text = Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(fileContent)));
            
            XmlDocument claves = new XmlDocument();
            claves.Load("../../../claves.xml");
          
            XmlNode node = claves.DocumentElement.SelectSingleNode("/ALGORITMO/clavePrivada");
            String clavePrivada = node.InnerText;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            rsa.FromXmlString(clavePrivada);
      

            byte[] decryptedMessageBytes = rsa.Decrypt(text, false);
            string decryptedMessageString = Encoding.UTF8.GetString(decryptedMessageBytes);
            Console.WriteLine(decryptedMessageString.ToString());
            

        }
    }
}
