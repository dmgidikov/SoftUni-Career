namespace Tests
{
    using Xunit;
    using System;
    using ExtendedDatabase;

    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase extendedDatabase;

        [Fact]
        public void AddShouldNotAddPersonIfNameAlreadyExist()
        {
            var pesho = new Person(1, "Pesho");

            this.extendedDatabase = new ExtendedDatabase(pesho);

            var anotherPesho = new Person(2, "Pesho");

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.extendedDatabase.Add(anotherPesho);
            });
        }

        [Fact]
        public void AddShouldNotAddPersonIfIdAlreadyExist()
        {
            var pesho = new Person(1, "Pesho");

            this.extendedDatabase = new ExtendedDatabase(pesho);

            var anotherPesho = new Person(1, "Gosho");

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.extendedDatabase.Add(anotherPesho);
            });
        }

        [Fact]
        public void FindByUsernameShouldThrowExceptionIfCantFindName()
        {
            var pesho = new Person(1, "Pesho");
            var lookForName = pesho.UserName;

            this.extendedDatabase = new ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() =>
            {
                var person = extendedDatabase.FindByUsername(lookForName);
            });
        }

        [Fact]
        public void FindByUsernameShouldThrowExceptionIfSearchingNameIsNull()
        {
            var pesho = new Person(1, "Pesho");
            string lookForName = null;

            this.extendedDatabase = new ExtendedDatabase(pesho);

            Assert.Throws<ArgumentNullException>(() =>
            {
                var person = extendedDatabase.FindByUsername(lookForName);
            });
        }

        [Fact]
        public void FindByUsernameShouldBeCaseSensitive()
        {
            var pesho = new Person(1, "Pesho");
            var lookForName = "PeShO";

            this.extendedDatabase = new ExtendedDatabase(pesho);

            Assert.Throws<InvalidOperationException>(() =>
            {
                var person = extendedDatabase.FindByUsername(lookForName);
            });
        }
    }
}