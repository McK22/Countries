using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;

namespace Countries.Model.Continent
{
    public class ContinentMenager
    {
        private readonly GraphQLHttpClient graphQLClient;

        public ContinentMenager()
        {
            HttpClient httpClient = new();

            var graphQlHttpClientOptions = new GraphQLHttpClientOptions
            {
                EndPoint = new Uri("https://countries.trevorblades.com/graphql")
            };

            httpClient.DefaultRequestHeaders.Add("apiKey", "123");

            graphQLClient = new GraphQLHttpClient(graphQlHttpClientOptions, new NewtonsoftJsonSerializer(), httpClient);
        }

        public List<string> GetCountries(string continentCode)
        {
            var request = new GraphQLRequest
            {
                Query = $@"query ListCountriesInEurope {{
                            countries(filter: {{ continent: {{ eq: ""{continentCode}"" }} }}) {{
                                name
                            }}
                        }}"
            };

            var graphQLResponse = graphQLClient.SendQueryAsync<ContinentGraphQLResponse.CountryResponse>(request);
            graphQLResponse.Wait();

            List<string> result = new();
            var queryResult = graphQLResponse.Result;
            foreach (var country in queryResult.Data.Countries)
                result.Add(country.Name);

            return result;
        }

        public void Dispose()
        {
            graphQLClient.HttpClient.Dispose();
            graphQLClient.Dispose();
        }
    }
}
