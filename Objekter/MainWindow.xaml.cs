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

namespace Objekter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dog myDog;
        Pig myPig;
        Animal[] myAnimals = new Animal[2];
        public MainWindow()
        {
            InitializeComponent();
            InitialiseData();
            update_view();
        }
        void InitialiseData()
        {
            myDog = new Dog();
            myDog.Name = "Buller";
            myAnimals[0] = myDog;
            myPig = new Pig();
            myPig.Name = "Øffe";
            myAnimals[1] = myPig;
        }
        void update_dog(object sender, RoutedEventArgs e)
        {
            // Modellen opdateres:
            myDog.Name = dog_input.Text;
            update_view();
        }
        void update_pig(object sender, RoutedEventArgs e)
        {
            // Modellen opdateres:
            myPig.Name = pig_input.Text;
            update_view();
        }
        private void update_view()
        {
            dog_output.Content = myDog.Name;
            pig_output.Content = myPig.Name;
            foreach (Animal a in myAnimals)
            {
                a.AnimalSound();
            }
        }
    }
}
