﻿using System;
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
using GradesPrototype.Data;
using GradesPrototype.Services;

namespace GradesPrototype.Views
{
    /// <summary>
    /// Interaction logic for LogonPage.xaml
    /// </summary>
    public partial class LogonPage : UserControl
    {
        public LogonPage()
        {
            InitializeComponent();
        }

        #region Event Members

        // Define the LogonSuccess event handler
        public event EventHandler logonSuccess;

        #endregion
            
        #region Logon Validation
        // Implement the Logon_Click event handler method for the Logon button
        // Simulate logging on (no validation or authentication performed yet)
        private void Logon_Click(object sender, RoutedEventArgs e)
        {
            SessionContext.UserName = username.Text;
            SessionContext.UserRole = (bool)userrole.IsChecked ? Role.Teacher : Role.Student;
            if (SessionContext.UserRole == Role.Student)
            {
                SessionContext.CurrentStudent = "a current student name";
            }
            //check wether the event is null
            if (logonSuccess != null)
            {
                //raise the event
                logonSuccess(this, null);
            }
        }

        #endregion

       
    }
}
