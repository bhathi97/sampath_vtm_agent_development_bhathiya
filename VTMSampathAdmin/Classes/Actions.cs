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
using System.Xml.Linq;
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

        public static string AgentName { get; set; }
        public static string AgentBranch { get; set; }
        public static bool IsOnline { get; set; } =  false;
        public static MainWindow MainWindow { get; set; }

        public static bool IsNewCustomer { get; set; } = false;

        //handle the purpose
        public struct PurposeSelect
        {
            public string a; //account open
            public string d; //debit card
            public string o; //other services
        }
        public static PurposeSelect PurposeSelectOptions = new PurposeSelect();
        public static string Purpose { get; set; }


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

        public static async Task LoadAllAppliactionData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl)
        {
            using(HttpClient client = new HttpClient())
            {

                HttpContent content = new StringContent("");

                HttpResponseMessage response = await client.PostAsync(endpoint, content);

                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();


                        ApiResponse<ApplicationTableClass.DataArray> apiResponse = JsonConvert.DeserializeObject<ApiResponse<ApplicationTableClass.DataArray>>(jsonContent);
                        List<ApplicationTableClass.DataArray> applicationList = apiResponse?.Data;


                        var allRows = applicationList.Select(rowData =>
                        {
                            TableRow row = new TableRow();

                            row.Cells.Add(CreateTableCell(rowData.AccountNumber));
                            row.Cells.Add(CreateTableCell(rowData.NicNumber));
                            row.Cells.Add(CreateTableCell(rowData.MobileNumber));
                            row.Cells.Add(CreateTableCell(rowData.DebitCardStatus.ToString()));
                            row.Cells.Add(CreateTableCell(rowData.CreatedAt.ToString()));

                            //state handle
                            TableCell stateColored = CreateTableCell(rowData.ApplicationStatus);

                            if (rowData.ApplicationStatus == "Complete")
                            {
                                stateColored.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33CC33"));
                            }
                            else if (rowData.ApplicationStatus == "Incomplete")
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
                            actionButton.Click += (sender, e) => HandleButtonClick(rowData, rowData.ApplicationStatus);

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
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
        }

        
        private static TableCell CreateTableCell(string text)
        {
            return new TableCell(new Paragraph(new Run(text)))
            {
                LineHeight = 30,
                TextAlignment = TextAlignment.Center,

            };
        }

        private static void HandleButtonClick(ApplicationTableClass.DataArray rowData, string state)
        {

            if (state == "Complete")
            {
                CompletedApplication completedApplication = new CompletedApplication();
                completedApplication.Show();



            }


        }

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

        /*public static MainWindow FindAndLoadMainWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is MainWindow)
                {
                    return (MainWindow)window;
                }
            }

            return null;
        }*/

        /* private static CustomContainerForMainWindow FindCustomContainerInVisualTree(DependencyObject parent)
         {
             if (parent == null) return null;

             int childCount = VisualTreeHelper.GetChildrenCount(parent);

             for (int i = 0; i < childCount; i++)
             {
                 DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                 if (child is CustomContainerForMainWindow customContainer)
                 {
                     return customContainer;
                 }

                 CustomContainerForMainWindow result = FindCustomContainerInVisualTree(child);

                 if (result != null)
                 {
                     return result;
                 }
             }

             return null;
         }*/


    }
}
