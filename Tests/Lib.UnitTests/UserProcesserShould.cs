using FluentAssertions;
using software_craftsmanship.DesignPatterns.Behavioral_Design_Patterns.ChainOfResponsiblity;
using software_craftsmanship.Lib.ChainOfResponsibility.Validation;
using Xunit;

namespace software_craftsmanship.Lib.UnitTests
{
    public class UserProcesserShould
    {
        private readonly UserProcessor _sut;

        public UserProcesserShould()
        {
            _sut = new UserProcessor();
        }

        [Fact]
        public void Return_True_When_User_Is_Valid()
        {
            var user = new User
            {
                Name = "Foo",
                Age = 27,
                Gender = "Non-Binary"
            };

            var result = _sut.Register(user);

            result.Should().BeTrue();
        }

        [Fact]
        public void Throw_Exception_If_Users_Age_Is_Less_Than_18()
        {
            var user = new User
            {
                Name = "Foo",
                Age = 16,
                Gender = "Non-Binary"
            };

            Assert.Throws<AgeValidationException>(() => _sut.Register(user));
        }

        [Fact]
        public void Throw_Exception_If_Users_Name_Length_Is_Less_Than_1()
        {
            var user = new User
            {
                Name = "F",
                Age = 18,
                Gender = "Non-Binary"
            };

            Assert.Throws<NameValidationaException>(() => _sut.Register(user));
        }
    }
}