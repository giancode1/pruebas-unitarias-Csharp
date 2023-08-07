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
            //Arrange
            var strOperations = new StringOperations();
            
            //Act
            var result = strOperations.ConcatenateStrings("Hello", "World");

            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello World", result); //esperado, resultado
        }

        [Fact]
        public void IsPalindrome_True()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("ama");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("hola");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.RemoveWhitespace("hola, mundo querido ");

            //Assert
            Assert.Equal("hola,mundoquerido", result);
        }
        
    }
}
