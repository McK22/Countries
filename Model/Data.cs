namespace Countries.Model
{
    public static class Data
    {
        public static Dictionary<string, string> ContinentCodeMap { get; } = new()
        {
            { "Africa", "AF" },
            { "Antarctica", "AN" },
            { "Asia", "AS" },
            { "Europe", "EU" },
            { "North America", "NA" },
            { "Oceania", "OC" },
            { "South America", "SA"}
        };
    }
}
