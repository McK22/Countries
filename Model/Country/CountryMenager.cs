using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Countries.Model.Country
{
    public static class CountryMenager
    {
        public static Country GetCountry(string json)
        {
            dynamic data = JsonConvert.DeserializeObject(json);
            string name = data.First.name.common;

            string officialName;
            string capital;
            int population;
            string subregion;

            try
            {
                officialName = data.First.name.official;
            }
            catch(Exception)
            {
                officialName = null;
            }

            try
            {
                capital = data.First.capital.First;
            }
            catch (Exception)
            {
                capital = null;
            }

            try
            {
                population = data.First.population;
            }
            catch (Exception)
            {
                population = -1;
            }

            try
            {
                subregion = data.First.subregion;
            }
            catch (Exception)
            {
                subregion = null;
            }

            List<string> currencies = new();
            if(data.First.currencies is not null)
                foreach (Newtonsoft.Json.Linq.JProperty jproperty in data.First.currencies)
                    currencies.Add(jproperty.Name.ToString());

            List<string> languages = new();
            if(data.First.languages is not null)
                foreach (Newtonsoft.Json.Linq.JProperty jproperty in data.First.languages)
                    languages.Add(jproperty.Value.ToString());

            return new()
            {
                Name = name,
                OfficialName = officialName,
                Capital = capital,
                Population = population,
                Currencies = currencies,
                Subregion = subregion,
                Languages = languages
            };
        }

        public static string GetCountryJson(string countryName)
        {
            string URL = "https://restcountries.com/v3.1/name/" + countryName;
            string urlParameters = "?api_key=123";

            HttpClient httpClient = new();

            httpClient.BaseAddress = new Uri(URL);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = httpClient.GetAsync(urlParameters).Result;

            httpClient.Dispose();

            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsStringAsync().Result;

            return null;
        }

        public static Country GetCountryByName(string countryName)
        {
            string json = GetCountryJson(countryName);
            return GetCountry(json);
        }
    }
}
