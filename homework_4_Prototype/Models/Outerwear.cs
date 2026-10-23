namespace homework_4_Prototype.Models
{
    /// <summary>
    /// Класс, описывающий верхнюю одежду.<br/>
    /// Унаследован от класса Garment.<br/>
    /// Содержит свойство BodyPart.<br/>
    /// Релизует паттерн Prototype.
    /// </summary>
    public class Outerwear : Garment
    {
        /// <summary>
        /// Контруктор верхней одежды.
        /// </summary>
        /// <param name="id">int - идентификационный номер одежды</param>
        /// <param name="name">string - название одежды</param>
        /// <param name="bodyPart">string - часть тела, на котрую надевается верхняя одежда</param>
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
