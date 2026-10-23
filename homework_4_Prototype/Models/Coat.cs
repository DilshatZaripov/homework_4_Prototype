namespace homework_4_Prototype.Models
{
    /// <summary>
    /// Класс, описывающий пальто.<br/>
    /// Содержит свойства: Materials, Color.<br/>
    /// Реализует паттерн Prototype.
    /// </summary>
    public class Coat : Outerwear
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">int - идентификационный номер одежды</param>
        /// <param name="name">string - название одежды</param>
        /// <param name="materials">List[string] - перечисление материалов в виду строк</param>
        /// <param name="color">string - цвет данного пальто</param>
        public Coat(
            int id, string name,
            List<string> materials, string color) 
            : base(id, name, "Torso")
        {
            Materials = [.. materials];
            Color = color;
        }

        public List<string> Materials { get; private set; }
        public string Color { get; private set; }

        public override Coat Clone()
        {
            return new Coat(Id, Name, Materials, Color);
        }
    }
}
