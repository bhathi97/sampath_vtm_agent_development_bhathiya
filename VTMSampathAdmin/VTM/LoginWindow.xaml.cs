using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Popups;
using VTMSampathAdmin.Previews;

namespace VTMSampathAdmin.VTM
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public TextBox TemporaryTextBox { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
            Actions.AgentName = null;
            Actions.AgentBranch = null;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TbEmail.Focus();
            Actions.LoadSettings();

            TextBox temporaryTextBox = new TextBox
            {
                FontSize = 25,
                Background = Tbpassword.Background,
                VerticalAlignment = Tbpassword.VerticalAlignment,
                BorderBrush = new SolidColorBrush(Colors.Transparent),
                Height = Tbpassword.Height,
                
            };
            TemporaryTextBox = temporaryTextBox;
        }

        private void TbEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Tbpassword.Focus();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //check the username and password is correct
            // if correct
            if (true)
            {
                Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                Show();
            }




            /*Actions.AgentName = TbEmail.Text;
            Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            Show();*/

            /*ReviewWindow reviewWindow = new ReviewWindow();
            reviewWindow.Show();*/


            //this is the way

            /* SetProfileWindow setProfileWindow = new SetProfileWindow();
             setProfileWindow.Show();*/


            /*DateRangePicker dateRangePicker = new DateRangePicker();
            dateRangePicker.ShowDialog();*/


            /*MandateForm_setting mandateForm_Setting = new MandateForm_setting();
            mandateForm_Setting.ShowDialog();*/

            /*SessionInputs sessionInputs = new SessionInputs();
            sessionInputs.ShowDialog();*/

        }

        private void ImgShowPassword_MouseEnter(object sender, MouseEventArgs e)
        {
            ImgShowPassword.Icon = FontAwesome.WPF.FontAwesomeIcon.Eye;
            string enteredText = Tbpassword.Password;

            TemporaryTextBox.Text = enteredText;
            Grid.SetColumn(TemporaryTextBox, 0);
            Grid.SetRow(TemporaryTextBox, 0);

            Tbpassword.Foreground = new SolidColorBrush(Colors.Transparent);
            GrdPasswordVisibilityHandle.Children.Add(TemporaryTextBox);

            TemporaryTextBox.Focus();
            TemporaryTextBox.CaretIndex = TemporaryTextBox.Text.Length;



        }

        private void ImgShowPassword_MouseLeave(object sender, MouseEventArgs e)
        {
            ImgShowPassword.Icon = FontAwesome.WPF.FontAwesomeIcon.EyeSlash;

            Tbpassword.Foreground = new SolidColorBrush(Colors.Black);
            Tbpassword.Password = TemporaryTextBox.Text;

            var passwordBoxTextBox = FindVisualChild<TextBox>(Tbpassword);

            if (passwordBoxTextBox != null)
            {
                passwordBoxTextBox.CaretIndex = Tbpassword.Password.Length;
                passwordBoxTextBox.Focus();
            }

            GrdPasswordVisibilityHandle.Children.Remove(TemporaryTextBox);
        }

        //method to access password box text box
        private static T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                if (child is T result)
                    return result;

                T descendant = FindVisualChild<T>(child);
                if (descendant != null)
                    return descendant;
            }

            return null;
        }


    }
}
