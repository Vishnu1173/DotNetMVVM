using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DotnetMVVM.ViewModel
{
    public class EventCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action _excute;
        public EventCommand(Action excute)
        {
            _excute = excute; 
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _excute.Invoke();
        }
    }
}
