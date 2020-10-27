using Syncfusion.SfDataGrid.XForms.DataPager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.SfDataGrid.XForms;
using Syncfusion.Data;
using System.Reflection;
using System.Globalization;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using System.Diagnostics;
using Syncfusion.XForms.Themes;

namespace DataGridDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataGrid.QueryCellStyle += DataGrid_QueryCellStyle;
        }

        private void DataGrid_QueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            var darkTheme = mergedDictionaries.OfType<DarkTheme>().FirstOrDefault();
            if (darkTheme != null)
            {
                e.Style.ForegroundColor = Color.FromHex("#FFFFFFFF");
                e.Handled = true;
            }
        }
    }
}
