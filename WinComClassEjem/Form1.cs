using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinComClassEjem
{
    public partial class btnPath : Form
    {
        private object openFileDialog1;

        public btnPath()
        {
            InitializeComponent();
        }

  

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            // Abre un cuadro de diálogo para seleccionar un archivo PDF
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            // Muestra el cuadro de diálogo para seleccionar un archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtiene la ruta del archivo PDF seleccionado
                    string filePath = openFileDialog1.FileName;

                    // Carga el archivo PDF en el control axAcroPDF
                    PDF.LoadFile(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnReproduirVideo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath + "C:\\Users\\Usuario\\Downloads\\WinComClassEjem\\WinComClassEjem\\bin\\Debug\\EternalFlame_TheBangles.mp4");
            wmpVideo.URL = @"C:\\Users\\PC\\Downloads\\WinComClassEjem (2) (1)\\WinComClassEjem\\WinComClassEjem\\bin\\Debug\\EternalFlame_TheBangles.mp4";
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
           // webBrowser1.Navigate(txtURL.Text);
            webBrowser2.Navigate(txtURL.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser2.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser2.GoHome();
        }
    }
}
