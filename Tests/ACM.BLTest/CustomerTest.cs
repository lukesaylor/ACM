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
            string expected = "Saylor,Lukas";
            //act
            string actual = customer.FullName;
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
