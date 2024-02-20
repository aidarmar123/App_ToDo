using AppToDoList.Models;
using AppToDoList.Pages;
using System.Security.Cryptography.X509Certificates;


namespace AppToDoList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
            //File.Delete(Path.Combine(FileSystem.Current.AppDataDirectory, "copyUser.json"));
            DataManager.InitDataFile(Path.Combine(FileSystem.Current.AppDataDirectory, "copyCategory.json"), DataManager.ImortPathCategory);
            DataManager.InitDataFile(Path.Combine(FileSystem.Current.AppDataDirectory, "copyUser.json"),DataManager.ImortPathUser);
            DataManager.InitDataFile(Path.Combine(FileSystem.Current.AppDataDirectory, "copyToDO.json"),DataManager.ImortPathToDo);


            
        }
    }
}
