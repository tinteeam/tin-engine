using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace editor.GameProject
{
    /// <summary>
    /// Interaction logic for ProjectProjectDialog.xaml
    /// </summary>
    public partial class ProjectProjectDialog : Window
    {
        public ProjectProjectDialog()
        {
            InitializeComponent();
        }
        private void OnToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender == openProject)
            {
                if (newProject.IsChecked == true)
                {
                    newProject.IsChecked = false;
                    browserContent.Margin = new Thickness(0);
                }
                openProject.IsChecked = true;
            }
            else{
                if (openProject.IsChecked == true)
                {
                    openProject.IsChecked = false;
                    browserContent.Margin = new Thickness(-800,0,0,0);
                }
                newProject.IsChecked = true;
            }

        }
    }
}
