<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545456/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590790)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))**
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxRichEdit - How to open documents via a custom dialog with ASPxFileManager
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t590790/)**
<!-- run online end -->


<p>Currently, ASPxRichEdit doesn't provide the capability to customize the file selector used in the Open command's dialog. This example illustrates a possible workaround which allows a user to open documents by using a custom dialog with the ASPxFileManager control configured according to your requirements.<br><br>To implement this scenario, a custom Open ribbon button which opens a custom popup dialog is introduced instead of the default one. The currently selected ASPxFileManager document is opened in ASPxRichEdit by initiating its custom callback via the client-side <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.ASPxClientRichEdit.PerformCallback.overloads">PerformCallback</a> method and by calling the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.Open.overloads">Open</a> method in the server-side <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.Callback.event">Callback</a> event handler.</p>

<br/>


