using System;
using System.ComponentModel;
using System.Collections.Generic;
using ErrorPage_Sample.Views;


namespace ErrorPage_Sample.Models
{
    public class ErrorViewModel : INotifyPropertyChanged
    {
        private Exception _exception;
        private string _versionInformation;

        public ErrorViewModel(Exception exception, string versionInformation)
        {
            Exception = exception;
            VersionInformation = versionInformation;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Exception Exception
        {
            get { return _exception; }
            private set
            {
                if (_exception != value)
                {
                    _exception = value;
                    OnPropertyChanged("Exception");
                }
            }
        }

        public string VersionInformation
        {
            get { return _versionInformation; }
            private set
            {
                if (_versionInformation != value)
                {
                    _versionInformation = value;
                    OnPropertyChanged("VersionInformation");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
