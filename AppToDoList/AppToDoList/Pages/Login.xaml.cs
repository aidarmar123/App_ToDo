using AppToDoList.Models;

namespace AppToDoList.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void BLogin_Clicked(object sender, EventArgs e)
    {
		var users = DataManager.Users;
		var login = ELogin.Text;
		var password = EPassword.Text;
		if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
		{
			var userNow = users.FirstOrDefault(x => x.login == login && x.password == password);
			if (userNow != null)
			{
				DataManager.userNow = userNow;
				Navigation.PushModalAsync(new MainPage());
			}
		}
    }
}