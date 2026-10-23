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


        }
    }
}
