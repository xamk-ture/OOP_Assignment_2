using OOP_Assignment_2;

namespace AssignmentTests
{
    public class AssignmentTests
    {
        [Fact]
        public void Pet_Creation_WithValidData()
        {
            //// Arrange
            //string expectedName = "Max";
            //int expectedAge = 5;
            //string expectedSpecies = "Dog";

            //// Act
            //Pet pet = new Pet(expectedName, expectedAge, expectedSpecies);

            //// Assert
            //Assert.Equal(expectedName, pet.Name);
            //Assert.Equal(expectedAge, pet.Age);
            //Assert.Equal(expectedSpecies, pet.Species);
        }

        [Fact]
        public void Dog_ShouldInheritFromPet()
        {
            //Dog dog = new Dog("Buddy", 3, "test");
            //Assert.True(dog is Pet);
        }

        [Fact]
        public void Cat_ShouldInheritFromPet()
        {
            //Cat cat = new Cat("Whiskers", 2, "test");
            //Assert.True(cat is Pet);
        }

        [Fact]
        public void PetList_ShouldHandleDifferentTypes()
        {
            // Arrange
            //var pets = new List<Pet> { new Dog("Buddy", 3, "test"), new Cat("Whiskers", 2, "test") };

            //// Act & Assert
            //foreach (var pet in pets)
            //{
            //    if (pet is Dog)
            //    {
            //        Assert.IsType<Dog>(pet);
            //    }
            //    else if (pet is Cat)
            //    {
            //        Assert.IsType<Cat>(pet);
            //    }
            //}
        }
    }

    public class InterfaceImplementationTests
    {
        //[Fact]
        //public void Dog_ShouldImplementIVocalizeInterface()
        //{
        //    // Arrange
        //    Dog dog = new Dog("Buddy", 3, "test");

        //    // Act & Assert
        //    Assert.IsAssignableFrom<IVocalize>(dog);
        //}

        //[Fact]
        //public void Cat_ShouldImplementIVocalizeInterface()
        //{
        //    // Arrange
        //    Cat cat = new Cat("Whiskers", 2, "test");

        //    // Act & Assert
        //    Assert.IsAssignableFrom<IVocalize>(cat);
        //}
    }

    public class VocalizeTests
    {
        //[Fact]
        //public void Dog_ShouldImplementIVocalizeAndBark()
        //{
        //    // Arrange
        //    Dog dog = new Dog("Buddy", 3, "test");
        //    string expectedSound = "Bark!";

        //    // Act
        //    string actualSound = RecordSound(dog);

        //    // Assert
        //    Assert.Equal(expectedSound, actualSound);
        //}

        //[Fact]
        //public void Cat_ShouldImplementIVocalizeAndMeow()
        //{
        //    // Arrange
        //    Cat cat = new Cat("Whiskers", 2, "test");
        //    string expectedSound = "Meow!";

        //    // Act
        //    string actualSound = RecordSound(cat);

        //    // Assert
        //    Assert.Equal(expectedSound, actualSound);
        //}

        //private string RecordSound(IVocalize animal)
        //{
        //    using (var sw = new StringWriter())
        //    {
        //        Console.SetOut(sw);
        //        animal.MakeSound();

        //        return sw.ToString().Trim();
        //    }
        //}
    }
}
