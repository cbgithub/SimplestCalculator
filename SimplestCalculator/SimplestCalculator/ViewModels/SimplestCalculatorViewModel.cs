using SimplestCalculator.Commands;
using SimplestCalculator.Models;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace SimplestCalculator.ViewModels
{
    public class SimplestCalculatorViewModel : INotifyPropertyChanged
    {

        private SimplestCalculatorModel model;
        public SimplestCalculatorViewModel()
        {
            model = new SimplestCalculatorModel();
        }


        public SimplestCalculatorModel Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
                OnPropertyChanged("Model");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Use to notify the view when one of the Fields changes.
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }




        #region Field
        private ICommand _oneCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand OneCommand
        {
            get
            {
                if (_oneCommand == null)
                {
                    _oneCommand = new RelayCommand(
                    param => addOne(),
                    param => CanAddOne()
                    );
                }
                return _oneCommand;
            }
        }
        private bool CanAddOne()
        {
            // Verify command can be executed here
            return true;
        }
        private void addOne()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "1";
                model.Equation += "1";
            }
            else
            {
                model.SecondNumber += "1";
                model.Equation += "1";
                displaySolution();
            }

        }


        #region Field
        private ICommand _twoCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand TwoCommand
        {
            get
            {
                if (_twoCommand == null)
                {
                    _twoCommand = new RelayCommand(
                    param => addTwo(),
                    param => CanAddTwo()
                    );
                }
                return _twoCommand;
            }
        }
        private bool CanAddTwo()
        {
            // Verify command can be executed here
            return true;
        }
        private void addTwo()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "2";
                model.Equation += "2";
            }
            else
            {
                model.SecondNumber += "2";
                model.Equation += "2";
                displaySolution();
            }
        }


        #region Field
        private ICommand _threeCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand ThreeCommand
        {
            get
            {
                if (model.Operation == null)
                {
                    _threeCommand = new RelayCommand(
                    param => addThree(),
                    param => CanAddThree()
                    );
                }
                return _threeCommand;
            }
        }
        private bool CanAddThree()
        {
            // Verify command can be executed here
            return true;
        }
        private void addThree()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "3";
                model.Equation += "3";
            }
            else
            {
                model.SecondNumber += "3";
                model.Equation += "3";
                displaySolution();
            }
        }


        #region Field
        private ICommand _fourCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand FourCommand
        {
            get
            {
                if (_fourCommand == null)
                {
                    _fourCommand = new RelayCommand(
                    param => addFour(),
                    param => CanAddFour()
                    );
                }
                return _fourCommand;
            }
        }
        private bool CanAddFour()
        {
            // Verify command can be executed here
            return true;
        }
        private void addFour()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "4";
                model.Equation += "4";
            }
            else
            {
                model.SecondNumber += "4";
                model.Equation += "4";
                displaySolution();
            }
        }


        #region Field
        private ICommand _fiveCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand FiveCommand
        {
            get
            {
                if (model.Operation == null)
                {
                    _fiveCommand = new RelayCommand(
                    param => addFive(),
                    param => CanAddFive()
                    );
                }
                return _fiveCommand;
            }
        }
        private bool CanAddFive()
        {
            // Verify command can be executed here
            return true;
        }
        private void addFive()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "5";
                model.Equation += "5";
            }
            else
            {
                model.SecondNumber += "5";
                model.Equation += "5";
                displaySolution();
            }
        }




        #region Field
        private ICommand _sixCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand SixCommand
        {
            get
            {
                if (_sixCommand == null)
                {
                    _sixCommand = new RelayCommand(
                    param => addSix(),
                    param => CanAddSix()
                    );
                }
                return _sixCommand;
            }
        }
        private bool CanAddSix()
        {
            // Verify command can be executed here
            return true;
        }
        private void addSix()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "6";
                model.Equation += "6";
            }
            else
            {
                model.SecondNumber += "6";
                model.Equation += "6";
                displaySolution();
            }
        }




        #region Field
        private ICommand _sevenCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand SevenCommand
        {
            get
            {
                if (_sevenCommand == null)
                {
                    _sevenCommand = new RelayCommand(
                    param => addSeven(),
                    param => CanAddSeven()
                    );
                }
                return _sevenCommand;
            }
        }
        private bool CanAddSeven()
        {
            // Verify command can be executed here
            return true;
        }
        private void addSeven()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "7";
                model.Equation += "7";
            }
            else
            {
                model.SecondNumber += "7";
                model.Equation += "7";
                displaySolution();
            }
        }




        #region Field
        private ICommand _eightCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand EightCommand
        {
            get
            {
                if (_eightCommand == null)
                {
                    _eightCommand = new RelayCommand(
                    param => addEight(),
                    param => CanAddEight()
                    );
                }
                return _eightCommand;
            }
        }
        private bool CanAddEight()
        {
            // Verify command can be executed here
            return true;
        }
        private void addEight()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "8";
                model.Equation += "8";
            }
            else
            {
                model.SecondNumber += "8";
                model.Equation += "8";
                displaySolution();
            }
        }




        #region Field
        private ICommand _nineCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand NineCommand
        {
            get
            {
                if (_nineCommand == null)
                {
                    _nineCommand = new RelayCommand(
                    param => addNine(),
                    param => CanAddNine()
                    );
                }
                return _nineCommand;
            }
        }
        private bool CanAddNine()
        {
            // Verify command can be executed here
            return true;
        }
        private void addNine()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "9";
                model.Equation += "9";
            }
            else
            {
                model.SecondNumber += "9";
                model.Equation += "9";
                displaySolution();
            }
        }


        #region Field
        private ICommand _zeroCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand ZeroCommand
        {
            get
            {
                if (_zeroCommand == null)
                {
                    _zeroCommand = new RelayCommand(
                    param => addZero(),
                    param => CanAddZero()
                    );
                }
                return _zeroCommand;
            }
        }
        private bool CanAddZero()
        {
            // Verify command can be executed here
            return true;
        }
        private void addZero()
        {
            if (model.Operation == null || model.Operation == string.Empty)
            {
                model.FirstNumber += "0";
                model.Equation += "0";
            }
            else
            {
                model.SecondNumber += "0";
                model.Equation += "0";
                displaySolution();
            }
        }
        #region Field
        private ICommand _dotCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand DotCommand
        {
            get
            {
                if (_dotCommand == null)
                {
                    _dotCommand = new RelayCommand(
                    param => addDotSign(),
                    param => CanAddDotSign()
                    );
                }
                return _dotCommand;
            }
        }


        public void addDotSign()
        {
            if (model.FirstNumber != null && model.FirstNumber != string.Empty && !model.FirstNumber.Contains(".") && (model.Operation == null || model.Operation == string.Empty) && (model.SecondNumber == null || model.SecondNumber == string.Empty))
            {
                model.FirstNumber += ".";
                model.Equation += ".";
            }
            else if (model.Operation != null && model.Operation != string.Empty && model.SecondNumber != null && model.SecondNumber != string.Empty && !model.SecondNumber.Contains("."))
            {
                model.SecondNumber += ".";
                model.Equation += ".";

                displaySolution();
            }

        }
        private bool CanAddDotSign()
        {
            // Verify command can be executed here
            return true;
        }



        #region Field
        private ICommand _addCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(
                    param => addPlusSign(),
                    param => CanAddPlusSign()
                    );
                }
                return _addCommand;
            }
        }
        private bool CanAddPlusSign()
        {
            // Verify command can be executed here
            return true;
        }
        private void addPlusSign()
        {
            if (model.FirstNumber != null && model.FirstNumber != string.Empty)
            {
                model.Operation = " + ";
                model.Equation += " + ";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }


        #region Field
        private ICommand _subtractCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand SubtractCommand
        {
            get
            {
                if (_subtractCommand == null)
                {
                    _subtractCommand = new RelayCommand(
                    param => addSubtractSign(),
                    param => CanAddSubtractSign()
                    );
                }
                return _subtractCommand;
            }
        }
        private void addSubtractSign()
        {
            if (model.FirstNumber != null && model.FirstNumber != string.Empty)
            {
                model.Operation = " - ";
                model.Equation += " - ";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }
        private bool CanAddSubtractSign()
        {
            // Verify command can be executed here
            return true;
        }





        #region Field
        private ICommand _multiplyCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand MultiplyCommand
        {
            get
            {
                if (_multiplyCommand == null)
                {
                    _multiplyCommand = new RelayCommand(
                    param => addMultiplySign(),
                    param => CanAddMultiplySign()
                    );
                }
                return _multiplyCommand;
            }
        }
        private void addMultiplySign()
        {
            if (model.FirstNumber != null && model.FirstNumber != string.Empty)
            {
                model.Operation = " * ";
                model.Equation += " * ";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }
        private bool CanAddMultiplySign()
        {
            // Verify command can be executed here
            return true;
        }





        #region Field
        private ICommand _divideCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand DivideCommand
        {
            get
            {
                if (_divideCommand == null)
                {
                    _divideCommand = new RelayCommand(
                    param => addDivideSign(),
                    param => CanAddDivideSign()
                    );
                }
                return _divideCommand;
            }
        }
        private void addDivideSign()
        {
            if (model.FirstNumber != null && model.FirstNumber != string.Empty)
            {
                model.Operation = " / ";
                model.Equation += " / ";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }
        private bool CanAddDivideSign()
        {
            // Verify command can be executed here
            return true;
        }


        #region Field
        private ICommand _percentCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand PercentCommand
        {
            get
            {
                if (_percentCommand == null)
                {
                    _percentCommand = new RelayCommand(
                    param => addPercentSign(),
                    param => CanAddPercentSign()
                    );
                }
                return _percentCommand;
            }
        }
        private void addPercentSign()
        {
            if (model.FirstNumber != null && model.FirstNumber != string.Empty)
            {
                model.Operation = " % ";
                model.Equation += " % ";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }
        private bool CanAddPercentSign()
        {
            // Verify command can be executed here
            return true;
        }






        #region Field
        private ICommand _equalCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public ICommand EqualCommand
        {
            get
            {
                if (_equalCommand == null)
                {
                    _equalCommand = new RelayCommand(
                    param => displaySolution(),
                    param => CanGetSolution()
                    );
                }
                return _equalCommand;
            }
        }
        private void displaySolution()
        {
            string operation = model.Operation;
            Double solution = 0;
            Double answer = 0;
            Double firstNumber = Double.Parse(model.FirstNumber);
            Double secondNumber = Double.Parse(model.SecondNumber);
            Double first = Double.Parse(model.FirstNumber);
            Double second = Double.Parse(model.SecondNumber);
            switch (operation)
            {
                case " + ":
                    solution = Math.Round(firstNumber + secondNumber, 3);
                    model.Solution = solution + "";
                    break;
                case " - ":
                    solution = Math.Round(firstNumber - secondNumber, 3);
                    model.Solution = solution + "";
                    break;
                case " * ":
                    solution = Math.Round(firstNumber * secondNumber, 3);
                    model.Solution = solution + "";
                    break;
                case " / ":
                    solution = Math.Round(firstNumber / secondNumber, 3);
                    model.Solution = solution + "";
                    break;
                case " % ":
                    answer = ((first * (double)second) / 100);
                    model.Solution = answer + "";
                    break;
            }
        }

        private bool CanGetSolution()
        {
            // Verify command can be executed here
            return true;
        }






        #region Field
        private ICommand _clearCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public System.Windows.Input.ICommand ClearCommand
        {
            get
            {
                if (_clearCommand == null)
                {
                    _clearCommand = new RelayCommand(
                    param => Clear(),
                    param => CanClear()
                    );
                }
                return _clearCommand;
            }
        }
        private void Clear()
        {
            model.FirstNumber = null;
            model.SecondNumber = null;
            model.Equation = null;
            model.Operation = null;
            model.Solution = null;
        }


        private bool CanClear()
        {
            return true;
        }
        #region Field
        private ICommand _deleteCommand;
        #endregion Field


        /// <summary>
        ///
        /// </summary>
        public System.Windows.Input.ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand(
                    param => Delete(),
                    param => CanDelete()
                    );
                }
                return _deleteCommand;
            }
        }
        private void Delete()
        {


            if ((model.FirstNumber != null & model.FirstNumber != string.Empty) && (model.Operation == null || model.Operation == string.Empty))
            {
                model.Equation = model.Equation.Remove(model.Equation.Length - 1);
                model.FirstNumber = model.FirstNumber.Remove(model.FirstNumber.Length - 1);

            }
            else if (model.FirstNumber != null && (model.SecondNumber == null || model.SecondNumber == string.Empty) && model.Operation != null && model.Operation != string.Empty)
            {
                model.Equation = model.Equation.Remove(model.Equation.Length - 1);
                model.Operation = model.Operation.Remove(model.Operation.Length - 1);

            }
            else if (model.FirstNumber != null && model.FirstNumber != string.Empty && model.Operation != null && model.Operation != string.Empty)
            {
                if (model.SecondNumber.Length == 1)
                {
                    model.Equation = model.Equation.Remove(model.Equation.Length - 1);
                    model.SecondNumber = model.SecondNumber.Remove(model.SecondNumber.Length - 1);

                    model.Solution = null;
                }
                else
                {
                    model.Equation = model.Equation.Remove(model.Equation.Length - 1);
                    model.SecondNumber = model.SecondNumber.Remove(model.SecondNumber.Length - 1);

                    displaySolution();
                }
            }


        }


        private bool CanDelete()
        {
            return true;
        }


    }

}
