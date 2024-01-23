using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using VTMSampathAdmin.Classes.ApplicationTables;

namespace VTMSampathAdmin.Classes.BackendDataLoading
{
    class ApplicationData : IApplicationData
    {
        public async Task LoadAllAppliactionData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl, DateRangeClass dateRange)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //Serialize the object to a JSON string
                    string jsonContentDateRange = JsonConvert.SerializeObject(dateRange);
                    HttpContent content = new StringContent(jsonContentDateRange, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(endpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();


                        ApiResponse<ApplicationTableClass.DataArray> apiResponse = JsonConvert.DeserializeObject<ApiResponse<ApplicationTableClass.DataArray>>(jsonContent);
                        List<ApplicationTableClass.DataArray> applicationList = apiResponse?.Data;


                        var allRows = applicationList.Select(rowData =>
                        {
                            TableRow row = new TableRow();

                            row.Cells.Add(Actions.CreateTableCell(rowData.AccountNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.NicNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.MobileNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.DebitCardStatus.ToString()));
                            row.Cells.Add(Actions.CreateTableCell(rowData.CreatedAt.ToString()));

                            //state handle
                            TableCell stateColored = Actions.CreateTableCell(rowData.ApplicationStatus);

                            if (rowData.ApplicationStatus == "complete")
                            {
                                stateColored.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33CC33"));
                            }
                            else if (rowData.ApplicationStatus == "incomplete")
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

                            EntityForApplicationButtonHandle entity = new EntityForApplicationButtonHandle
                            {
                                Id = rowData.Id,
                                ApplicationStatus = rowData.ApplicationStatus
                            };
                            actionButton.Click += (sender, e) => Actions.ApplicationsHandleButtonClick(entity);

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public async Task LoadCompletedApplicationData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl, DateRangeClass dateRange)
        {
            using (HttpClient client = new HttpClient())
            {
                //Serialize the object to a JSON string
                string jsonContentDateRange = JsonConvert.SerializeObject(dateRange);
                HttpContent content = new StringContent(jsonContentDateRange, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(endpoint, content);


                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();


                        ApiResponse<ApplicationCompletedTableClass.DataArray> apiResponse = JsonConvert.DeserializeObject<ApiResponse<ApplicationCompletedTableClass.DataArray>>(jsonContent);
                        List<ApplicationCompletedTableClass.DataArray> applicationList = apiResponse?.Data;


                        var allRows = applicationList.Select(rowData =>
                        {
                            TableRow row = new TableRow();

                            row.Cells.Add(Actions.CreateTableCell(rowData.AccountNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.NicNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.MobileNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.DebitCardStatus.ToString()));
                            row.Cells.Add(Actions.CreateTableCell(rowData.CreatedAt.ToString()));


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

                            EntityForApplicationButtonHandle entity = new EntityForApplicationButtonHandle
                            {
                                Id = rowData.Id,
                                ApplicationStatus = "complete"
                            };
                            actionButton.Click += (sender, e) => Actions.ApplicationsHandleButtonClick(entity);
                      

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public async Task LoadIncompletedApplicationData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl, DateRangeClass dateRange)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //Serialize the object to a JSON string
                    string jsonContentDateRange = JsonConvert.SerializeObject(dateRange);
                    HttpContent content = new StringContent(jsonContentDateRange, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(endpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();


                        ApiResponse<ApplicationIncompletedTableClass.DataArray> apiResponse = JsonConvert.DeserializeObject<ApiResponse<ApplicationIncompletedTableClass.DataArray>>(jsonContent);
                        List<ApplicationIncompletedTableClass.DataArray> applicationList = apiResponse?.Data;


                        var allRows = applicationList.Select(rowData =>
                        {
                            TableRow row = new TableRow();
                            row.Cells.Add(Actions.CreateTableCell(rowData.NicNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.MobileNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.RejectReason));
                            row.Cells.Add(Actions.CreateTableCell(rowData.CreatedAt.ToString()));


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

                            EntityForApplicationButtonHandle entity = new EntityForApplicationButtonHandle
                            {
                                Id = rowData.Id,
                                ApplicationStatus = "incomplete"
                            };
                            actionButton.Click += (sender, e) => Actions.ApplicationsHandleButtonClick(entity);


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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public async Task LoadRejectedApplicationData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl, DateRangeClass dateRange)
        {
            using (HttpClient client = new HttpClient())
            {

                try
                {
                    //Serialize the object to a JSON string
                    string jsonContentDateRange = JsonConvert.SerializeObject(dateRange);
                    HttpContent content = new StringContent(jsonContentDateRange, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(endpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();

                        ApiResponse<ApplicationRejectedTableClass.DataArray> apiResponse = JsonConvert.DeserializeObject<ApiResponse<ApplicationRejectedTableClass.DataArray>>(jsonContent);
                        List<ApplicationRejectedTableClass.DataArray> applicationList = apiResponse?.Data;


                        var allRows = applicationList.Select(rowData =>
                        {
                            TableRow row = new TableRow();
                            row.Cells.Add(Actions.CreateTableCell(rowData.NicNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.MobileNumber));
                            row.Cells.Add(Actions.CreateTableCell(rowData.RejectReason));
                            row.Cells.Add(Actions.CreateTableCell(rowData.CreatedAt.ToString()));


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

                            EntityForApplicationButtonHandle entity = new EntityForApplicationButtonHandle
                            {
                                Id = rowData.Id,
                                ApplicationStatus = "rejected"
                            };
                            actionButton.Click += (sender, e) => Actions.ApplicationsHandleButtonClick(entity);


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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public async Task<CompleteApplicationDetailsClass> LoadCompletedApplicationForId(string endpoint)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpContent content = new StringContent("");
                    HttpResponseMessage response = await client.PostAsync(endpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();

                        CompleteApplicationDetailsClass apiResponse = JsonConvert.DeserializeObject<CompleteApplicationDetailsClass>(jsonContent);



                        return apiResponse;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            return null;
        }

    }
}
