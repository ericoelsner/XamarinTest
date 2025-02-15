﻿using System.Collections.ObjectModel;
using System.Security;
using Xamarin.Forms;
using XFDelivery.Models;

namespace XFDelivery.Service
{
    public class DataService
    {
        
        // Add group as static attributes
        public static Group All = new Group()
        {
            description = "All",
            image = "brigadeiro",
            selected = true,
            backgroundColor = Color.FromHex("#FF8920")
        };

        public static Group Pizza = new Group()
        {
            description = "Pizza",
            image = "pizza",
            selected = false,
            backgroundColor = Color.FromHex("#FFFFFF")
        };

        public static Group Burgers = new Group()
        {
            description = "Burgers",
            image = "burger",
            selected = false,
            backgroundColor = Color.FromHex("#FFFFFF")
        };

        public static Group Asian = new Group()
        {
            description = "Asian",
            image = "junk_food",
            selected = false,
            backgroundColor = Color.FromHex("#FFFFFF")
        };

        public static ObservableCollection<Group> GetGroups()
        {   

            return new ObservableCollection<Group>()
            {
                // Add previously defined groups
                All, Pizza, Burgers, Asian

                // Not needed
                //new Group()
                //{
                //     description = "All",
                //     image = "brigadeiro",
                //     selected = true,
                //     backgroundColor = Color.FromHex("#FF8920")
                //},
                //new Group()
                //{
                //    description = "Pizza",
                //    image = "pizza",
                //    selected = false,
                //     backgroundColor = Color.FromHex("#FFFFFF")
                //},
                //new Group()
                //{
                //    description = "Burgers",
                //    image = "burger",
                //    selected = false,
                //     backgroundColor = Color.FromHex("#FFFFFF")
                //},
                //new Group()
                //{
                //    description = "Asian",
                //    image = "junk_food",
                //    selected = false,
                //    backgroundColor = Color.FromHex("#FFFFFF")
                //}
            };
        }

        public static ObservableCollection<Item> GetItems()
        {
            return new ObservableCollection<Item>()
            {
                new Item()
                {
                     description = "Margherita",
                     complement = "Tomato sauce, fresh mozzarella, olive oil, fresh basi",
                     image = "item1",
                     calories = 76,
                     price = 45,
                     rating = 4.2,
                     favorite = true,

                     // Add Group
                     group = Pizza
                },
                new Item()
                {
                     description = "Rughetta",
                     complement = "Arugula, Cherry Tomatoes, Artichokes, Shaved Parmigiano, Lemon/E.V.O.O. Dressing",
                     calories = 70,
                     image = "item2",
                     price = 59,
                     rating = 3.8,
                     favorite = false,

                     // Add Group
                     group = Pizza
                },
                new Item()
                {
                     description = "Banoffie Pie",
                     complement = "Breaded chicken, ham and bacon, drizzled with homemade rach",
                     image = "item3",
                     calories = 85,
                     rating = 4.9,
                     price = 106,
                     favorite = true,

                     // No matching group, so add generic 'All' group to avoid null-exceptions
                     group = All
                },
            };
        }
    }
}
