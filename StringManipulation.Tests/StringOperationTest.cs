using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;  //para que funcione Fact

namespace StringManipulation.Tests
{
    public class StringOperationTest //siempre las clases de prueba deben ser públicas
    {
        [Fact]
        public void ConcatenateStrings()
        {
            var strOperation = new StringOperations();
            var result = strOperation.ConcatenateStrings("Hello", "World");

            Assert.Equal("Hello World", result); //esperado, resultado
        }
    }
}
