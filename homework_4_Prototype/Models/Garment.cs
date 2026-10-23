using homework_4_Prototype.Interfaces;

namespace homework_4_Prototype.Models
{
    /// <summary>
    /// Базовый класс для любого предмета одежды. <br/>
    /// Содержит базовые свойства: Id, Name. <br/>
    /// Реазлизует паттерн Prototype через интерфейсы IMyCloneable и System.ICloneable.
    /// </summary>
    public class Garment : IMyCloneable<Garment>, ICloneable
    {
        /// <summary>
        /// Конструктор базового класса одежды.
        /// </summary>
        /// <param name="id">int - идентификационный номер одежды</param>
        /// <param name="name">string - название одежды</param>
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
