using Countries.Model.Continent;
using Countries.Model.Country;

namespace Countries.Model
{
    public class QueryMenager
    {
        private readonly ContinentMenager continentMenager = new();

        public Country.Country GetCountry(string countryName)
        {
            return CountryMenager.GetCountryByName(countryName);
        }

        public List<string> GetCountriesByContinent(string continentCode)
        {
            return continentMenager.GetCountries(continentCode);
        }

        public void Dispose()
        {
            continentMenager.Dispose();
        }
    }
}
