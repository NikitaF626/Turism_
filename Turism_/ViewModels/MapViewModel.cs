using System;
using System.ComponentModel;
using Turism_.ViewModels;

namespace Turism_.ViewModels
{
    public class MapViewModel : INotifyPropertyChanged
    {
        private readonly MapModel _model;

        public MapViewModel()
        {
            _model = new MapModel();
            HtmlSource = _model.HtmlPath;
        }

        private Uri _htmlSource;
        public Uri HtmlSource
        {
            get => _htmlSource;
            set
            {
                if (_htmlSource != value)
                {
                    _htmlSource = value;
                    OnPropertyChanged(nameof(HtmlSource));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
