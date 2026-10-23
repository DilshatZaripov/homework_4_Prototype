using homework_4_Prototype.Models;

namespace homework_4_Prototype.Tests
{
    public class CoatTest
    {
        [Fact]
        public void Clone_ShouldCreateDeepCopy_WhenUsingCustomInterface()
        {
            var originalCoat = new Coat(
                14, "Demi-Season Coat",
                "Torso",
                ["Cashemire"],
                "Lemon Yellow");

            var cloneCoat = originalCoat.Clone();

            Assert.NotSame(originalCoat, cloneCoat);

            Assert.Equal(originalCoat.Id, cloneCoat.Id);
            Assert.Equal(originalCoat.Name, cloneCoat.Name);
            Assert.Equal(originalCoat.BodyPart, cloneCoat.BodyPart);
            Assert.Equal(originalCoat.Materials, cloneCoat.Materials);
            Assert.Equal(originalCoat.Color, cloneCoat.Color);

            cloneCoat.Materials.Add("Cotton");

            Assert.Equal(originalCoat.Materials.Count, cloneCoat.Materials.Count);
            Assert.Equal(originalCoat.Materials, cloneCoat.Materials);
        }

        [Fact]
        public void Clone_ShouldCreateDeepCopy_WhenUsingSystemInterface()
        {
            var originalCoat = new Coat(
                14, "Demi-Season Coat",
                "Torso",
                ["Cashemire"],
                "Lemon Yellow");

            var cloneCoat = (Coat)((ICloneable)originalCoat).Clone();

            Assert.NotSame(originalCoat, cloneCoat);

            Assert.Equal(originalCoat.Id, cloneCoat.Id);
            Assert.Equal(originalCoat.Name, cloneCoat.Name);
            Assert.Equal(originalCoat.BodyPart, cloneCoat.BodyPart);
            Assert.Equal(originalCoat.Materials, cloneCoat.Materials);
            Assert.Equal(originalCoat.Color, cloneCoat.Color);

            cloneCoat.Materials.Add("Whool");

            Assert.Equal(originalCoat.Materials.Count, cloneCoat.Materials.Count);
            Assert.Equal(originalCoat.Materials, cloneCoat.Materials);
        }
    }
}
