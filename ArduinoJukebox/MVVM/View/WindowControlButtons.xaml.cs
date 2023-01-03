using ArduinoJukebox.Core;
using System.Windows;
using System.Windows.Controls;

namespace ArduinoJukebox.MVVM.View
{
    /// <summary>
    /// Interaktionslogik für WindowControlButtons.xaml
    /// </summary>
    public partial class WindowControlButtons : UserControl
    {
        public WindowControlButtons()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Commamd that Close the window
        /// </summary>
        public RelayCommand CloseCommand { get; } =
        new RelayCommand(o =>
        {
            ((Window)o).Close();
        });

        /// <summary>
        /// Command that Minimize the window
        /// </summary>
        public RelayCommand MinimizeCommand { get; } =
        new RelayCommand(o => ((Window)o).WindowState = WindowState.Minimized);

        /// <summary>
        /// Command that Maximize the window
        /// </summary>
        public RelayCommand MaximizeCommand { get; } =
      new RelayCommand(o => { Window w = (Window)o; w.WindowState = w.WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal; });

    }
}
