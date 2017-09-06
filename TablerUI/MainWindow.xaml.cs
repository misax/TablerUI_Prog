using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TablerUI
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropDown_OnSelectionChanged(FinishDropDown, null);
        }

        private void ApplyButton_OnClick_(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"This is description: { DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.AssemblyCheckBox.IsChecked = this.ComputerCheckBox.IsChecked = this.HddsCheckBox.IsChecked =
                this.LaserCheckBox.IsChecked = this.ModulsCheckBox.IsChecked =
                    this.MotherboardsCheckBox.IsChecked = this.NotebooksCheckBox.IsChecked =
                        this.PhonesCheckBox.IsChecked = this.PurchaseCheckBox.IsChecked =
                            this.TvsCheckBox.IsChecked = false;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            this.SortText.Text += ((CheckBox) sender).Content + ",";
        }

        private void FinishDropDown_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
            {
                return;
            }
            var combo = (ComboBox) sender;
            var value = (ComboBoxItem) combo.SelectedValue;
            this.NoteText.Text = (string) value.Content;
        }

        private void SuplierNameText_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = this.SuplierNameText.Text;
        }
    }
}
