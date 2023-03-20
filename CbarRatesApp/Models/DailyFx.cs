
namespace FxCore.Models
{
    public class DailyFx
    {
        
        public string Id { get; set; }
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public DateTime CbarDate { get; set; }
        public List<Rate> Rates { get; set; }
    }

    public class Rate
    {
        public string Code { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal Difference { get; set; }
    }
}
