using System.ComponentModel;

namespace AppConnect.Model
{
    // Represents a parameter from a quick card in an App Connect deep link URI
    public class AppConnectUriParameter : INotifyPropertyChanged
    {
        // The parameter name
        private string _paramName;

        public string ParamName
        {
            get { return _paramName; }
            set
            {
                if (_paramName != value)
                {
                    _paramName = value;
                    NotifyPropertyChanged("ParamName");
                }
            }
        }

        // The parameter value
        private string _paramValue;

        public string ParamValue
        {
            get { return _paramValue; }
            set
            {
                if (_paramValue != value)
                {
                    _paramValue = value;
                    NotifyPropertyChanged("ParamValue");
                }
            }
        }

        // Class constructor
        public AppConnectUriParameter(string pName, string pValue)
        {
            _paramName = pName;
            _paramValue = pValue;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify that a property changed
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged Members
    }
}