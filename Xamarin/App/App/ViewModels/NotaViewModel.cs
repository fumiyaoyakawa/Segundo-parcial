using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App.ViewModels
{
    class NotaViewModel : BaseViewModel
    {
        #region variables
        string nota;
        bool isrunning;
        bool isenabled;
        #endregion
        #region propiedades
        public string Nota
        {
            get { return this.nota; }
            set { SetValue(ref this.nota, value); }
        }
        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }
        public bool IsEnabled
        {
            get { return this.isenabled; }
            set { SetValue(ref this.isenabled, value); }
        }
        #endregion
        #region command
        public ICommand Notacmd
        {
            get
            {
                return new RelayCommand(Notacmd);
            }
        }
        private async void Notacmd()
        {
            if (String.IsNullOrEmpty(nota))
            {
                await App.Current.MainPage.DisplayAlert("Nota empty",
                    "ingrese nota",
                    "accept");
                return;
            }
            IsRunning = true;

        }
        #endregion
    }
}