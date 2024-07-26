using System;
using Microsoft.Maui.Controls;
using LogRegFirebase.Services;
using Microsoft.Maui.Storage;
using LogRegFirebase.Pages;

namespace LogRegFirebase.Pages;

public partial class LoginPage : ContentPage
{
    private readonly FirebaseAuthService _authService = new FirebaseAuthService();
    public LoginPage()
    {
        InitializeComponent();
    }



    private async void Button_Clicked_1(object sender, EventArgs e)
    {

        var email = EmailEntry.Text;
        var password = PasswordEntry.Text;

        try
        {
            var token = await _authService.LoginAsync(email, password);
            await SecureStorage.SetAsync("firebase_token", token);
            await Navigation.PushAsync(new HomePage());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}