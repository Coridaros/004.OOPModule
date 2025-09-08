using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void InitializeTests()
        {
            axe = new Axe(10, 50);
            dummy = new Dummy(30, 30);
        }

        [Test]
        public void DummyLoosesHealthAfterAttack()
        {
            dummy.TakeAttack(axe.AttackPoints);

            Assert.That(dummy.Health, Is.EqualTo(20));
        }

        [Test]
        public void DeathDummyThrowEx()
        {
            dummy.TakeAttack(10);
            dummy.TakeAttack(10);
            dummy.TakeAttack(10);

            Assert.That(() => dummy.TakeAttack(10), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveExp()
        {
            dummy.TakeAttack(10);
            dummy.TakeAttack(10);
            dummy.TakeAttack(10);

            Assert.That(dummy.GiveExperience(), Is.EqualTo(30));
        }

        [Test]
        public void AliveDummyCannotGiveExp()
        {
            Assert.That(() => dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
        }
    }
}