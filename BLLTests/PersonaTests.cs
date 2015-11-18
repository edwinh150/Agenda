using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Tests
{
    [TestClass()]
    public class PersonaTests
    {
        [TestMethod()]
        public void PersonaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AgregarTelefonoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PersonaTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Persona persona = new Persona();

            Assert.IsTrue(persona.Buscar(3));
        }

        [TestMethod()]
        public void EditarTest()
        {
            Persona persona = new Persona();

            persona.Nombre = "Edwin";
            persona.EstadoCivil = 1;
            Assert.IsTrue(persona.Editar());

            
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Persona persona = new Persona();

            persona.PersonaId = 1;

            Assert.IsTrue(persona.Eliminar());
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Persona persona = new Persona();

            persona.Nombre = "Edwin";
            persona.EstadoCivil = 1;
            Assert.IsTrue(persona.Insertar());

        }

        [TestMethod()]
        public void ListadoTest()
        {
            Persona persona = new Persona();

           Assert.IsTrue(persona.Listado(" * ", " 1=1 ", " ").Rows.Count == 1);

        }
    }
}