using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;

namespace UWPDebug.Views
{
    public sealed partial class Blank1Page : Page, INotifyPropertyChanged
    {
        public Blank1Page()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void ContentArea_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            Debug.WriteLine("Pointer enterd.");
        }

        private void ContentArea_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            Debug.WriteLine("Pointer exited");

        }
    }
}
