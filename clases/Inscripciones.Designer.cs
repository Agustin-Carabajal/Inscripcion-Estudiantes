namespace clases
{
    partial class Inscripciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDniEst = new System.Windows.Forms.Label();
            this.txtDniEst = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.btInscribirse = new System.Windows.Forms.Button();
            this.lblListIns = new System.Windows.Forms.Label();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.cbSeleccionMat = new System.Windows.Forms.ComboBox();
            this.lblSelecMat = new System.Windows.Forms.Label();
            this.lblInscriptos = new System.Windows.Forms.Label();
            this.btMostrarLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomEst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDniEst
            // 
            this.lblDniEst.AutoSize = true;
            this.lblDniEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniEst.Location = new System.Drawing.Point(49, 73);
            this.lblDniEst.Name = "lblDniEst";
            this.lblDniEst.Size = new System.Drawing.Size(179, 25);
            this.lblDniEst.TabIndex = 0;
            this.lblDniEst.Text = "DNI del Estudiante:";
            // 
            // txtDniEst
            // 
            this.txtDniEst.Location = new System.Drawing.Point(234, 79);
            this.txtDniEst.Name = "txtDniEst";
            this.txtDniEst.Size = new System.Drawing.Size(128, 20);
            this.txtDniEst.TabIndex = 1;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(394, 73);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(171, 25);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia a Inscribir:";
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(571, 77);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(184, 21);
            this.cbMaterias.TabIndex = 3;
            // 
            // btInscribirse
            // 
            this.btInscribirse.Location = new System.Drawing.Point(438, 125);
            this.btInscribirse.Name = "btInscribirse";
            this.btInscribirse.Size = new System.Drawing.Size(108, 35);
            this.btInscribirse.TabIndex = 4;
            this.btInscribirse.Text = "Inscribirse";
            this.btInscribirse.UseVisualStyleBackColor = true;
            this.btInscribirse.Click += new System.EventHandler(this.btInscribirse_Click);
            // 
            // lblListIns
            // 
            this.lblListIns.AutoSize = true;
            this.lblListIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListIns.Location = new System.Drawing.Point(282, 197);
            this.lblListIns.Name = "lblListIns";
            this.lblListIns.Size = new System.Drawing.Size(234, 31);
            this.lblListIns.TabIndex = 5;
            this.lblListIns.Text = "Lista de Inscriptos";
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripcion.Location = new System.Drawing.Point(321, 20);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(145, 31);
            this.lblInscripcion.TabIndex = 6;
            this.lblInscripcion.Text = "Inscripción";
            // 
            // cbSeleccionMat
            // 
            this.cbSeleccionMat.FormattingEnabled = true;
            this.cbSeleccionMat.Location = new System.Drawing.Point(12, 307);
            this.cbSeleccionMat.Name = "cbSeleccionMat";
            this.cbSeleccionMat.Size = new System.Drawing.Size(184, 21);
            this.cbSeleccionMat.TabIndex = 8;
            // 
            // lblSelecMat
            // 
            this.lblSelecMat.AutoSize = true;
            this.lblSelecMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecMat.Location = new System.Drawing.Point(12, 269);
            this.lblSelecMat.Name = "lblSelecMat";
            this.lblSelecMat.Size = new System.Drawing.Size(205, 25);
            this.lblSelecMat.TabIndex = 7;
            this.lblSelecMat.Text = "Seleccione la Materia:";
            // 
            // lblInscriptos
            // 
            this.lblInscriptos.AutoSize = true;
            this.lblInscriptos.Location = new System.Drawing.Point(476, 281);
            this.lblInscriptos.Name = "lblInscriptos";
            this.lblInscriptos.Size = new System.Drawing.Size(99, 13);
            this.lblInscriptos.TabIndex = 9;
            this.lblInscriptos.Text = "Lista inscriptos aqui";
            // 
            // btMostrarLista
            // 
            this.btMostrarLista.Location = new System.Drawing.Point(234, 331);
            this.btMostrarLista.Name = "btMostrarLista";
            this.btMostrarLista.Size = new System.Drawing.Size(117, 30);
            this.btMostrarLista.TabIndex = 10;
            this.btMostrarLista.Text = "Ver Lista";
            this.btMostrarLista.UseVisualStyleBackColor = true;
            this.btMostrarLista.Click += new System.EventHandler(this.btMostrarLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre del Estudiante:";
            // 
            // txtNomEst
            // 
            this.txtNomEst.Location = new System.Drawing.Point(273, 132);
            this.txtNomEst.Name = "txtNomEst";
            this.txtNomEst.Size = new System.Drawing.Size(128, 20);
            this.txtNomEst.TabIndex = 12;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomEst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMostrarLista);
            this.Controls.Add(this.lblInscriptos);
            this.Controls.Add(this.cbSeleccionMat);
            this.Controls.Add(this.lblSelecMat);
            this.Controls.Add(this.lblInscripcion);
            this.Controls.Add(this.lblListIns);
            this.Controls.Add(this.btInscribirse);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.txtDniEst);
            this.Controls.Add(this.lblDniEst);
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDniEst;
        private System.Windows.Forms.TextBox txtDniEst;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.Button btInscribirse;
        private System.Windows.Forms.Label lblListIns;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.ComboBox cbSeleccionMat;
        private System.Windows.Forms.Label lblSelecMat;
        private System.Windows.Forms.Label lblInscriptos;
        private System.Windows.Forms.Button btMostrarLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomEst;
    }
}

