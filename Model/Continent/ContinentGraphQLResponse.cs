namespace Countries.Model.Continent
{
    public class ContinentGraphQLResponse
    {
        public class CountryResponse
        {
            public List<Country> Countries { get; set; }
        }

        public class Country
        {
            public string Name { get; set; }
        }
    }
}
