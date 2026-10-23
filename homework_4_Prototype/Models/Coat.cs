namespace homework_4_Prototype.Models
{
    public class Coat : Outerwear
    {
        public Coat(
            int id, string name, 
            string bodyPart,
            List<string> materials, string color) 
            : base(id, name, bodyPart)
        {
            Materials = [.. materials];
            Color = color;
        }

        public List<string> Materials { get; private set; }
        public string Color { get; private set; }

        public override Coat Clone()
        {
            return new Coat(Id, Name, BodyPart, Materials, Color);
        }
    }
}
