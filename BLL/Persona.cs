using System.Data;
using DAL;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class Persona : ClaseMaestra
    {
        public int PersonaId { get; set; }

        public string Nombre { get; set; }

        public int EstadoCivil { get; set; }

        //public List<PersonasTelefonos> Telefono { get; set; }

        ConexionDb con = new ConexionDb();

        public Persona()
        {
            this.PersonaId = 0;
            this.Nombre = "";
            this.EstadoCivil = 0;
            //Telefono = new List<PersonasTelefonos>();
        }

        /*public void AgregarTelefono(int Id, string TelefonoParametro)
        {
            Telefono.Add(new PersonasTelefonos(Id, TelefonoParametro));
        }
        */

        public Persona(int PersonaId, string Nombre, int EstadoCivil)
        {
            this.PersonaId = PersonaId;
            this.Nombre = Nombre;
            this.EstadoCivil = EstadoCivil;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            try
            {
                dt = con.ObtenerDatos(string.Format("Select * from Personas where PersonaId = {0} ", IdBuscado));
                //dt2 = con.ObtenerDatos(string.Format("Select p.PersonaId,pt.Telefono from Personas p inner join PersonasTelefonos pt on p.PersonaId = pt.PersonaId where PersonaId = {0} ", this.PersonaId)); 
            }
            catch (Exception ex)
            {

                throw ex;
            }         
            
            if (dt.Rows.Count > 0)
            {
                this.Nombre = dt.Rows[0]["Nombres"].ToString();
                this.EstadoCivil = (int)dt.Rows[0]["EstadoCivil"];
                /*for (int x=0; x < dt2.Rows.Count; x++)
                {
                    AgregarTelefono((int)dt2.Rows[x]["PersonaId"], dt2.Rows[x]["Telefono"].ToString());
                }
                */
            }
            

            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;

            try
            {
                retorno = con.Ejecutar(string.Format("update Personas set Nombres = '{0}' , EstadoCivil = {1} where PersonaId = {2} ", this.Nombre, this.EstadoCivil, this.PersonaId));
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
                retorno = con.Ejecutar(string.Format("Delete from Personas where PersonaId = {0} ", this.PersonaId));
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
                retorno = con.Ejecutar(string.Format("insert into Personas (Nombres,EstadoCivil) values ('{0}',{1}) ", this.Nombre, this.EstadoCivil));           
                
            }
            catch (Exception ex)
            {

                throw ex;
            }           
            
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            return con.ObtenerDatos("select " + Campos + " from Personas where " + Condicion + " " + Orden);
        }
    }
}
