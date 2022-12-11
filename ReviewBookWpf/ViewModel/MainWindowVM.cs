
using System.Windows;
using System.Windows.Input;
using ReviewBookWpf.Infastructures.Commands;
using ReviewBookWpf.ViewModel.Base;

namespace ReviewBookWpf.ViewModel
{
    internal class MainWindowVM : ViewModels
    {
        #region Заголовок окна
        private string _Title = "Review Book";
        /// <summary>Заголовок окна/// </summary>
        public string Title
        {
            get => _Title;
            //set
            //{
            //    if (Equals(value, _Title)) return;
            //    _Title = value;
            //    OnPropertyChanged();
            //    Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        }
        #endregion

        #region Команды

        #region CloseAppCommand
        public ICommand CloseAppCommand { get; }
        private void OnCloseAppCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseAppCommandExecute(object p) => true;
        #endregion

        



        #endregion
        public MainWindowVM()
        {
            #region Команды

            CloseAppCommand = new LambdaCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);


            #endregion
        }
    }
}

