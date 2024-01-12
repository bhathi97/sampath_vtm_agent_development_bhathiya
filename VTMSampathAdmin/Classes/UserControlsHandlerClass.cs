using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace VTMSampathAdmin.Classes
{
    public static class UserControlsHandlerClass
    {
        /*public static int CurrentUserControl { get; set; }
        private static readonly ObservableCollection<UserControl> _userControls = new ObservableCollection<UserControl>();

        public static event NotifyCollectionChangedEventHandler CollectionChanged
        {
            add { _userControls.CollectionChanged += value; }
            remove { _userControls.CollectionChanged -= value; }
        }
        public static void Enqueue(UserControl userControl)
        {
            _userControls.Add(userControl);
        }*/


        private static Dictionary<string, UserControl> _userControlManager = new Dictionary<string, UserControl>();

        public static void AddUserControl(string key, UserControl userControl)
        {
            if (_userControlManager.ContainsKey(key))
            {
                _userControlManager.Remove(key);
            }
            _userControlManager.Add(key, userControl);
        }

        public static UserControl GetUserControl(string key)
        {
            if (_userControlManager.TryGetValue(key, out UserControl userControl))
            {
                return userControl;
            }
            else
            {
                return null;
            }
        }

        public static void DeleteUserControl(string key)
        {
            if (_userControlManager.ContainsKey(key))
            {
                _userControlManager.Remove(key);
            }
            else
            {

            }
        }




        //find specific user control - using VisualTreeHelper
        public static UIElement FindVisualChild(DependencyObject parent, Type targetType)
        {
            if (parent != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                    if (child != null && targetType.IsAssignableFrom(child.GetType()))
                    {
                        return (UIElement)child;
                    }

                    UIElement childItem = FindVisualChild(child, targetType);
                    if (childItem != null)
                    {
                        return childItem;
                    }
                }
            }
            return null;
        }

    }
}
