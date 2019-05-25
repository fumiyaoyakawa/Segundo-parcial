using System;
using System.Collections.Generic;
using System.Text;

namespace App.ViewModels
{
    using Models;
    using System;
    using System.Collections.ObjectModel;
    public class MainViewModel
    {
        #region Properties
        public string Token { get; set; }
        public string TokenType { get; set; }
        #endregion
        #region ViewModels
        public NotaViewModel Nota { get; set; }
        #endregion
        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Nota = new NotaViewModel();

        }
        #endregion
        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstcance()
        {
            if(instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
