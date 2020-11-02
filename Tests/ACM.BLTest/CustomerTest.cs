using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //arrange
            Customer customer = new Customer
            {
                FirstName = "Lukas",
                LastName = "Saylor"
            };
            string expected = "Saylor, Lukas";
            //act
            string actual = customer.FullName;
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //arrange
            Customer customer = new Customer
            {

                LastName = "Saylor"
            };
            string expected = "Saylor";
            //act
            string actual = customer.FullName;
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //arrange
            Customer customer = new Customer
            {
                FirstName = "Lukas",

            };
            string expected = "Lukas";
            //act
            string actual = customer.FullName;
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            //arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //Act

            //assert

            Assert.Equal(3, Customer.InstanceCount);

        }
    }
}
