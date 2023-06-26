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

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для Infographics.xaml
    /// </summary>
    public partial class Infographics : Window
    {
        List<Finances_by_year> list;
        int sum_2021 = 0, sum_2022 = 0, sum_2023 = 0;

        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public Infographics()
        {
            InitializeComponent();
            list = new List<Finances_by_year>
            {
                new Finances_by_year() { Month = "январь", Finances_2021 = -1500, Finances_2022 = 2000, Finances_2023 = 2800 },
                new Finances_by_year() { Month = "февраль", Finances_2021 = -1700, Finances_2022 = 1500, Finances_2023 = 3000 },
                new Finances_by_year() { Month = "март", Finances_2021 = 12000, Finances_2022 = -23000, Finances_2023 = 15000 },
                new Finances_by_year() { Month = "апрель", Finances_2021 = 17500, Finances_2022 = 17520, Finances_2023 = 26870 },
                new Finances_by_year() { Month = "май", Finances_2021 = 15000, Finances_2022 = 23000, Finances_2023 = -8522 },
                new Finances_by_year() { Month = "июнь", Finances_2021 = -14520, Finances_2022 = -5000, Finances_2023 = 25000 },
                new Finances_by_year() { Month = "июль", Finances_2021 = -14700, Finances_2022 = -7850 },
                new Finances_by_year() { Month = "август", Finances_2021 = -5700, Finances_2022 = 30860 },
                new Finances_by_year() { Month = "сентябрь", Finances_2021 = 15000, Finances_2022 = 18560 },
                new Finances_by_year() { Month = "октябрь", Finances_2021 = 13000, Finances_2022 = -15850 },
                new Finances_by_year() { Month = "ноябрь", Finances_2021 = -11450, Finances_2022 = 1000 },
                new Finances_by_year() { Month = "декабрь", Finances_2021 = -15000, Finances_2022 = 23000 },

            };
            foreach (var item in list)
            {
                sum_2021 += item.Finances_2021;
                sum_2022 += item.Finances_2022;
                sum_2023 += item.Finances_2023;
            }
            list.Add(new Finances_by_year() { Month = "итого", Finances_2021 = sum_2021, Finances_2022 = sum_2022, Finances_2023 = sum_2023 });
            DataContext = list;
        }
    }
}
