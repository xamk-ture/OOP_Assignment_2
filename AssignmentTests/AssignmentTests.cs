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
            //Dog dog = new Dog("Buddy", 3);
            //Assert.True(dog is Pet);
        }

        [Fact]
        public void Cat_ShouldInheritFromPet()
        {
            //Cat cat = new Cat("Whiskers", 2);
            //Assert.True(cat is Pet);
        }

        [Fact]
        public void PetList_ShouldHandleDifferentTypes()
        {
            // Arrange
            //var pets = new List<Pet> { new Dog("Buddy", 3), new Cat("Whiskers", 2) };

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
}