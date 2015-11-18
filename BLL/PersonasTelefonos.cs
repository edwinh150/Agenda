using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class PersonasTelefonos : ClaseMaestra
    {
        public int Id { get; set; }

        public string Telefono { get; set; }

        public PersonasTelefonos()
        {
            this.Id = 0;
            this.Telefono = "";
        }

        public PersonasTelefonos(int Id, string TelefonoNumero)
        {
            this.Id = Id;
            this.Telefono = TelefonoNumero;
        }

        ConexionDb con = new ConexionDb();
           
        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = con.ObtenerDatos(string.Format("Select * from PersonasTelefonos where Id = {0} ", this.Id));
            }
            catch (Exception ex)
            {

                throw ex;
            }           

            if (dt.Rows.Count > 0)
            {
                this.Telefono = dt.Rows[0]["Telefono"].ToString();
            }

            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;

            try
            {
                con.Ejecutar(string.Format("update set PersonasTelefonos Telefono = '{0}' where Id = {1} ", this.Telefono, this.Id));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            try
            {
                con.Ejecutar(string.Format("Delete from PersonasTelefonos where Id = {0}", this.Id));
            }
            catch (Exception ex)
            {

                throw ex;
            }          

            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            try
            {
                con.Ejecutar(string.Format("insert into PersonasTelefonos (Telefono) values('{0}') ", this.Telefono));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            DataTable dt = new DataTable();
            /*
            try
            {
                dt = con.ObtenerDatos(string.Format("Select " + Campos + " From PersonasTelefonos where " + Condicion + " " + Orden));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            */

            return dt;
        }
    }
}
