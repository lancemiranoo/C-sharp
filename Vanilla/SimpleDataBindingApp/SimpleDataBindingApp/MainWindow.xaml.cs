using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SimpleDataBindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //  Step 1. Create a private field to store the name input private string name;
        private string user;

        //  Step 2. Define a public property for the name, which the UI can access via data binding
        public string User
        {
            get => user;    // Returns the value of the name field
            set
            {
                user = value;   // Updates the value of the name field
                OnPropertyChanged();    // Notifies the UI that the Name property has changed
            }
        }

        //  Constructor for the Main Window
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; // Sets the data context to this class, allowing data binding
        }
        // Step 3. Event handler for the TextBox's TextChanged event 
        private void NameInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Updates the Name property with the current text in the Textbox

            // This triggers OnPropertyChanged, which updates the bound TextBlock
            User = NameInput.Text.ToUpper();
            NameDisplay.FontSize = 60;
        }

        // Required interface event for property change notification data binding
        public event PropertyChangedEventHandler PropertyChanged;

        // Notifies the UI when a property value changes, triggering update for data-bound elements
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // If any elements are bound to this property, they are updated
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}