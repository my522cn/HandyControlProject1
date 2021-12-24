using HandyControl.Controls;
using HandyControl.Themes;
using HandyControl.Tools;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HandyControlProject3
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource = new List<Model>() {
                new Model(){Index = 0 , Remark = "12345"},
                new Model(){Index = 2 , Remark = "sfdgfd"},
                new Model(){Index = 3 , Remark = "dgfdg"},
                new Model(){Index = 4 , Remark = "sfdsfdsf"},
            };
        }

        #region Change Theme
        private void ButtonConfig_OnClick(object sender, RoutedEventArgs e) => PopupConfig.IsOpen = true;

        private void ButtonSkins_OnClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button)
            {
                PopupConfig.IsOpen = false;
                if (button.Tag is ApplicationTheme tag)
                {
                    ((App)Application.Current).UpdateTheme(tag);
                }
                else if (button.Tag is Brush accentTag)
                {
                    ((App)Application.Current).UpdateAccent(accentTag);
                }
                else if (button.Tag is "Picker")
                {
                    var picker = SingleOpenHelper.CreateControl<ColorPicker>();
                    var window = new PopupWindow
                    {
                        PopupElement = picker,
                        WindowStartupLocation = WindowStartupLocation.CenterScreen,
                        AllowsTransparency = true,
                        WindowStyle = WindowStyle.None,
                        MinWidth = 0,
                        MinHeight = 0,
                        Title = "Select Accent Color"
                    };

                    picker.SelectedColorChanged += delegate
                    {
                        ((App)Application.Current).UpdateAccent(picker.SelectedBrush);
                        window.Close();
                    };
                    picker.Canceled += delegate { window.Close(); };
                    window.Show();
                }
            }
        }
        #endregion
    }


    public class Model
    {
        public bool IsSelected { get; set; }
        public int Index { get; set; }
        public string Remark { get; set; }
    }
}
