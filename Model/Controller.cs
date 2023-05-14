namespace Countries.Model
{
    public class Controller
    {
        private QueryMenager queryMenager = new();
        private Random random = new();

        public List<Country.Country> GetRandomCountries(string continentCode, int nOfCountries)
        {
            List<string> countryNames = queryMenager.GetCountriesByContinent(continentCode);
            if (countryNames.Count < nOfCountries)
                return null;

            List<Country.Country> result = new();
            for(int i = 0; i < nOfCountries; i++)
            {
                int where = random.Next(countryNames.Count);
                result.Add(queryMenager.GetCountry(countryNames.ElementAt(where)));
                countryNames.RemoveAt(where);
            }
            return result;
        }

        public void Dispose()
        {
            queryMenager.Dispose();
        }
    }
}
