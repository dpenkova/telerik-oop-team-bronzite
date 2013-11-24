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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheButcherCalculator;

namespace TheButcherCalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Processor mainProcessor;

        public MainWindow()
        {
            InitializeComponent();
            mainProcessor = new Processor();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            object classAndKind = this.ComboBoxAnimal.SelectedValue; 
            AnimalClass convertedClassAndKind = (AnimalClass)classAndKind; //if ADD button is pressed on nonselectedAnimal - program crashes
            string nmespace = classAndKind.GetType().Namespace;
            object assembly = classAndKind.GetType().Assembly;
            string name = string.Format("{0}.{1}, {2}", nmespace, convertedClassAndKind.ToString(), assembly.ToString());

            double weightValue = double.Parse(this.TextBoxWeight.Text); // if weight is not input - program crashes

            // Get the type contained in the name string
            Type type = Type.GetType(name, true); // name should be a string of AssemblyQualifiedName

            // create an instance of that type
            object instance = Activator.CreateInstance(type); // All animals should have an empty constructor to be created this way

            (instance as Animal).TotalWeight = weightValue;
            (instance as Animal).Kind = convertedClassAndKind.ToString();

            mainProcessor.InputList.Add(instance as ISeparateable);

            this.TextBoxWeight.Text = null;

            this.ComboBoxAnimal.Text = "-- Select another Animal --";


            //this.ListBoxInput.Items.Refresh();   // this is not working!!!

            // Refreshing the list the dummy way but it works
            this.ListBoxInput.ItemsSource = null;
            this.ListBoxInput.ItemsSource = mainProcessor.InputList;
        }

        private void OnCalculateButtonClick(object sender, RoutedEventArgs e)
        {
            mainProcessor.Calculate();

            this.ListBoxGoodsProduced.ItemsSource = null;
            this.ListBoxGoodsProduced.ItemsSource = mainProcessor.GoodsProduced;

            this.ListBoxWaste.ItemsSource = null;
            this.ListBoxWaste.ItemsSource = mainProcessor.WasteProduced;
        }

        private void OnClearButtonClick(object sender, RoutedEventArgs e)
        {
            mainProcessor.ClearLists();

            this.ListBoxInput.ItemsSource = null;
            this.ListBoxInput.ItemsSource = mainProcessor.InputList;

            this.ListBoxGoodsProduced.ItemsSource = null;
            this.ListBoxGoodsProduced.ItemsSource = mainProcessor.GoodsProduced;

            this.ListBoxWaste.ItemsSource = null;
            this.ListBoxWaste.ItemsSource = mainProcessor.WasteProduced;

            this.ComboBoxAnimal.Text = "-- Select Animal --";
        }
    }
}
