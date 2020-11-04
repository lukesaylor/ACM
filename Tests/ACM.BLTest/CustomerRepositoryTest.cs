﻿using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            //act
            var actual = customerRepository.Retrieve(1);
            //assert
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FullName, actual.FullName);
            
        }

         
    }
}
