namespace BLL
{
    public class DataDisplay
    {
        public string Conversion(int Number)
        {
            return Number.ToString().Length >= 5 ? $"{Number * 10 / 10000 / 10.0f}万" : Number.ToString();
        }
    }
}
