using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для Finances.xaml
    /// </summary> 
    /// 
    
   
    public partial class Finances : Window
    {
        List<Balance_item> items;
        public Finances()
        {
            InitializeComponent();
            items = new List<Balance_item>
            {
                new Balance_item() { Date= new DateTime(2023, 6, 13), Amount = -2500, Title = "Транспорт"},
                new Balance_item() {Date= new DateTime(2023, 6, 20), Amount = -1300, Title = "Продукты" },
                new Balance_item() { Date= new DateTime(2023, 6, 22), Amount = -200, Title = "Аптека" },
            };
            DataContext = items;
            items.Add(new Balance_item());
        }

        private void DataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            e.NewItem = new Balance_item(DateTime.Now,0, "" );
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("items.json", FileMode.OpenOrCreate))
            {

                JsonSerializer.SerializeAsync<List<Balance_item>>(fs, items);
                MessageBox.Show("Данные сохранены");
            }
            Close();
        }
    }


}
