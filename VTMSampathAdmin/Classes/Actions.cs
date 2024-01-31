using FontAwesome.WPF;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using VTMSampathAdmin.Classes.BackendDataLoading;
using VTMSampathAdmin.Previews;
using VTMSampathAdmin.UserControlls;
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.Classes
{
    public static class Actions
    {
        //connection
        private const string _settingsPath = @"C:/conf/sampath_vtm_setting.xml";
        public static string IP { get; set; }
        //



        //dashboard user controls
        public static DashBoardContentUserControl DashBoardContentUserControl { get; set; }

        //purpose selectiom
        public static PurposeEnum Purpose { get; set; }


        public static string AgentName { get; set; }
        public static string AgentBranch { get; set; }
        public static bool IsOnline { get; set; } = false;
        public static MainWindow MainWindow { get; set; }

        //userdata capturing - session inputs
        public static bool IsNewCustomer { get; set; } = false;
        public static string CustomerMobileNumberToVerify { get; set; } = "";


        //Application List Handle
        public static void LoadJsonDataAndUpdateTable(string json, FlowDocumentReader tblDataTable, UserControl userControl, string keyWord = "All")
        {

            List<ApplicationTableClass> applicationList = JsonConvert.DeserializeObject<List<ApplicationTableClass>>(json);

            MessageBox.Show("");

            /*if (keyWord == "All")
            {
                var allRows = rowDataList
                        .Select(rowData =>
                        {
                            TableRow row = new TableRow();

                            row.Cells.Add(CreateTableCell(rowData.AccNo));
                            row.Cells.Add(CreateTableCell(rowData.NIC));
                            row.Cells.Add(CreateTableCell(rowData.MobileNo));
                            row.Cells.Add(CreateTableCell(rowData.DebitCard));
                            row.Cells.Add(CreateTableCell(rowData.Date));

                            //state handle
                            TableCell stateColored = CreateTableCell(rowData.State);

                            if (rowData.State == "Complete")
                            {
                                stateColored.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33CC33"));
                            }
                            else if (rowData.State == "Incomplete")
                            {
                                stateColored.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#757575"));
                            }
                            else
                            {
                                stateColored.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF505A"));
                            }
                            stateColored.FontWeight = FontWeights.DemiBold;
                            row.Cells.Add(stateColored);

                            // button create and add
                            Button actionButton = new Button()
                            {
                                Content = "View",
                                HorizontalContentAlignment = HorizontalAlignment.Center,
                                VerticalContentAlignment = VerticalAlignment.Center,
                                Width = 100,
                                Height = 25
                            };

                            actionButton.Style = (Style)userControl.FindResource("NoMouseOverStyleButton2");
                            actionButton.Click += (sender, e) => HandleButtonClick(rowData, rowData.State);

                            TableCell actionCell = new TableCell(new Paragraph(new InlineUIContainer(actionButton)));
                            row.Cells.Add(actionCell);

                            row.Style = (Style)userControl.FindResource("RowStyle1");

                            foreach (TableCell cell in row.Cells)
                            {
                                cell.LineHeight = 35;
                                cell.BorderBrush = Brushes.White;
                                cell.BorderThickness = new Thickness(0, 0, 0, 2);
                                cell.Padding = new Thickness(0, 10, 0, 0);
                            }

                            return row;

                        }).ToList();

                var tableAll = (tblDataTable.Document as FlowDocument)?.Blocks.FirstBlock as Table;
                var rowGroupAll = tableAll.RowGroups[0];

                foreach (var allRow in allRows)
                {
                    rowGroupAll.Rows.Add(allRow);
                }
            }
            else
            {
                var filteredRows = rowDataList
                        .Where(rowData => rowData.State == keyWord)
                        .Select(rowData =>
                        {
                            TableRow row = new TableRow();

                            // Populate cells in the row
                            row.Cells.Add(CreateTableCell(rowData.AccNo));
                            row.Cells.Add(CreateTableCell(rowData.NIC));
                            row.Cells.Add(CreateTableCell(rowData.MobileNo));
                            row.Cells.Add(CreateTableCell(rowData.DebitCard));
                            row.Cells.Add(CreateTableCell(rowData.Date));

                            // button create and add
                            Button actionButton = new Button()
                            {
                                Content = "View",
                                HorizontalContentAlignment = HorizontalAlignment.Center,
                                VerticalContentAlignment = VerticalAlignment.Center,
                                Width = 100,
                                Height = 25
                            };

                            actionButton.Style = (Style)userControl.FindResource("NoMouseOverStyleButton2");
                            actionButton.Click += (sender, e) => HandleButtonClick(rowData, rowData.State);

                            TableCell actionCell = new TableCell(new Paragraph(new InlineUIContainer(actionButton)));
                            row.Cells.Add(actionCell);

                            row.Style = (Style)userControl.FindResource("RowStyle1");

                            foreach (TableCell cell in row.Cells)
                            {
                                cell.LineHeight = 35;
                                cell.BorderBrush = Brushes.White;
                                cell.BorderThickness = new Thickness(0, 0, 0, 2);
                                cell.Padding = new Thickness(0, 10, 0, 0);
                            }

                            return row;

                        }).ToList();

                var table = (tblDataTable.Document as FlowDocument)?.Blocks.FirstBlock as Table;
                var rows = table.RowGroups[0];

                foreach (var filteredRow in filteredRows)
                {
                    rows.Rows.Add(filteredRow);
                }
            }*/
        }



        #region APPLICATIONS TABLES ROW BY ROW HANDLING METHODS
        //applications Table methods
        public static TableCell CreateTableCell(string text)
        {
            return new TableCell(new Paragraph(new Run(text)))
            {
                LineHeight = 30,
                TextAlignment = TextAlignment.Center,

            };
        }

        //all applications
        public static void ApplicationsHandleButtonClick(EntityForApplicationButtonHandle entity)
        {

            MoreApplicationDetails completedApplication = new MoreApplicationDetails(entity);
            completedApplication.Show();









        }

        public static void ClearTableData(FlowDocumentReader flowDocument)
        {
            if (flowDocument != null && flowDocument.Document != null)
            {
                TableRowGroup rowGroup = ((Table)flowDocument.Document.Blocks.FirstBlock).RowGroups[0];
                for (int i = rowGroup.Rows.Count - 1; i > 0; i--)
                {
                    rowGroup.Rows.RemoveAt(i);
                }
            }
        }


        /*  public static void TableRow_MouseEnter(object sender, MouseEventArgs e)
          {
              if (sender is TableRow row)
              {
                  row.Background = Brushes.Red;
              }
          }

          public static void TableRow_MouseLeave(object sender, MouseEventArgs e)
          {
              if (sender is TableRow row)
              {
                  row.ClearValue(TableRow.BackgroundProperty);
              }
          }*/

        #endregion




        //validations
        public static void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        //load setting file data
        public static bool LoadSettings()
        {
            try
            {
                var xml = XDocument.Load(_settingsPath);
                var nodes = (from n in xml.Descendants("base").
                    Where(r => r.Parent.Attribute("name").Value == "vtm-agent-application")
                             select new
                             {
                                 IP = n.Element("IP").Value,

                             }).ToList();
                foreach (var item in nodes)
                {

                    IP = item.IP;

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static MainWindow FindAndLoadMainWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is MainWindow)
                {
                    return (MainWindow)window;
                }
            }

            return null;
        }


      /*  internal static void CheckCircle(ImageAwesome imageAwesome, Button button, UserControl userControl)
        {
            userControl.Dispatcher.Invoke(() =>
            {
                imageAwesome.Icon = FontAwesomeIcon.CheckCircle;
                button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
            });

        }*/

        internal static void CheckCircle(ImageAwesome imageAwesome)
        {
           
                imageAwesome.Icon = FontAwesomeIcon.CheckCircle;
                //button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
           
        }


        //control the usercontrol dictionary
        public static void BackToPreviousUserController<T>(string key) where T : UserControl
        {
            try
            {
                T previousUC = (T)UserControlsHandlerClass.GetUserControl(key);
                ShowUserControlInCallViewBaseUserControl(previousUC);
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("No Stored User Control for " + key, "User Control Not Found Error", MessageBoxButton.OK, MessageBoxImage.Question);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public static void GoToNewUserController<T>(string key) where T : UserControl, new()
        {
            try
            {
                T newUC = new T();
                UserControlsHandlerClass.AddUserControl(key, newUC);
                ShowUserControlInCallViewBaseUserControl(newUC);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


            

        }


        private static void ShowUserControlInCallViewBaseUserControl(UserControl userControl)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(userControl);
                });
            }
        }



        //handle BASE64
        public static string ConvertImageToBase64(string imagePath)
        {
            byte[] imageArray = File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageArray);
        }

        public static void AccessAndChangeCheckCircleOfUserControl<T>(string key, string name) where T : UserControl
        {
            try
            {
                T userControl = (T)UserControlsHandlerClass.GetUserControl(key);
                if(userControl != null)
                {
                    ImageAwesome checknbox = FindChildBtnIcon(userControl, name);
                    if (checknbox != null)
                    {
                        CheckCircle(checknbox);
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("No Stored User Control for " + key, "User Control Not Found Error", MessageBoxButton.OK, MessageBoxImage.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private static ImageAwesome FindChildBtnIcon(DependencyObject parent, string childName)
        {
            if (parent != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                    if (child is ImageAwesome imageAwesome && imageAwesome.Name == childName)
                    {
                        return imageAwesome;
                    }

                    ImageAwesome result = FindChildBtnIcon(child, childName);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }

            return null;
        }



    }
}
