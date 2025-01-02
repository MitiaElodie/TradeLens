using Duende.IdentityServer.Test;

    public static class TestUsers
    {
        public static List<TestUser> Users =>
            new List<TestUser>
            {
            new TestUser
            {
                SubjectId = "1",
                Username = "testuser",
                Password = "password"
            }
            };
    }