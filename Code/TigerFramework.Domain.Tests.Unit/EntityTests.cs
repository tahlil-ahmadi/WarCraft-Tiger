using System;
using FluentAssertions;
using Xunit;

namespace TigerFramework.Domain.Tests.Unit
{
    public class EntityTests
    {
        [Fact]
        public void Two_entities_with_same_id_should_be_equal()
        {
            var firstCustomer = new Customer(1);
            var secondCustomer = new Customer(1);

            var result = firstCustomer.Equals(secondCustomer);

            result.Should().Be(true);
        }

        [Fact]
        public void Two_entities_with_different_ids_should_not_be_equal()
        {
            var firstCustomer = new Customer(1);
            var secondCustomer = new Customer(2);

            var result = firstCustomer.Equals(secondCustomer);

            result.Should().Be(false);
        }

        [Fact]
        public void Two_entities_with_different_type_and_same_id_should_not_be_equal()
        {
            var customer = new Customer(1);
            var department = new Department(1);

            var result = customer.Equals(department);

            result.Should().Be(false);
        }

        [Fact]
        public void Two_entities_with_same_id_should_be_generate_same_hash_code()
        {
            var firstHashCode = new Customer(1).GetHashCode();
            var secondHashCode = new Customer(1).GetHashCode();

            firstHashCode.Should().Be(secondHashCode);
        }
        [Fact]
        public void Two_entities_with_different_ids_should_generate_different_hash_codes()
        {
            var firstHashCode = new Customer(1).GetHashCode();
            var secondHashCode = new Customer(2).GetHashCode();

            firstHashCode.Should().NotBe(secondHashCode);
        }

        #region TestHelpers
        private class Customer : Entity<long>
        {
            public Customer(long id)
            {
                this.Id = id;
            }
        }
        private class Department : Entity<long>
        {
            public Department(long id)
            {
                this.Id = id;
            }
        }
        #endregion
    }
}
