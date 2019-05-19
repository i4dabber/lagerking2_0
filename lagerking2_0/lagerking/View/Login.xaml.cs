using System.Windows;
using System.Media;
namespace lagerking.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            string username = "";
            string passwd = "";

            if (username == "" && passwd == "" )
            {
                mw.Show();
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Wrong Input","Login Window");
                SystemSounds.Exclamation.Play();
            }
  
        }
    }
}
