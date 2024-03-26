namespace LifeStats.Models.DTO
{
    public class AlcoholDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
        public double AmountMl { get; set; }
        public DateTime DateTime { get; set; }
    }
}
