using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDoList.Models
{
    public static class DataManager
    {
        public static User userNow;






        public static readonly string ImortPathCategory = "category.json";
        public static string CachePathCategory { get => Path.Combine(FileSystem.Current.AppDataDirectory, "copyCategory.json"); }

        private static List<Category> categories;

        public static List<Category> Categories
        {
            get
            {
                if (categories == null)
                    categories = GetData<List<Category>>(CachePathCategory);
                return categories;
            }

            set
            {

                categories = value;
                SetData(CachePathCategory, categories);
            }
        }


        public static readonly string ImortPathUser = "user.json";
        public static string CachePathUser { get => Path.Combine(FileSystem.Current.AppDataDirectory, "copyUser.json"); }

        private static List<User> users;

        public static List<User> Users
        {
            get
            {
                if (users == null)
                    users = GetData<List<User>>(CachePathUser);
                return users;
            }

            set
            {

                users = value;
                SetData(CachePathUser, users);
            }
        }
        public static readonly string ImortPathToDo = "todo_list.json";
        public static string CachePathToDo { get => Path.Combine(FileSystem.Current.AppDataDirectory, "copyToDO.json"); }

        private static List<ToDo> todo;

        public static List<ToDo> Todo
        {
            get
            {
                if (todo == null)
                    todo = GetData<List<ToDo>>(CachePathToDo);
                return todo;
            }

            set
            {

                todo = value;
                SetData(CachePathToDo, todo);
            }
        }

        private static void SetData<T>(string cachePathUser, T users)
        {
            var jsonData = JsonConvert.SerializeObject(users);
            File.WriteAllText(cachePathUser, jsonData);
        }

        private static T GetData<T>(string cachePath)
        {
            var data = JsonConvert.DeserializeObject<T>(File.ReadAllText(cachePath));
            return data;
        }

        internal static async void InitDataFile(string output, string source)
        {
            if(!File.Exists(output))
            {
                var file = File.Create(output);
                file.Close();
                File.WriteAllText(output, await ReaderAsset(source));
            }
        }

        private static async Task<string?> ReaderAsset(string source)
        {
            using(var memory = await FileSystem.OpenAppPackageFileAsync(source))
            {
                using(var reader = new StreamReader(memory))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
