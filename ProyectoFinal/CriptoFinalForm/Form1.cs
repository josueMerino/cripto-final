using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoFinalForm
{
    public partial class Form1 : Form
    {
        private String archivoClavesNombre;
        private String archivoMensajeNombre;

        public Form1()
        {
            InitializeComponent();
            mensajeFinal.Text = "";
            accionRealizar.DropDownStyle = ComboBoxStyle.DropDownList;
            accionRealizar.SelectedIndex = 0;
        }

        private void subirArchivoClavesBoton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                this.archivoClavesNombre = openFileDialog1.FileName;
                FileStream file1 = new FileStream(archivoClavesNombre, FileMode.Open, FileAccess.Read);
                VistaControlador vistaHandler = new VistaControlador(file1, file1);

            }
        }

        private void subirArchivoMensajeBoton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                this.archivoMensajeNombre = openFileDialog1.FileName;
            }
            
        }

        private void encriptarDesencriptarBoton(object sender, EventArgs e)
        {
            FileStream archivoClaves = new FileStream(this.archivoClavesNombre, FileMode.Open, FileAccess.Read);
            FileStream archivoMensaje = new FileStream(this.archivoMensajeNombre, FileMode.Open, FileAccess.Read);

            VistaControlador vistaHandler = new VistaControlador(archivoClaves, archivoMensaje);
            if(accionRealizar.Text == "Encriptar")
            {
                mensajeFinal.Text = vistaHandler.mostrarTextoEncriptado();
            }
            else
            {
                mensajeFinal.Text = vistaHandler.mostrarTextoDesencriptado();
            }

        }
    }
}
