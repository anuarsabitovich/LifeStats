namespace LifeStats.Models.Domain
{
    public class Alcohol
    {
        public Guid Id { get; set; }
        public string Name {  get; set; }
        public double Percentage { get; set; }
        public double AmountMl {  get; set; }
        public DateTime DateTime { get; set; }
    }
}
