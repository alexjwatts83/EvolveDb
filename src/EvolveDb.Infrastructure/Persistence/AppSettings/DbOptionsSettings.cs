namespace EvolveDb.Infrastructure.Persistence.AppSettings
{
    public static class DbOptionsSettings
    {
        public const string Section = "DbOptions";
        public static string MainDbName => $"{Section}:MainDbName";
    }
}
