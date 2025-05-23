using CRM.Classes.Model;
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

namespace CRM.Elements
{
    /// <summary>
    /// Логика взаимодействия для EmloyeesElement.xaml
    /// </summary>
    public partial class EmloyeesElement : UserControl
    {
        public EmloyeesElement(Employees employee, string departmentName, string positionName)
        {
            InitializeComponent();

            // Устанавливаем значения из модели
            FIO_emloyees.Text = employee.full_name;
            Experience_employees.Text = $"{employee.experience} лет";
            Department_employees.Text = departmentName;
            Position_employees.Text = positionName;
        }
    }
}