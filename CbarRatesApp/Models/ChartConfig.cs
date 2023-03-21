namespace CbarRatesApp.Models
{
    public class ChartConfig
    {
        public string Type { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public string[] Labels { get; set; }
        public Dataset[] Datasets { get; set; }
    }

    public class Dataset
    {
        public string Label { get; set; }
        public string[] Data { get; set; }
    } 

    public class DataItem
    {
        public string x { get; set; }
        public string y { get; set; }
    }

    public enum ChartType
    {
        line,
        pie,
        bar

    }
}

