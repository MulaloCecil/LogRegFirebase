using LogRegFirebase.Services;

namespace LogRegFirebase.Pages;

public partial class RegisterPage : ContentPage
{
    private readonly FirebaseAuthService _authService = new FirebaseAuthService();
    public RegisterPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		var email = EmailEntry.Text;
		var password = PasswordEntry.Text;

        try
        {
            await _authService.RegisterAsync(email, password);
            await DisplayAlert("Success", "Registration successful", "OK");
            await Navigation.PushAsync(new LoginPage());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}