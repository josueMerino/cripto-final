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
            accionRealizar.DropDownStyle = ComboBoxStyle.DropDownList;
            algoritmoSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            accionRealizar.SelectedIndex = 1;
            algoritmoSeleccion.SelectedIndex = 0;
            infoText.Enabled = false;
        }

        private void subirArchivoClavesBoton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                this.archivoClavesNombre = openFileDialog1.FileName;
                infoClaves.Text = openFileDialog1.SafeFileName;
                infoClavesShow.Text = File.ReadAllText(this.archivoClavesNombre);
            }
        }

        private void subirArchivoMensajeBoton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                this.archivoMensajeNombre = openFileDialog1.FileName;
                infoText.Text = File.ReadAllText(this.archivoMensajeNombre);
            }
            
        }

        private void encriptarDesencriptarBoton(object sender, EventArgs e)
        {
            FileStream archivoClaves = new FileStream(this.archivoClavesNombre, FileMode.Open, FileAccess.Read);
            FileStream archivoMensaje = new FileStream(this.archivoMensajeNombre, FileMode.Open, FileAccess.Read);

            VistaControlador vistaHandler = new VistaControlador(archivoClaves, archivoMensaje);
            if(accionRealizar.Text == "Encriptar")
            {
                 MessageBox.Show(vistaHandler.mostrarTextoEncriptado());
            }
            else
            {
                MessageBox.Show(vistaHandler.mostrarTextoDesencriptado());
            }

        }

        private void salirBoton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
