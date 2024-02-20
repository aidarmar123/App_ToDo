using AppToDoList.Models;

namespace AppToDoList.Pages;

public partial class ToDoListPage : ContentPage
{
	List<ToDo> contextToDo;
	public ToDoListPage(List<ToDo> todoListFilter)
	{
		InitializeComponent();
		contextToDo = todoListFilter;
		PNameToDo.ItemsSource = contextToDo;
	}

    private void BSelectToDo_Clicked(object sender, EventArgs e)
    {
		if(PNameToDo.SelectedItem is ToDo todo)
		{
			Refresh(todo);
			
		}
    }

    private void Refresh(ToDo todo)
    {
		CVListToDo.ItemsSource = todo.works;
    }

    private void Back_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}