using AppToDoList.Models;

namespace AppToDoList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //File.Delete(Path.Combine(FileSystem.Current.AppDataDirectory, "copyUser.json"));
            DataManager.InitDataFile(Path.Combine(FileSystem.Current.AppDataDirectory, "copyUser.json"),DataManager.ImortPathUser);
            DataManager.InitDataFile(Path.Combine(FileSystem.Current.AppDataDirectory, "copyToDO.json"),DataManager.ImortPathToDo);
        }
    }
}
