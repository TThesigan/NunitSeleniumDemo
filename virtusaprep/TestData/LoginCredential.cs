namespace virtusaprep.TestData
{
    public class LoginCredential
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class CredentialSet
    {
        public LoginCredential Valid { get; set; }
        public LoginCredential Invalid { get; set; }
    }
}