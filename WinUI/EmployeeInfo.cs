using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI_TreeGrid
{
    public class Employee : NotificationObject
    {
        #region Private Fields

        private static int _globalId = 0;
        private int _id;
        private string _firstName;
        private string _lastName;
        private double? _salary;
        private string city;
        private double _hike = 5;
        private string _cityDescription;
        private ObservableCollection<Employee> _children;


        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>The children.</value>
        public ObservableCollection<Employee> Children
        {
            get
            {
                return _children;
            }
            set
            {
                _children = value;
            }
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets the Salary.
        /// </summary>
        /// <value>Salary</value>
        public double? Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                RaisePropertyChanged("Salary");
            }
        }
        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        /// <value>City</value>      

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                RaisePropertyChanged("City");
            }
        }

        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        /// <value>Country</value>
        public string CityDescription
        {
            get
            {
                return _cityDescription;
            }
            set
            {
                _cityDescription = value;
                RaisePropertyChanged("CityDescription");
            }
        }

        private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                contactNumber = value;
                RaisePropertyChanged("ContactNumber");
            }
        }
        /// <summary>
        /// Gets or sets the hike
        /// </summary>
        /// <value>The hike.</value>
        public double Hike
        {
            get
            {
                return _hike;
            }
            set
            {
                _hike = value;
                RaisePropertyChanged("Hike");
            }
        }

        private bool isAvailable = false;

        public bool IsAvailable
        {
            get { return isAvailable; }
            set
            {
                isAvailable = value;
                RaisePropertyChanged("IsAvailable");
            }
        }
        #endregion

        #region Constructors


        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeInfo"/> class.
        /// </summary>
        public Employee()
            : this("Enter FirstName", "Enter LastName", false, 1, 78998, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeInfo"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="eyecolor">The eyecolor.</param>
        /// <param name="dob">The dob.</param>
        /// <param name="maxGenerations">The max generations.</param>
        public Employee(string firstName, string lastName, bool availablility, int id, double? sal, ObservableCollection<Employee> child)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = sal;
            IsAvailable = availablility;
            Id = id;
            Children = child;
        }

        #endregion Constructors
    }
}
