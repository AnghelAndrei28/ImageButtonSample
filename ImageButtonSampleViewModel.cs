using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace ImageButtonSample
{
    public class ImageButtonSampleViewModel : BaseViewModel
    {
        public static ImageButtonSampleViewModel Instance { get; } = new ImageButtonSampleViewModel();

        public ImageButtonSampleViewModel()
        {
            ToggleLockStateCommand = new Command(() => ToggleLockState());
        }

        private void ToggleLockState()
        {
            Locked = !Locked;
        }

        public ICommand ToggleLockStateCommand { get; private set; }

        private bool _locked = false;
        public bool Locked
        {
            get => _locked;
            set
            {
                if (_locked != value)
                {
                    Debug.WriteLine($"Locked: {value}");

                    _locked = value;

                    OnPropertyChanged();
                }
            }
        }
    }
}
