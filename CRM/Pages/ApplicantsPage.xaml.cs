// ApplicantsPage.xaml.cs
using CRM.Classes.Context;
using CRM.Classes.Model;
using CRM.Elements;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CRM.Pages
{
    public partial class ApplicantsPage : Page
    {
        Context context;

        public ApplicantsPage()
        {
            InitializeComponent();
            context = new Context();
            LoadComboBoxData();
            LoadItems();
            ApplyFilters();

            DepartmentFilter.SelectedIndex = 0;
            PositionFilter.SelectedIndex = 0;
            StageFilter.SelectedIndex = 0;
        }

        private void LoadItems()
        {
            parent.Children.Clear();

            var departments = context.departments.ToDictionary(d => d.department_id, d => d.department_name);
            var positions = context.positions.ToDictionary(p => p.position_id, p => p.position_name);

            foreach (var candidate in context.candidates)
            {
                string departmentName = departments.TryGetValue(candidate.department_id, out var deptName)
                    ? deptName
                    : "Неизвестный отдел";

                string positionName = positions.TryGetValue(candidate.position_id, out var posName)
                    ? posName
                    : "Неизвестная должность";

                parent.Children.Add(new ApplicantElement(candidate, departmentName, positionName));
            }
        }

        private void LoadComboBoxData()
        {
            // Departments
            DepartmentFilter.Items.Clear();
            DepartmentFilter.Items.Add(new ComboBoxItem { Content = "Все" });
            foreach (var department in context.departments)
            {
                DepartmentFilter.Items.Add(new ComboBoxItem { Content = department.department_name });
            }

            // Positions
            PositionFilter.Items.Clear();
            PositionFilter.Items.Add(new ComboBoxItem { Content = "Все" });
            foreach (var position in context.positions)
            {
                PositionFilter.Items.Add(new ComboBoxItem { Content = position.position_name });
            }

            // Stages
            StageFilter.Items.Clear();
            StageFilter.Items.Add(new ComboBoxItem { Content = "Все" });
            // Add unique stages from candidates
            var stages = context.candidates.Select(c => c.current_stage).Distinct();
            foreach (var stage in stages)
            {
                if (!string.IsNullOrEmpty(stage))
                {
                    StageFilter.Items.Add(new ComboBoxItem { Content = stage });
                }
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

            // Get selected filters
            string selectedDepartment = GetComboBoxContent(DepartmentFilter);
            string selectedPosition = GetComboBoxContent(PositionFilter);
            string selectedStage = GetComboBoxContent(StageFilter);
            string searchText = SearchTextBox.Text?.ToLower() ?? string.Empty;

            var departments = context.departments.ToDictionary(d => d.department_id, d => d.department_name);
            var positions = context.positions.ToDictionary(p => p.position_id, p => p.position_name);

            foreach (var candidate in context.candidates)
            {
                string departmentName = departments.TryGetValue(candidate.department_id, out var deptName)
                    ? deptName
                    : "Неизвестный отдел";

                string positionName = positions.TryGetValue(candidate.position_id, out var posName)
                    ? posName
                    : "Неизвестная должность";

                // Check filters
                bool departmentMatch = selectedDepartment == "Все" || departmentName == selectedDepartment;
                bool positionMatch = selectedPosition == "Все" || positionName == selectedPosition;
                bool stageMatch = selectedStage == "Все" || candidate.current_stage == selectedStage;
                bool searchMatch = string.IsNullOrEmpty(searchText) ||
                                  candidate.full_name.ToLower().Split(' ').Any(word => word.StartsWith(searchText));

                if (departmentMatch && positionMatch && stageMatch && searchMatch)
                {
                    parent.Children.Add(new ApplicantElement(candidate, departmentName, positionName));
                }
            }
        }

        private string GetComboBoxContent(ComboBox comboBox)
        {
            return comboBox.SelectedItem is ComboBoxItem item
                ? item.Content?.ToString() ?? "Все"
                : "Все";
        }

        private void AddApplicantButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditEmployeePage());
        }

        // Navigation methods
        private void CalendarButton_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new Main());
        }

        private void EmployeesButton_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new EmployeesPage());
        }
    }
}