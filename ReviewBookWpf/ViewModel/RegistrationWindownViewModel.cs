using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReviewBookWpf.ViewModel.Base;
using ReviewBookWpf.Infastructures.Commands;

namespace ReviewBookWpf.ViewModel
{
    internal class RegistrationWindownViewModel : ViewModels
    {
        #region Команды
        public  ICommand RegisterUser {get;}
        private void OnRegisterUser(object p)
        {   
                
        }

        private bool CanRegisterUser(object p) => true;

    
        #region CheckDateRegistration
        


        #endregion
        #endregion

        public RegistrationWindownViewModel()
        {
            RegisterUser = new LambdaCommand(OnRegisterUser, CanRegisterUser);

        }

    }
}
