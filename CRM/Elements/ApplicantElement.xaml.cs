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
using CRM.Classes.Model;

namespace CRM.Elements
{
    public partial class ApplicantElement : UserControl
    {
        public ApplicantElement(Candidates candidate, string departmentName, string positionName)
        {
            InitializeComponent();

            // Устанавливаем значения из модели
            FIO_applicant.Text = candidate.full_name;
            Department_applicant.Text = departmentName;
            Position_applicant.Text = positionName;
            Stage_applicant.Text = candidate.current_stage;
        }
    }
}
