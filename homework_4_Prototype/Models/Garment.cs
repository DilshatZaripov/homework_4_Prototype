using homework_4_Prototype.Interfaces;

namespace homework_4_Prototype.Models
{
    public class Garment : IMyCloneable<Garment>, ICloneable
    {
        public Garment(
            int id,
            string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public virtual Garment Clone()
        {
            return new Garment(Id, Name);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
