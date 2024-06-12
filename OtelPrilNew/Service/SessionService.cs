namespace OtelPrilNew.Service
{
    public static class SessionService
    {
        public static async void AddUserToSecureStorage(string username)
        {
            if(username != null)
            {
                await SecureStorage.SetAsync("SessionUser", username);
            }
        }

        public static async Task<string?> GetUserFromSecureStorage()
        {
            var user = await SecureStorage.GetAsync("SessionUser");
            return user;
        }

        public static void RemoveUserFromSecureStorage()
        {
            SecureStorage.Remove("SessionUser");
        }
    }
}
