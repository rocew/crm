using CRM.Classes.Context;
using CRM.Classes.Model;
using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace CRM.Pages
{
    public partial class AddEditEmployeePage : Page
    {
        Employees Employees;
        Context context;
        public string FromPage { get; set; }
        private byte[] _attachedFileData; // Для хранения данных прикрепленного файла

        public AddEditEmployeePage(Employees _Employees = null)
        {
            InitializeComponent();
            context = new Context();
            Employees = _Employees;
            foreach (var item in context.departments)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Tag = item.department_id;
                comboBoxItem.Content = item.department_name;
                //if (_Employees != null && item.department_id == _Employees.department_id) comboBoxItem.IsSelected = true;
                DepartmentTextBox.Items.Add(comboBoxItem);
            }
            foreach (var item in context.positions)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Tag = item.position_id;
                comboBoxItem.Content = item.position_name;
                //if (_Employees != null && item.department_id == _Employees.department_id) comboBoxItem.IsSelected = true; //Изменить потом нужно будет, когде настроите редактирование.
                PositionTextBox.Items.Add(comboBoxItem);
            }
        }


        // Обработчик кнопки "Прикрепить файл"
        private void AttachFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    // Чтение файла в массив байтов
                    _attachedFileData = File.ReadAllBytes(openFileDialog.FileName);
                    MessageBox.Show("Файл успешно прикреплен.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
                }
            }
        }

        // Обработчик кнопки "Сохранить"
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (Employees != null)
            {
                //По идее полностью рабочее редактирование
                //var edit = context.employees.FirstOrDefault(x => x.id == Employees.id);
                //if (edit != null)
                //{
                //    edit.full_name = FullNameTextBox.Text;
                //    edit.birth_date = Convert.ToDateTime(BirthDateTextBox.Text);
                //    edit.experience = Convert.ToInt32(ExperienceTextBox.Text);
                //    edit.date_of_employment = Convert.ToDateTime(DateOfEmploymentTextBox.Text);
                //    edit.department_id = context.departments.FirstOrDefault(x => x.department_id == Convert.ToInt32(((ComboBoxItem)DepartmentTextBox.SelectedItem).Tag)).department_id;
                //    edit.position_id = context.positions.FirstOrDefault(x => x.position_id == Convert.ToInt32(((ComboBoxItem)PositionTextBox.SelectedItem).Tag)).position_id;
                //    edit.gender = GenderTextBox.Text;
                //    edit.phone = PhoneTextBox.Text;
                //    edit.email = EmailTextBox.Text;
                //    edit.notes = NotesTextBox.Text;
                //}
            }
            else
            {
                Employees employees = new Employees()
                {
                    full_name = FullNameTextBox.Text,
                    birth_date = BirthDateTextBox.Text,
                    experience = Convert.ToInt32(ExperienceTextBox.Text),
                    date_of_employment = DateOfEmploymentTextBox.Text,
                    department_id = context.departments.FirstOrDefault(x => x.department_id == Convert.ToInt32(((ComboBoxItem)DepartmentTextBox.SelectedItem).Tag)).department_id,
                    position_id = context.positions.FirstOrDefault(x => x.position_id == Convert.ToInt32(((ComboBoxItem)PositionTextBox.SelectedItem).Tag)).position_id,
                    gender = ((ComboBoxItem)GenderComboBox.SelectedItem)?.Content?.ToString(),
                    phone = PhoneTextBox.Text,
                    email = EmailTextBox.Text,
                    notes = NotesTextBox.Text,
                };
                context.employees.Add(employees);
            }
            context.SaveChanges();
            NavigationService?.Navigate(new Main());
        }

        // Обработчик кнопки "Отмена"
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на главную страницу (Main)
            NavigationService?.Navigate(new Main());
        }

        // Обработчик кнопки "Назад"
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика навигации в зависимости от FromPage
            if (FromPage == "EmployeesPage")
            {
                // Если перешли со страницы сотрудников, возвращаемся на нее
                NavigationService?.Navigate(new EmployeesPage());
            }
            else
            {
                // Иначе возвращаемся на главную страницу
                NavigationService?.Navigate(new Main());
            }
        }
    }
}