using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Pidu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        korter korter1 = new korter();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void lisaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox1.Text)) //! - tähendab teistpidi
            {
                korter1.lisaInimene(textbox1.Text);
                textbox1.Text = "";
                textblock1.Text = korter1.kuvaInimesed();
            }
            else
            {
                var dialog = new MessageDialog("TextBox ei tohi tühi olla");
                dialog.ShowAsync();
            }
        }

        private void eemaldaButton_Click(object sender, RoutedEventArgs e)
        {
            korter1.eemaldaInimene(textbox1.Text);
            textbox1.Text = "";
            textblock1.Text = korter1.kuvaInimesed();
        }
    }
}
