
using AppToDoList.Models;
using AppToDoList.Pages;

namespace AppToDoList
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Refresh();
           
        }

        private void Refresh()
        {
            var catgories = DataManager.Categories;
            LVCategories.ItemsSource = catgories;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(LVCategories.SelectedItem is Category category)
            {
                var todoList = DataManager.Todo;
                var todoListFilter = todoList.Where(x => x.categoryId == category.Id && x.userId==DataManager.userNow.id).ToList();

                Navigation.PushModalAsync(new ToDoListPage(todoListFilter));
            }
        }
    }

}
