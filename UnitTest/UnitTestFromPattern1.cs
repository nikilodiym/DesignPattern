using Pattern_1.Enemies;
using Pattern_1.Enums;
using Pattern_1.Factories;

namespace UnitTest
{
    [TestFixture]
    public class UnitTestFromPattern1
    {
        [Test]
        public void CreateZombie_HardDifficulty_CorrectStats()
        {
            var factory = new ZombieFactory();
            var zombie = (Zombie)factory.CreateEnemy(Difficulty.Hard);

            Assert.AreEqual(200, zombie.Health);
            Assert.AreEqual(20, zombie.Damage);
        }

        [Test]
        public void CreateSkeleton_EasyDifficulty_CorrectStats()
        {
            var factory = new SkeletonFactory();
            var skeleton = (Skeleton)factory.CreateEnemy(Difficulty.Easy);

            Assert.AreEqual(80, skeleton.Health);
            Assert.AreEqual(15, skeleton.Damage);
        }
    }
}