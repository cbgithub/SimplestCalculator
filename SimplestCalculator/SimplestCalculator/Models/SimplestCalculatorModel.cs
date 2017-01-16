using System.ComponentModel;

namespace SimplestCalculator.Models
{
    public class SimplestCalculatorModel : INotifyPropertyChanged
    {
        private string _firstNumber;
        private string _secondNumber;
        private string _solution;
        private string _operation;
        private string _equation;


        public string Equation
        {
            get
            {
                return _equation;
            }
            set
            {
                _equation = value;
                OnPropertyChanged("Equation");
            }
        }

        public string FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                _firstNumber = value;
                OnPropertyChanged("FirstNumber");
            }
        }
        public string SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                _secondNumber = value;
                OnPropertyChanged("SecondNumber");
            }
        }
        public string Operation
        {
            get
            {
                return _operation;
            }
            set
            {
                _operation = value;
                OnPropertyChanged("Operation");
            }
        }


        public string Solution
        {
            get
            {
                return _solution;
            }
            set
            {
                _solution = value;
                OnPropertyChanged("Solution");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Use to notify the view when one of the Fields changes.
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }


   
}
