// -----------------------------------------------------------------------
// <copyright file="Student.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.ObjectModel;

namespace DataBindingDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Student
    {
        // The default constructor is required for creation from XAML.
        public Student()
        {
        }

        // The StudentName property is a string that holds the first and last name.
        public string StudentName { get; set; }

        // The IsEnrolled property gets or sets a value indicating whether
        // the student is currently enrolled.
        public bool IsEnrolled { get; set; }
    }

    // The StudentList collection is declared for convenience,
    // because declaring generic types in XAML is inconvenient.
    public class StudentList : ObservableCollection<Student>
    {

    }
}
