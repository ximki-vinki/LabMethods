using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMethods.ViewModels.Base
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Моя программа";

        /// <summary> Заголовок окна  </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
