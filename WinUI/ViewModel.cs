﻿using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Grids;
using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;

namespace WinUI_TreeGrid
{
    public class EmployeeRepository
    {
        private static Random random = new Random(123123);
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public EmployeeRepository()
        {
            this.EmployeeDetails = this.CreateGenericPersonData(5, 3);
            CityCollection = new ObservableCollection<string>();
            foreach (var item in city)
            {
                CityCollection.Add(item);
            }
        }

        private ObservableCollection<Employee> _EmployeeDetails;

        /// <summary>
        /// Gets or sets the person details.
        /// </summary>
        /// <value>The person details.</value>
        public ObservableCollection<Employee> EmployeeDetails
        {
            get { return _EmployeeDetails; }
            set { _EmployeeDetails = value; }
        }

        private ObservableCollection<string> cityCollection;

        public ObservableCollection<string> CityCollection
        {
            get { return cityCollection; }
            set { cityCollection = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <param name="maxGenerations">The max generations.</param>
        public EmployeeRepository(int count, int maxGenerations)
        {
            CreateGenericPersonData(count, maxGenerations);
        }

        /// <summary>
        /// Creates the child list.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <param name="maxGenerations">The max generations.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public ObservableCollection<Employee> CreateChildList(int count, int maxGenerations, string lastName)
        {
            ObservableCollection<Employee> _children = new ObservableCollection<Employee>();
            if (count > 0 && maxGenerations > 0)
            {
                _children = CreateGenericPersonData(count, maxGenerations - 1);
                //foreach (Employee p in _children)
                //    p.LastName = lastName;
            }
            return _children;
        }

        /// <summary>
        /// Creates the generic person data.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <param name="maxGenerations">The max generations.</param>
        /// <returns></returns>
        public ObservableCollection<Employee> CreateGenericPersonData(int count, int maxGenerations)
        {
            var personList = new ObservableCollection<Employee>();
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    var lastname = names2[random.Next(names2.GetLength(0))];
                    personList.Add(new Employee()
                    {
                        FirstName = names1[random.Next(names1.GetLength(0))],
                        LastName = lastname,
                        Children = this.CreateChildList(count, (int)Math.Max(0, maxGenerations - 1), lastname),
                        Id = 1000 + i,
                        Salary = 30000d + random.Next(9) * 10000,
                        CityDescription = city[random.Next(city.GetLength(0))],
                        City = city[random.Next(city.GetLength(0))],
                        IsAvailable = random.Next(100) % 3 == 0 ? true : false,
                        ContactNumber = random.Next(999111, 999119).ToString(),
                        Hike = hike[random.Next(hike.GetLength(0))],

                    });
                }
            }
            return personList;
        }

        /// <summary>
        /// Generates the random date.
        /// </summary>
        /// <returns></returns>
        private DateTime GenerateRandomDate()
        {
            int randInt = random.Next(4000);
            return DateTime.Now.AddDays(-8000 + randInt);
        }

        string[] city = new string[]
        {
            "NewYork",
            "San Francisco",
            "Delhi",
            "Brisbane",
            "Tokyo",
            "Rome",
            "Durban",
            "Canberra",
            "Sydney",
            "London",
            "Manchester",
            "Birmingham",
            "Liverpool",
            "Cardiff",
            "Adelaide",
            "Perth",
            "Zurich",
            "Madrid",
            "Barcelona"
        };
        #region Array Collection

        private static string[] names1 = new string[]{
            "George","John","Thomas","James","Andrew","Martin","William","Zachary",
            "Millard","Franklin","Abraham","Ulysses","Rutherford","Chester","Grover","Benjamin",
            "Theodore","Woodrow","Warren","Calvin","Herbert","Franklin","Harry","Dwight","Lyndon",
            "Richard","Gerald","Jimmy","Ronald","George","Bill", "Barack", "Warner","Peter", "Larry"
        };
        private static string[] names2 = new string[]{
             "Monroe","Jackson","Tyler","Fillmore","Lincoln","Johnson","Grant","Hayes","Garfield",
            "Coolidge","Carter"
        };
        private static string[] color = new string[]{
            "Red", "Blue", "Brown", "Unknown"
        };

        private static double[] hike = new double[]{
            6,5.5,10,10.2,11, 15, 6.8,14,7.7,9.5,8.2,16
        };
        #endregion
    }
}
