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

namespace _2._3hard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void batton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int day = int.Parse(vd.Text);
                string mounth = vm.Text.ToLower();
                switch (mounth)
                {
                    case "январь":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = "Ваш знак зодиака: Козерог";
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Водолей");
                        }
                        break;
                    case "февраль":
                        if (day >= 1 && day < 20)
                        {
                            znak.Text = ("Ваш знак зодиака: Водолей");
                        }
                        if (day >= 20 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Рыбы");
                        }
                        break;
                    case "март":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Рыбы");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Овен");
                        }
                        break;
                    case "апрель":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Овен");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Телец");
                        }
                        break;
                    case "май":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Телец");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Близнецы");
                        }
                        break;
                    case "июнь":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Близнецы");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Рак");
                        }
                        break;
                    case "июль":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Рак");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Лев");
                        }
                        break;
                    case "август":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Лев");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Дева");
                        }
                        break;
                    case "сентябрь":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Дева");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Весы");
                        }
                        break;
                    case "октябрь":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Весы");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Скорпион");
                        }
                        break;
                    case "ноябрь":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Скорпион");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Стрелец");
                        }
                        break;
                    case "декабрь":
                        if (day >= 1 && day < 21)
                        {
                            znak.Text = ("Ваш знак зодиака: Стрелец");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            znak.Text = ("Ваш знак зодиака: Козерог");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
