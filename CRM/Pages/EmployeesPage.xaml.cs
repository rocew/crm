using CRM.Classes.Context;
using CRM.Elements;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CRM.Pages
{
    public partial class EmployeesPage : Page
    {
        Context context;

        public EmployeesPage()
        {
            InitializeComponent();
            context = new Context();
            LoadComboBoxData();
            loadItems();
            ApplyFilters() ;

            DepartmentFilter.SelectedIndex = 0;
            PositionFilter.SelectedIndex = 0;
            ExperienceFilter.SelectedIndex = 0;
        }

        private void loadItems()
        {
            parent.Children.Clear();

            // Получаем все отделы и должности из базы данных
            var departments = context.departments.ToDictionary(d => d.department_id, d => d.department_name);
            var positions = context.positions.ToDictionary(p => p.position_id, p => p.position_name);

            foreach (var employee in context.employees)
            {
                // Получаем названия по ID
                string departmentName = departments.TryGetValue(employee.department_id, out var deptName)
                    ? deptName
                    : "Неизвестный отдел";

                string positionName = positions.TryGetValue(employee.position_id, out var posName)
                    ? posName
                    : "Неизвестная должность";

                parent.Children.Add(new EmloyeesElement(employee, departmentName, positionName));
            }
        }
        private void LoadComboBoxData()
        {
            // Загрузка отделов в ComboBox
            DepartmentFilter.Items.Clear();
            DepartmentFilter.Items.Add(new ComboBoxItem { Content = "Все" });

            foreach (var department in context.departments)
            {
                DepartmentFilter.Items.Add(new ComboBoxItem { Content = department.department_name });
            }

            // Загрузка должностей в ComboBox
            PositionFilter.Items.Clear();
            PositionFilter.Items.Add(new ComboBoxItem { Content = "Все" });

            foreach (var position in context.positions)
            {
                PositionFilter.Items.Add(new ComboBoxItem { Content = position.position_name });
            }
        }
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters_Click(object sender, RoutedEventArgs e)
        {
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            parent.Children.Clear();

            // Получаем выбранные значения фильтров
            string selectedDepartment = DepartmentFilter.SelectedItem?.ToString() ?? "Все";
            string selectedPosition = PositionFilter.SelectedItem?.ToString() ?? "Все";
            string selectedExperience = ExperienceFilter.SelectedItem?.ToString() ?? "Все";
            string searchText = SearchTextBox.Text?.ToLower() ?? string.Empty;

            // Если SelectedItem является ComboBoxItem, извлекаем Content
            if (DepartmentFilter.SelectedItem is ComboBoxItem deptItem)
            {
                selectedDepartment = deptItem.Content?.ToString() ?? "Все";
            }
            if (PositionFilter.SelectedItem is ComboBoxItem posItem)
            {
                selectedPosition = posItem.Content?.ToString() ?? "Все";
            }
            if (ExperienceFilter.SelectedItem is ComboBoxItem expItem)
            {
                selectedExperience = expItem.Content?.ToString() ?? "Все";
            }

            // Получаем словари для сопоставления ID с названиями
            var departments = context.departments.ToDictionary(d => d.department_id, d => d.department_name);
            var positions = context.positions.ToDictionary(p => p.position_id, p => p.position_name);

            foreach (var employee in context.employees)
            {
                // Получаем названия отдела и должности для текущего сотрудника
                string departmentName = departments.TryGetValue(employee.department_id, out var deptName)
                    ? deptName
                    : "Неизвестный отдел";

                string positionName = positions.TryGetValue(employee.position_id, out var posName)
                    ? posName
                    : "Неизвестная должность";

                // Проверяем соответствие фильтрам
                bool departmentMatch = selectedDepartment == "Все" || departmentName == selectedDepartment;
                bool positionMatch = selectedPosition == "Все" || positionName == selectedPosition;
                bool experienceMatch = CheckExperienceFilter(employee.experience, selectedExperience);
                bool searchMatch = string.IsNullOrEmpty(searchText) ||
                                  employee.full_name.ToLower().Split(' ').Any(word => word.StartsWith(searchText));

                // Если все фильтры соответствуют, добавляем элемент
                if (departmentMatch && positionMatch && experienceMatch && searchMatch)
                {
                    parent.Children.Add(new EmloyeesElement(employee, departmentName, positionName));
                }
            }
        }

        private bool CheckExperienceFilter(int experience, string selectedExperience)
        {
            if (string.IsNullOrEmpty(selectedExperience)) return true;
            if (selectedExperience == "Все") return true;
            if (selectedExperience == "Менее 1 года") return experience < 1;
            if (selectedExperience == "1-3 года") return experience >= 1 && experience <= 3;
            if (selectedExperience == "3-5 лет") return experience > 3 && experience <= 5;
            if (selectedExperience == "Более 5 лет") return experience > 5;
            return true;
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditEmployeePage());
        }

        // 🔁 Навигация по вкладкам (левая панель)
        private void CalendarButton_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new Main());
        }

        private void ApplicantsButton_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new ApplicantsPage());
        }

        private void SortByPosition_Click(object sender, RoutedEventArgs e)
        {
            // Сортировка по должности
        }

        private void SortByDepartment_Click(object sender, RoutedEventArgs e)
        {
            // Сортировка по отделу
        }

        private void SortByLastName_Click(object sender, RoutedEventArgs e)
        {
            // Сортировка по фамилии
        }

        private void SortByExp_Click(object sender, RoutedEventArgs e)
        {
            // Сортировка по стажу
        }
    }
}