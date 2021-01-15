using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TiendaDeVideojuegos.Entidad;
using TiendaDeVideojuegos.Negocios;

namespace TiendaDeVideojuegosTest
{
    [TestClass]
    public class TiendaTests
    {
        [TestMethod]
        public void RegistrarProveedorTest()
        {
            String ruc = "2";
            String nombre = "Oracle";

            var Negocios = new ClsNProveedores();
            var Entidad = new ClsEProveedores() { rucprov = ruc, nomprov = nombre };

            var resultadoFinal = Negocios.MtdAgregarProveedor(Entidad);

            Assert.IsTrue(resultadoFinal);
        }

        [TestMethod]
        public void ActualizarProveedorTest()
        {
            String ruc = "1";
            String nombre = "Microsoft";

            var Negocios = new ClsNProveedores();
            var Entidad = new ClsEProveedores() { rucprov = ruc, nomprov = nombre };

            var resultadoFinal = Negocios.MtdActualizarProveedor(Entidad);

            Assert.IsTrue(resultadoFinal);
        }

        [TestMethod]
        public void RegistrarEmpleadoTest()
        {
            String codigo = "1234";
            String nombre = "Anthony";
            String apellido = "Belizario";
            String clave = "12345678";
            String direccion = "Las gardenias";
            String estado = "Activo";

            var Negocios = new ClsNEmpleados();
            var Entidad = new ClsEEmpleados()
            {
                codemp = codigo,
                nomemp = nombre,
                apeemp = apellido,
                claemp = clave,
                diremp = direccion,
                estado = estado
            };
            var resultadoFinal = Negocios.MtdAgregarEmpleados(Entidad);
            Assert.IsTrue(resultadoFinal);
        }

        [TestMethod]
        public void ActualizarEmpleadoTest()
        {
            String codigo = "1234";
            String nombre = "Anthony";
            String apellido = "Belizario";
            String clave = "12345678";
            String direccion = "Las gardenias";
            String estado = "Inactivo";

            var Negocios = new ClsNEmpleados();
            var Entidad = new ClsEEmpleados()
            {
                codemp = codigo,
                nomemp = nombre,
                apeemp = apellido,
                claemp = clave,
                diremp = direccion,
                estado = estado
            };
            var resultadoFinal = Negocios.MtdActualizarEmpleados(Entidad);
            Assert.IsTrue(resultadoFinal);
        }

        [TestMethod]
        public void RegistrarGeneroTest()
        {
            String codigo = "2";
            String nombre = "Accion";

            var Negocios = new ClsNGenero();
            var Entidad = new ClsEGenero()
            {
                codgen = codigo,
                nomgen = nombre
            };
            var resultadoFinal = Negocios.MtdAgregarGenero(Entidad);
            Assert.IsTrue(resultadoFinal);
        }

        [TestMethod]
        public void ActualizarGeneroTest()
        {
            String codigo = "1";
            String nombre = "Terror";

            var Negocios = new ClsNGenero();
            var Entidad = new ClsEGenero()
            {
                codgen = codigo,
                nomgen = nombre
            };
            var resultadoFinal = Negocios.MtdActualizarGenero(Entidad);
            Assert.IsTrue(resultadoFinal);
        }

        [TestMethod]
        public void RegistrarPlataformaTest()
        {
            String codigo = "2";
            String nombre = "PS4";

            var Negocios = new ClsNPlataforma();
            var Entidad = new ClsEPlataforma()
            {
                codplat = codigo,
                nomplat = nombre
            };
            var resultadoFinal = Negocios.MtdAgregarPlataforma(Entidad);
            Assert.IsTrue(resultadoFinal);
        }

        [TestMethod]
        public void ActualizarPlataformaTest()
        {
            String codigo = "1";
            String nombre = "PS5";

            var Negocios = new ClsNPlataforma();
            var Entidad = new ClsEPlataforma()
            {
                codplat = codigo,
                nomplat = nombre
            };
            var resultadoFinal = Negocios.MtdActualizarPlataforma(Entidad);
            Assert.IsTrue(resultadoFinal);
        }

        [TestMethod]
        public void RegistrarProductosTest()
        {
            String codigo = "1";
            String nombre = "PS5";
            int cantidad = 10;
            double precio = 10;
            String codigoplataforma = "2";
            String codigogenero = "1";

            var Negocios = new ClsNProductos();
            var Entidad = new ClsEProductos()
            {
                codprod = codigo,
                nomprod = nombre,
                cantprod = cantidad,
                preprod = precio,
                codplat = codigoplataforma,
                codgen = codigogenero

            };
            var resultadoFinal = Negocios.MtdAgregarProductos(Entidad);
            Assert.IsTrue(resultadoFinal);
        }
    }
}
