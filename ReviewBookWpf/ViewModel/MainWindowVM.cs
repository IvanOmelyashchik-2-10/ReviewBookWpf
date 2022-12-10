
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
    }
}

