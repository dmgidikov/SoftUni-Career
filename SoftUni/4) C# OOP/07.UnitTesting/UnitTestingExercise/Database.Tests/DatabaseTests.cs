namespace Tests
{
    using Xunit;
    using System;
    using Database;

    public class DatabaseTests
    {
        private Database database;
        private readonly int[] initialData = { 1, 2, 3 };

        [Fact]
        public void Setup()
        {
            this.database = new Database();
        }

        [Fact]
        public void TestIfConstructorWorksCorrectly()
        {
            var data = new int[] { 1, 2, };
            this.database = new Database(data);

            var expectedCount = data.Length;
            var actulaCount = this.database.Count;

            Assert.Equal(expectedCount, actulaCount);
        }

        [Fact]
        public void ConstructorShouldThrowExceptionIfBiggerParameter()
        {
            var data = new int[18];

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database = new Database(data);
            });
        }

        [Fact]
        public void AddShouldIncreaseCountOfDB()
        {
            this.database = new Database(new int[2]);

            var randomInt = 5;
            database.Add(randomInt);

            var expectedCount = 3;
            var actualCount = database.Count;

            Assert.Equal(expectedCount,actualCount);
        }

        [Fact]
        public void RemoveShouldDecreaseCountOfDb()
        {
            this.database = new Database(this.initialData);

            var expectedCount = database.Count - 1;

            this.database.Remove();

            var actualCount = this.database.Count;

            Assert.Equal(expectedCount, actualCount);
        }
    }
}