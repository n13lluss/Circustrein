using CircusTrainLibrary;

namespace CircusTrainTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Senario1()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");

            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");

            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");

            train.AddAnimalsToWagons();
            //act
            int wagonCount = train.wagons.Count();
            //assert
            Assert.That(wagonCount, Is.EqualTo(2));

        }

        [Test]
        public void Senario2()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");

            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");

            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");

            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();
            //act
            int wagonCount = train.wagons.Count();
            //assert
            Assert.That(wagonCount, Is.EqualTo(2));
        }

        [Test]
        public void Senario3()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");

            train.AddAnimal("meat", "medium");

            train.AddAnimal("meat", "large");

            train.AddAnimal("plant", "small");

            train.AddAnimal("plant", "medium");

            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();
            //act
            int wagonCount = train.wagons.Count();
            //assert
            Assert.That(wagonCount, Is.EqualTo(4));
        }

        [Test]
        public void Senario4()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");

            train.AddAnimal("meat", "medium");

            train.AddAnimal("meat", "large");

            train.AddAnimal("plant", "small");

            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");

            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();
            //act
            int wagonCount = train.wagons.Count();
            //assert
            Assert.That(wagonCount, Is.EqualTo(5));
        }

        [Test]
        public void Senario5()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");

            train.AddAnimal("plant", "small");

            train.AddAnimal("plant", "medium");

            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();
            //act
            int wagonCount = train.wagons.Count();
            //assert
            Assert.That(wagonCount, Is.EqualTo(2));
        }

        [Test]
        public void Senario6()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");

            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");

            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();

            //act
            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(3));
        }

        [Test]
        public void Senario7()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");

            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");

            train.AddAnimal("meat", "large");
            train.AddAnimal("meat", "large");
            train.AddAnimal("meat", "large");

            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");

            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();
            //act
            int wagonCount = train.wagons.Count();
            //assert
            Assert.That(wagonCount, Is.EqualTo(13));
        }

        [Test]
        public void Senario8()
        {
            //arrange
            Train train = new();

            train.AddAnimalsToWagons();

            //act
            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(0));
        }

        [Test]
        public void Senario9()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");

            train.AddAnimalsToWagons();

            //act
            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(3)); // Expect 3 wagons because medium-sized meat-eaters can't be in the same cart.
        }

        [Test]
        public void Senario10()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");

            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();

            //act
            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(6));
        }

        [Test]
        public void Senario11()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "large");

            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");

            //act
            train.AddAnimalsToWagons(); // Sort the animals within wagons.

            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(3)); // Expect 3 wagons (one for meat-eaters, one for medium plant-eaters).
        }

        [Test]
        public void Senario12()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "large");

            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");

            train.AddAnimalsToWagons();

            //act

            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(5)); // Expect 5 wagons (one for meat-eaters, four for medium plant-eaters).
        }

        [Test]
        public void Senario13()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "large");

            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");

            train.AddAnimalsToWagons();

            //act

            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(7)); // Expect 4 wagons (one for meat-eaters, three for medium plant-eaters).
        }

        [Test]
        public void Senario14()
        {
            Train train = new();

            // Meat options
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "large");
            train.AddAnimal("meat", "large");
            train.AddAnimal("meat", "large");
            train.AddAnimal("meat", "large");

            // Plant options (50 in total)
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");
            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();

            //act

            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(20)); // Expect 4 wagons (one for meat-eaters, three for medium plant-eaters).
        }

        [Test]
        public void Senario15()
        {
            //arrange
            Train train = new();

            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "small");
            train.AddAnimal("meat", "medium");
            train.AddAnimal("meat", "large");

            train.AddAnimal("plant", "small");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "medium");
            train.AddAnimal("plant", "large");

            train.AddAnimalsToWagons();

            //act

            int wagonCount = train.wagons.Count();

            //assert
            Assert.That(wagonCount, Is.EqualTo(6)); // Expect 4 wagons (one for meat-eaters, three for medium plant-eaters).
        }

    }
}