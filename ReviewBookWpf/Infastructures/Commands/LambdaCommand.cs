using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReviewBookWpf.Infastructures.Commands
{
    internal class LambdaCommand : Command
    {
        private readonly Action<object> _Execute;
        private readonly Func<object,bool> _CanExecute;
        public LambdaCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _Execute = execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = canExecute;
        }

        public override void Execute(object parameter) => _Execute(parameter);


        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;


    }
}
