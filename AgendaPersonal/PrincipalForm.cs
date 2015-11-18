using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaPersonal
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPersonaForm RegistroPersona = new RegistroPersonaForm();

            RegistroPersona.Show();
        }

        private void telefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroTelefonoForm RegistroTelefono = new RegistroTelefonoForm();

            RegistroTelefono.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarForm Consulta = new ConsultarForm();

            Consulta.Show();
        }
    }
}
