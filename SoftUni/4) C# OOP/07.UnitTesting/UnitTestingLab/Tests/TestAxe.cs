namespace Tests
{
    public class TestAxe
    {
        [Fact]
        public void TestIfWeaponLoosesDurabilityAfterAttack()
        {
            var weapon = new Axe(10, 10);
            var dummy = new Dummy(10, 20);

            weapon.Attack(dummy);

            Assert.Equal(9, weapon.DurabilityPoints);
        }

        [Fact]
        public void TestAttackingWithBrokenWeapon()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var weapon = new Axe(10, 0);
                var dummy = new Dummy(10, 20);

                weapon.Attack(dummy);
            });
        }
    }
}