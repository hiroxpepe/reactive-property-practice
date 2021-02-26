
using System.ComponentModel;

namespace ReactivePropertyPractice {
    /// <summary>
    /// Model for app
    /// </summary>
    public class Model : INotifyPropertyChanged {

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Fields

        int count;

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Events [adjective] 

        /// <summary>
        /// implementation for INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Properties [noun, adjective] 

        public int Count {
            get => count;
            private set {
                count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // public Methods [verb]

        public void Increment() {
            Count++; // must do to the property 
        }
    }
}
