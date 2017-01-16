using System;
using System.ComponentModel;
using System.Windows.Input;

namespace SimplestCalculator.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;
        private object parameter;

        public event EventHandler CanExecuteChanged;


        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute, INotifyPropertyChanged npc = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;

            if (npc != null)
                npc.PropertyChanged += delegate { canExecute(parameter); };
        }

        public RelayCommand(Action execute, Func<bool> canExecute, INotifyPropertyChanged npc = null)
            : this(o => execute(), o => canExecute(), npc)
        {
        }



        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }



        /// <summary>
        /// Method used to raise the <see cref="CanExecuteChanged"/> event
        /// to indicate that the return value of the <see cref="CanExecute"/>
        /// method has changed.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }

}
