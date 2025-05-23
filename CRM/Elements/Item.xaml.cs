using System.Windows;
using System.Windows.Controls;

namespace CRM.Elements
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        // Свойства для отображения данных сотрудника
        public string FullName
        {
            get => FIO.Content.ToString();
            set => FIO.Content = value;
        }

        public string Gender
        {
            get => gender.Content.ToString();
            set => gender.Content = value;
        }

        public string Specialization
        {
            get => specialization.Content.ToString();
            set => specialization.Content = value;
        }

        public string BirthDate
        {
            get => birth_date.Content.ToString();
            set => birth_date.Content = value;
        }

        public string Age
        {
            get => age.Content.ToString();
            set => age.Content = value;
        }

        public string Contact
        {
            get => contact.Content.ToString();
            set => contact.Content = value;
        }

        // Обработчик кнопки закрытия
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем элемент (скрываем его)
            this.Visibility = Visibility.Collapsed;
        }
    }
}