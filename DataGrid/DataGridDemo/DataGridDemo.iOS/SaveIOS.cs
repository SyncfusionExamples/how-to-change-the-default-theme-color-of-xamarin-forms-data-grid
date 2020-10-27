using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using static DataGridDemo.MainPage;
using System.IO;
using QuickLook;
using DataGridDemo;
using DataGridDemo.iOS;

//[assembly: Xamarin.Forms.Dependency(typeof(SaveIOS))]

namespace DataGridDemo.iOS
{
    //class SaveIOS:ISave
    //{
    //    public void Save(string filename, string contentType, MemoryStream stream)
    //    {
    //        string exception = string.Empty;
    //        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    //        string filePath = Path.Combine(path, filename);
    //        try
    //        {
    //            FileStream fileStream = File.Open(filePath, FileMode.Create);
    //            stream.Position = 0;
    //            stream.CopyTo(fileStream);
    //            fileStream.Flush();
    //            fileStream.Close();
    //        }
    //        catch (Exception e)
    //        {
    //            exception = e.ToString();
    //        }
    //        if (contentType == "application/html" || exception != string.Empty)
    //            return;
    //        UIViewController currentController = UIApplication.SharedApplication.KeyWindow.RootViewController;
    //        while (currentController.PresentedViewController != null)
    //            currentController = currentController.PresentedViewController;
    //        UIView currentView = currentController.View;

    //        QLPreviewController qlPreview = new QLPreviewController();
    //        QLPreviewItem item = new QLPreviewItemBundle(filename, filePath);
    //        qlPreview.DataSource = new PreviewControllerDS(item);

    //        //UIViewController uiView = currentView as UIViewController;

    //        currentController.PresentViewController((UIViewController)qlPreview, true, (Action)null);
    //    }
    //}

    //public class QLPreviewItemBundle : QLPreviewItem
    //{
    //    string _fileName, _filePath;
    //    public QLPreviewItemBundle(string fileName, string filePath)
    //    {
    //        _fileName = fileName;
    //        _filePath = filePath;
    //    }

    //    public override string ItemTitle
    //    {
    //        get
    //        {
    //            return _fileName;
    //        }
    //    }
    //    public override NSUrl ItemUrl
    //    {
    //        get
    //        {
    //            var documents = NSBundle.MainBundle.BundlePath;
    //            var lib = Path.Combine(documents, _filePath);
    //            var url = NSUrl.FromFilename(lib);
    //            return url;
    //        }
    //    }
    //}

    //public class PreviewControllerDS : QLPreviewControllerDataSource
    //{
    //    private QLPreviewItem _item;

    //    public PreviewControllerDS(QLPreviewItem item)
    //    {
    //        _item = item;
    //    }

    //    public override nint PreviewItemCount(QLPreviewController controller)
    //    {
    //        return (nint)1;
    //    }

    //    public override IQLPreviewItem GetPreviewItem(QLPreviewController controller, nint index)
    //    {
    //        return _item;
    //    }
    //}
}