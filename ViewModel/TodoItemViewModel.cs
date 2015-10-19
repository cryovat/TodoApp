using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ViewModel
{
    public class TodoItemViewModel : ObservableObject
    {
        private string _title;
        private DateTimeOffset _due;

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title == value) return;

                _title = value;

                RaisePropertyChanged();
            }
        }

        public DateTimeOffset Due
        {
            get { return _due; }
            set
            {
                if (_due == value) return;

                _due = value;

                RaisePropertyChanged();
            }
        }
    }
}
