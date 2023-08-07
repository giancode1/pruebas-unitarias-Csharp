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
        //para omitir prueba:
        [Fact(Skip = "Esta prueba no es valida en este momento, TICKET-001")]
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
        [Fact]
        public void QuantintyInWords() 
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.QuantintyInWords("gato", 10);

            //Assert
            Assert.StartsWith("diez", result);   //MI VISUAL STUDIO ESTA EN ESPAÑOL
            Assert.Contains("gato", result);
            Assert.Equal("diez gatos", result);
        }

        [Fact]
        public void GetStringLength()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.GetStringLength("hola");

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void GetStringLength_Exception() //voy a comprobar que de una excepcion
        {
            //Arrange
            var strOperations = new StringOperations();

            //Assert
            Assert.ThrowsAny<ArgumentNullException>(()=>strOperations.GetStringLength(null));
        }

        [Fact]
        public void TruncateString_Exception()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Assert
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => strOperations.TruncateString("hola",0));
        }

        //Atributos Theory e InlineData
        [Theory]
        [InlineData("V", 5)]
        [InlineData("III", 3)]
        [InlineData("X", 10)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var strOperations = new StringOperations();

            var result = strOperations.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("oro", true)]
        [InlineData("palindromo", false)]
        public void IsPalindrome(string word, bool expected)
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome(word);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}
