using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<TodoItemViewModel> Items { get; } = new ObservableCollection<TodoItemViewModel>();

        public MainViewModel()
        {
            Items.Add(new TodoItemViewModel { Title = "Clean room", Due = DateTimeOffset.Now.Date });
            Items.Add(new TodoItemViewModel { Title = "Save world", Due = DateTimeOffset.Now.Date.AddDays(1) });
        }
    }
}
