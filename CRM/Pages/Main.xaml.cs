using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using CRM.Pages;

namespace CRM.Pages
{
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SetActiveMenu(Border selected)
        {
            // Сбросим фон у всех пунктов
            CalendarItem.Background = Brushes.Transparent;
            EmployeesItem.Background = Brushes.Transparent;
            ApplicantsItem.Background = Brushes.Transparent;

            // Установим активный фон
            selected.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51)); // #333
        }


        private void CalendarButton_Click(object sender, MouseButtonEventArgs e)
        {
            SetActiveMenu(CalendarItem);
            // Переход, если нужно
        }

        private void EmployeesButton_Click(object sender, MouseButtonEventArgs e)
        {
            SetActiveMenu(EmployeesItem);
            NavigationService?.Navigate(new EmployeesPage());
        }

        private void ApplicantsButton_Click(object sender, MouseButtonEventArgs e)
        {
            SetActiveMenu(ApplicantsItem);
            NavigationService?.Navigate(new ApplicantsPage());
        }

    }
}