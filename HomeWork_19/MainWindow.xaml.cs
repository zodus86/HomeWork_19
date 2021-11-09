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

namespace HomeWork_19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository repository;
        Random random;
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Clic_Create(object sender, RoutedEventArgs e)
        {
            repository = AnimalFactory.GetRepository();
            lvLAnimal.ItemsSource = repository.bd;
        }

        private void Clic_Delete(object sender, RoutedEventArgs e)
        {
            repository.bd.Clear();
            Refresh();
        }

        private void Clic_Add(object sender, RoutedEventArgs e)
        {
            repository.bd.Add(CreateRandomAnimal());
            Refresh();
        }


        /// <summary>
        /// список  животных  обновить
        /// </summary>
        private void Refresh()
        {
            lvLAnimal.Items.Refresh();
        }

        /// <summary>
        /// добавить случайное животное в список
        /// </summary>
        private IAnimal CreateRandomAnimal()
        {    
            switch (random.Next(4))
            {
                case 1: return new Bird("Птичка", random.Next(10, 99));
                case 2: return new Mammals("Человек", random.Next(1, 99)); 
                case 3: return new Amphibians("Земноводное", random.Next(1, 99));
                default: return new UnkownAnimal();
            }

        }


        private void lvLAnimal_SelectionChanged(object sender, MouseButtonEventArgs e)
        {
            repository.bd[lvLAnimal.SelectedIndex] = CreateRandomAnimal();
            Refresh();
        }

        /// <summary>
        /// random mvp save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSave(object sender, RoutedEventArgs e)
        {
            var x = random.Next(int.MinValue, int.MaxValue);
                
            if(x>0)
               repository.SaveMode = new SaveJson(tbFileName.Text);
            else 
              repository.SaveMode = new SaveTxt(tbFileName.Text);

            MessageBox.Show($"Будет произведенно сохранение в {repository.SaveMode.GetType()}");
            repository.Save();
        }
    }
}
