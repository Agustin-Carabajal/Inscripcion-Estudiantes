using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entities;

namespace clases
{
    public partial class Inscripciones : Form
    {
       
        public Inscripciones()
        {
            InitializeComponent();
            CargarComboBox(cbMaterias);
            CargarComboBox(cbSeleccionMat);
           
        }

        private void btMostrarLista_Click(object sender, EventArgs e)
        {
            if (cbSeleccionMat.SelectedItem != null)
            {
                string tipoSeleccionado = cbSeleccionMat.SelectedItem.ToString();
                var logica = new ClaseLog();
                int materia_elegida = logica.Cbmateriaselegir(tipoSeleccionado);
                var estudiantes = logica.ObtenerEstudiantesInscriptos(materia_elegida);

                if (estudiantes.Count == 0)
                {
                    lblInscriptos.Text = "No hay estudiantes inscriptos a esta materia.";
                }
                else
                {
                    // Formatear la lista como texto
                    string texto = "Estudiantes inscriptos:\n";
                    foreach (var est in estudiantes)
                    {
                        texto += $"- {est.dniEst} - {est.nomEst}\n";
                    }
                    lblInscriptos.Text = texto;
                }
            }

        }

        private void btInscribirse_Click(object sender, EventArgs e)
        { 
            if (int.TryParse(txtDniEst.Text, out int dni) &&
                !string.IsNullOrWhiteSpace(txtNomEst.Text))
            {

                string tipoSeleccionado = cbMaterias.SelectedItem.ToString();

                ClaseLog logicaCb = new ClaseLog();

                int materia_elegida = logicaCb.Cbmateriaselegir(tipoSeleccionado);

                Estudiante est = new Estudiante()
                {
                    nomEst = txtNomEst.Text.Trim(),
                    dniEst = dni
                };

                var logicaMat = new ClaseLog();
                string resultado = logicaMat.InscribirSiCorresponde(est, materia_elegida);

                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Verifique que el DNI y nombre sean válidos.");
            }
        }

        public void CargarComboBox (ComboBox comboBox)
        {
            comboBox.Items.Clear();

            comboBox.Items.Add("Matemática(07:30:00)");
            comboBox.Items.Add("Biología(11:00:00)");
            comboBox.Items.Add("Lengua(09:30:00)");
            comboBox.Items.Add("Matemática(16:00:00)");
            comboBox.Items.Add("Programación(14:30:00)");
            comboBox.Items.Add("Economía(12:00:00)");
            comboBox.Items.Add("Física Cuántica(18:00:00)");
        }

        
        
    }
}
