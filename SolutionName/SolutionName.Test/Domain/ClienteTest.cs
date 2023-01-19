using SolutionName.Domain.Entities;
using SolutionName.Domain.Shared;

namespace SolutionName.Test.Domain
{
    public class ClienteTest
    {
        [Fact]
        public void Cliente_Validate_Title_Lenght()
        {
            //Arrange & Act
            var result = Assert.Throws<DomainException>(() => new Cliente(
                 "Lucas Fulano de Tal sadfsaf asdfafa dsafsfs dsfdsafsad sadfasdfasd asdfasdfsad asdfasdf asdfas sdfasfdasf dsafasdfdsafas sadfsafasd ",
                 "emailexemplo@gmail.com",
                 1.1M));

            //Assert
            Assert.Equal("O nome deve ter até 60 caracteres!", result.Message);
        }

        [Fact]
        public void Cliente_Validate_Email_Lenght()
        {
            //Arrange & Act
            var result = Assert.Throws<DomainException>(() => new Cliente(
                 "Lucas Fulano de Tal",
                 "emailexemplo@gmail.com asdfsafa asdfsafsaf dsafsadfd asdfsafsad dasdfdas asdfdsafsdaf asdfasdfsad 111 cartacter",
                 1.1M));

            //Assert
            Assert.Equal("O email deve ter até 100 caracteres!", result.Message);
        }


        [Fact]
        public void Cliente_Validate_MultiplicadorBase_Zero()
        {
            //Arrange & Act
            var result = Assert.Throws<DomainException>(() => new Cliente(
                 "Lucas Fulano de Tal",
                 "emailexemplo@gmail.com",
                 0));

            //Assert
            Assert.Equal("O multiplicadorBase deve ser maior que 0", result.Message);
        }

        [Fact]
        public void Cliente_Validate_MultiplicadorBase_Negative()
        {
            //Arrange & Act
            var result = Assert.Throws<DomainException>(() => new Cliente(
                 "Lucas Fulano de Tal",
                 "emailexemplo@gmail.com",
                 -1.1M));

            //Assert
            Assert.Equal("O multiplicadorBase deve ser maior que 0", result.Message);
        }


    }
}