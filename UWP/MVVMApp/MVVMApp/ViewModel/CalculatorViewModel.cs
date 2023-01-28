using MVVMApp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace MVVMApp.ViewModel
{
    class CalculatorViewModel : NotifyBase
    {
        private Calculator _calcular;
        private int _leftOperand = 0;
        private int _rightOperand = 0;
        private int _result = 0;
        private bool _isPlusChecked = false;
        private bool _isSubChecked = false;
        private bool _isDivChecked = false;
        private bool _isMulChecked = false;
        private bool _isButtonEnabled = false;
        private bool _isResultVisible = false;

        public int LeftOperand
        {
            get
            {
                return _leftOperand;
            }

            set
            {
                _leftOperand = value;
                OnPropertyChanged("LeftOperand");
            }
        }

        public int RightOperand
        {
            get
            {
                return _rightOperand;
            }

            set
            {
                _rightOperand = value;
                OnPropertyChanged("RightOperand");
            }
        }

        public int Result
        {
            get
            {
                return _result;
            }

            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public bool IsPlusChecked
        {
            get
            {
                return _isPlusChecked;
            }

            set
            {
                _isPlusChecked = value;
                OnPropertyChanged("IsPlusChecked");
            }
        }

        public bool IsSubChecked
        {
            get
            {
                return _isSubChecked;
            }

            set
            {
                _isSubChecked = value;
                OnPropertyChanged("IsSubChecked");
            }
        }

        public bool IsMulChecked
        {
            get
            {
                return _isMulChecked;
            }

            set
            {
                _isMulChecked = value;
                OnPropertyChanged("IsMulChecked");
            }
        }

        public bool IsDivChecked
        {
            get
            {
                return _isDivChecked;
            }

            set
            {
                _isDivChecked = value;
                OnPropertyChanged("IsDivChecked");
            }
        }

        public bool IsButtonEnabled
        {
            get
            {
                return _isButtonEnabled;
            }

            set
            {
                _isButtonEnabled = value;
                OnPropertyChanged("IsButtonEnabled");
            }
        }

        public Visibility IsResultVisible
        {
            get
            {
                return ((_isResultVisible)?Visibility.Visible:Visibility.Collapsed);
            }
        }

        public ICommand OnSubmit
        {
            get
            {
                return new DelegateBase(FindResult);
            }
        }

        public ICommand OnRadioCheck
        {
            get
            {
                return new DelegateBase(EnableButton);
            }
        }

        public void EnableButton()
        {
            IsButtonEnabled = true;
            OnPropertyChanged("IsButtonEnabled");
        }

        public void FindResult()
        {
            _calcular = new Calculator(LeftOperand, RightOperand);

            if(IsPlusChecked)
            {
                Result = _calcular.Add();
            }
            else if(IsSubChecked)
            {
                Result = _calcular.Sub();
            }
            else if(IsMulChecked)
            {
                Result = _calcular.Mul();
            }
            else if(IsDivChecked)
            {
                Result = _calcular.Div();
            }

            _isResultVisible = true;
            OnPropertyChanged("IsResultVisible");
        }
    }
}
