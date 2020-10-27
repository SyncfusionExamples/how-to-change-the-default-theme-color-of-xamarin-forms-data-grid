using Syncfusion.XForms.Themes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace DataGridDemo.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Syncfusion.SfDataGrid.XForms.UWP.SfDataGridRenderer.Init();
            ThemeSelectorService.SetRequestedThemeAsync(ElementTheme.Dark);
            LoadApplication(new DataGridDemo.App());
        }
    }

    public static class ThemeSelectorService
    {

        public static async Task SetRequestedThemeAsync(ElementTheme Theme)
        {
            foreach (var view in CoreApplication.Views)
            {
                await view.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (Window.Current.Content is FrameworkElement frameworkElement)
                    {
                        frameworkElement.RequestedTheme = Theme;

                        ICollection<Xamarin.Forms.ResourceDictionary> mergedDictionaries = Xamarin.Forms.Application.Current.Resources.MergedDictionaries;
                        if (Theme == ElementTheme.Dark)
                        {
                            mergedDictionaries.Clear();
                            mergedDictionaries.Add(new DarkTheme());
                        }
                        else if (Theme == ElementTheme.Light)
                        {
                            mergedDictionaries.Clear();
                            mergedDictionaries.Add(new LightTheme());
                        }
                    }
                });
            }
        }
    }
}
