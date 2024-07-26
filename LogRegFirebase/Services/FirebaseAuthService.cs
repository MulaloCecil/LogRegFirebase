using Firebase.Auth;

namespace LogRegFirebase.Services
{
    public class FirebaseAuthService
    {
        private readonly FirebaseAuthProvider _authProvider;
        private readonly string _firebaseApiKey = "AIzaSyBtPvJR8esrB4RRvUSempMSkkwaH2-MlNE";

        public FirebaseAuthService()
        {
            _authProvider = new FirebaseAuthProvider(new FirebaseConfig(_firebaseApiKey));
        }

        public async Task<string> RegisterAsync(string email, string password)
        {
            var auth = await _authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
            return auth.FirebaseToken;
        }

        public async Task<string> LoginAsync(string email, string password)
        {
            var auth = await _authProvider.SignInWithEmailAndPasswordAsync(email, password);
            return auth.FirebaseToken;
        }
    }
}