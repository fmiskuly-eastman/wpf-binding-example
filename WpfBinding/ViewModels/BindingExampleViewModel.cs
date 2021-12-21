using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WpfBinding.Helpers;
using WpfBinding.Models;

namespace WpfBinding.ViewModels
{
    public class BindingExampleViewModel : ViewModel
    {
        public ModelClass _Model { get; set; }
        public ICommand ResetCommand { get; set; }

        public BindingExampleViewModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            //normally this would come from some injected service that provides us with a data model we can clone (so we arent operating on the original copy)
            _Model = new ModelClass();
            ResetCommand = new RelayCommand(ResetModel, () => true);
        }

        public void ResetModel()
        {
            _Model = new ModelClass();
            
            //have to clear temp string value
            _value3 = null;
            
            //calling OnPropertyChanged(String.Empty) invokes the PropertyChanged event for all fields
            OnPropertyChanged(String.Empty);
        }

        public double Value1
        {
            get => _Model.Value1;
            set
            {
                _Model.Value1 = value;
                OnPropertyChanged(nameof(Value1));
            }
        }

        public double Value2
        {
            get => _Model.Value2;
            set
            {
                _Model.Value2 = value;
                OnPropertyChanged(nameof(Value2));
            }
        }

        private string _value3;
        public string Value3
        {
            get { return _value3 != null ? _value3 : _Model.Value3.ToString(); }
            set
            {
                if (ValidateTextboxDouble(value, out double result))
                {
                    _Model.Value3 = result;
                    OnPropertyChanged(nameof(ModelValue3)); //tell UI to update Value3 Model value
                }
                _value3 = value;
                OnPropertyChanged(nameof(Value3));
            }
        }

        //because Value3 does not always return Model.Value3, we need another property for Value3 to show the actual value on the UI
        public double ModelValue3
        {
            get => _Model.Value3;
        }
    }
}
