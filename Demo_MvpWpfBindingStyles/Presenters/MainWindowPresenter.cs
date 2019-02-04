using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_MvpWpfBindingStyles.Models;

namespace Demo_MvpWpfBindingStyles.Presenters
{
    public class MainWindowPresenter
    {
        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set { _selectedStudent = value; }
        }

        public MainWindowPresenter()
        {
            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            SelectedStudent = new Student()
            {
                LastName = "Velis",
                FirstName = "Johnny",
                Age = 61
            };
        }
    }
}
