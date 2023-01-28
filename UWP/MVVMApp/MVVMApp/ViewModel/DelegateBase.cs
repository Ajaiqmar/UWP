using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMApp.ViewModel
{
    class DelegateBase : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public delegate void FunctionHandler();
        public FunctionHandler functionHandler;

        public DelegateBase(FunctionHandler functionHandler)
        {
            this.functionHandler = functionHandler;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.functionHandler();
        }
    }
}
