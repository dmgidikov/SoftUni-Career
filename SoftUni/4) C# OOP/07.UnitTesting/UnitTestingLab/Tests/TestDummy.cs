namespace Tests
{
    public class TestDummy
    {
        [Fact]
        public void DummyLoosesHelftIfAttacked()
        {
            var dummy = new Dummy(10, 100);

            dummy.TakeAttack(5);

            Assert.Equal(5, dummy.Health);
        }

        [Fact]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var dummy = new Dummy(0, 500);

                dummy.TakeAttack(5);
            });
        }

        [Fact]
        public void DeadDummyCanGiveExp()
        {
            var hero = new Hero("Gosho");
            var dummy = new Dummy(10, 500);

            hero.Attack(dummy);

            Assert.Equal(500, hero.Experience);
        }

        public void AliveDummyCannotGiveExp()
        {
            var hero = new Hero("Gosho");
            var dummy = new Dummy(20, 500);

            hero.Attack(dummy);

            Assert.Equal(0, hero.Experience);
        }
    }
}