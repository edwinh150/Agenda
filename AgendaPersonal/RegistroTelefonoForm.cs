using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace AgendaPersonal
{
    public partial class RegistroTelefonoForm : Form
    {
        PersonasTelefonos Telefono = new PersonasTelefonos();

        public RegistroTelefonoForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            TelefonoIdtextBox.Clear();

            TelefonotextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            TelefonoIdtextBox.Clear();

            TelefonotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (TelefonoIdtextBox.Text.Length > 0)
            {
                Telefono.Id = Convert.ToInt32(TelefonoIdtextBox.Text);

                Telefono.Telefono = TelefonotextBox.Text;

                if (Telefono.Editar())
                {
                    MessageBox.Show("Se edito correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se edito");
                }
            }
            else
            {
                Telefono.Telefono = TelefonotextBox.Text;

                if (Telefono.Insertar())
                {
                    MessageBox.Show("Se guardo Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se guardo");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Telefono.Id = Convert.ToInt32(TelefonoIdtextBox.Text);

            if (Telefono.Eliminar())
            {
                MessageBox.Show("Se elimino correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se elimino");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (TelefonoIdtextBox.Text.Length > 0)
            {
                int Id = Convert.ToInt32(TelefonoIdtextBox.Text);

                if (Telefono.Buscar(Id))
                {
                    TelefonotextBox.Text = Telefono.Telefono;
                }
                else
                {
                    MessageBox.Show("Error al buscar Id");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Id primero");
            }
        }
    }
}
