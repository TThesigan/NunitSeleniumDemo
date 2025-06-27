using System.Text.Json;
using virtusaprep.TestData;

namespace virtusaprep.Utils
{
    public static class TestDataReader
    {
        private static CredentialSet _data;

        static TestDataReader()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "LoginCredential.json");
            string json = File.ReadAllText(path);
            _data = JsonSerializer.Deserialize<CredentialSet>(json);
        }

        public static LoginCredential GetValidLogin() => _data.Valid;
        public static LoginCredential GetInvalidLogin() => _data.Invalid;
    }
}