namespace homework_4_Protorype.Models
{
    internal class Outerwear : Garment
    {
        public Outerwear(
            int id, 
            string name, 
            string bodyPart) 
            : base(id, name)
        {
            BodyPart = bodyPart;
        }

        public string BodyPart { get; private set; }

        public override Outerwear Clone()
        {
            return new Outerwear(Id, Name, BodyPart);
        }
    }
}
