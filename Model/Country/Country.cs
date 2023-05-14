namespace Countries.Model.Country
{
    public class Country
    {
        public string Name { get; set; }
        public string OfficialName { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<string> Currencies { get; set; }
        public string Subregion { get; set; }
        public List<string> Languages { get; set; }
    }
}
