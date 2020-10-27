# How to change the default theme color of Xamarin.Forms DataGrid (SfDataGrid)

## About the sample

This example illustrates how to change the default theme color of Xamarin.Forms DataGrid (SfDataGrid).

By default, the SfDataGrid does not have a support to change the default theme color. But we can do this by using the QueryCellStyle event of the SfDataGrid and then apply the desired color on QueryCellStyle. 

```XAML
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DataGridDemo"
             xmlns:sfgrid="clr-namespace:Syncfusion.SfDataGrid.XForms;assembly=Syncfusion.SfDataGrid.XForms"
             xmlns:sfPager="clr-namespace:Syncfusion.SfDataGrid.XForms.DataPager;assembly=Syncfusion.SfDataGrid.XForms"
             x:Class="DataGridDemo.MainPage">

    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>
    <Grid>
        <sfgrid:SfDataGrid x:Name="dataGrid" RowHeight="70"
            AllowGroupExpandCollapse="True" 
            AllowResizingColumn="True" 
            AllowSorting="True" 
            AutoGenerateColumns="True" 
            ItemsSource="{Binding OrdersInfo}">
        </sfgrid:SfDataGrid>
    </Grid>
</ContentPage>

```
 

```C#
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
```


## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
