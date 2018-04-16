using DevExpress.Web;
using DevExpress.Web.ASPxThemes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ASPxRichEdit1.CreateDefaultRibbonTabs(true);
        ASPxRichEdit1.RibbonTabs[0].Groups[0].Items.RemoveAt(1);
        var openItem = new RibbonButtonItem("Open");
        openItem.LargeImage.IconID = IconID.ActionsOpen32x32;
        openItem.Size = RibbonItemSize.Large;
        ASPxRichEdit1.RibbonTabs[0].Groups[0].Items.Add(openItem);

        if (!IsPostBack)
        {
            FileManagerFile file = FileManager.SelectedFolder.GetFiles().FirstOrDefault();
            if (file != null)
            {
                FileManager.SelectedFile = file;
                ASPxRichEdit1.Open(Server.MapPath(file.FullName));
            }
        }
    }
    protected void ASPxRichEdit1_Callback(object sender, CallbackEventArgsBase e)
    {
        if (FileManager.SelectedFile != null)
            ASPxRichEdit1.Open(Server.MapPath(FileManager.SelectedFile.FullName));
    }

  
}