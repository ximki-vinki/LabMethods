using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LabMethods.Infrastracture.Commands;
using LabMethods.ViewModels.Base;

namespace LabMethods.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title : string - Заголовок окна

        /// <summary> Заголовок окна  </summary>
        private string _Title = "Моя программа";

        /// <summary> Заголовок окна  </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        #region Status : string - Статус программы

        /// <summary> Статус программы  </summary>
        private string _Status = "Статус программы";

        /// <summary> Статус программы  </summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        #endregion

        #region Команды

        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecuted(object p) => true;

        #endregion

        #endregion
        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);

            #endregion

        }
    }
}
