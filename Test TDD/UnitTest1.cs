namespace Test_TDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificarExistenciaDeVasosPequeños()
        {
            // ESTE METODO DEVUELVE UN BOOLEANO, VEFIFICA QUE LA CANTIDAD INGRESADA
            // ESTE DISPONIBLE PARA COMPLETAR LA SOLITUD DEL USUARIO, SI LA CANTIDAD
            // DE VASOS SOBREPASA LA SOLICITUD O LA CANTIDAD DE EXISTENCIA ES O, PUES
            // RETORNARA UN FALSE.
            bool result = Proyecto_Final_ADM.Clases.Repositorio.HasGiveVasoPequeno(4);
   
            // METODO QUE COMPRUEBA QUE EL RESULTADO RETORNADO POR EL METODO ES IGUAL
            // A VERDADERO.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void VerificarExistenciaDeVasosMedianos()
        {
            // ESTE METODO DEVUELVE UN BOOLEANO, VEFIFICA QUE LA CANTIDAD INGRESADA
            // ESTE DISPONIBLE PARA COMPLETAR LA SOLITUD DEL USUARIO, SI LA CANTIDAD
            // DE VASOS SOBREPASA LA SOLICITUD O LA CANTIDAD DE EXISTENCIA ES O, PUES
            // RETORNARA UN FALSE.
            bool result = Proyecto_Final_ADM.Clases.Repositorio.HasGiveVasoMediano(2);

            // METODO QUE COMPRUEBA QUE EL RESULTADO RETORNADO POR EL METODO ES IGUAL
            // A VERDADERO.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void VerificarExistenciaDeVasosGrandes()
        {
            // ESTE METODO DEVUELVE UN BOOLEANO, VEFIFICA QUE LA CANTIDAD INGRESADA
            // ESTE DISPONIBLE PARA COMPLETAR LA SOLITUD DEL USUARIO, SI LA CANTIDAD
            // DE VASOS SOBREPASA LA SOLICITUD O LA CANTIDAD DE EXISTENCIA ES O, PUES
            // RETORNARA UN FALSE.
            bool result = Proyecto_Final_ADM.Clases.Repositorio.HasGiveVasoGrande(7);

            // METODO QUE COMPRUEBA QUE EL RESULTADO RETORNADO POR EL METODO ES IGUAL
            // A VERDADERO.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void VerificarExistenciaDeAzucar()
        {
            // SE INGRESAN POR PARAMETRO EL PRIMER VALOR QUE CORRESPONDE A LA CANTIDAD
            // DE CUCHARADAS DE AZUCAR Y EL SEGUN PARAMETRO SE REFIERE A LA CANTIDAD DE 
            // VASOS, RESTARA LA CANTIDAD DE CUCHARADAS AL AZUCAR Y, SI SE CUMPLE EL PROCESO
            // DEVOLVERA UN STRING DICIENDO "RECOGE EL VASO".
            string result = Proyecto_Final_ADM.Clases.Repositorio.CantidadAzucar(5,2);

            // RESULTADO ESPERADO.
            Assert.AreEqual("Recoge el vaso", result);
        }

        [TestMethod]
        public void VerificarExistenciaDeCafe()
        {
            // SE INGRESA EL VALOR DE LA CUCHARADAS DE CAFE, LUEGO REALIZA LAS OPERACIONES
            // CORRESPONDIENTES INCLUYENDO LA RESTA DE LAS CUCHARADAS A LA CANTIDAD TOTAL
            // DE CAFE, SI SE CUMPLE RETORNARA UN VALOR VERDADERO, DE LO CONTRARIO SI SUPERA
            // EL LIMITE DE CUCHARADAS PUES LANZARA UN FALSE.
            bool result = Proyecto_Final_ADM.Clases.Repositorio.CantidadCafe(5);

            // METODO QUE COMPRUEBA QUE EL RESULTADO RETORNADO POR EL METODO ES IGUAL
            // A VERDADERO.
            Assert.IsTrue(result);
        }

    }
}