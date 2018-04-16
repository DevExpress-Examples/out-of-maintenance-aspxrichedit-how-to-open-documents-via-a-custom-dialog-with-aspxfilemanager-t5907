Option Infer On

Imports DevExpress.Web
Imports DevExpress.Web.ASPxThemes
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		ASPxRichEdit1.CreateDefaultRibbonTabs(True)
		ASPxRichEdit1.RibbonTabs(0).Groups(0).Items.RemoveAt(1)
		Dim openItem = New RibbonButtonItem("Open")
		openItem.LargeImage.IconID = IconID.ActionsOpen32x32
		openItem.Size = RibbonItemSize.Large
		ASPxRichEdit1.RibbonTabs(0).Groups(0).Items.Add(openItem)

		If Not IsPostBack Then
			Dim file As FileManagerFile = FileManager.SelectedFolder.GetFiles().FirstOrDefault()
			If file IsNot Nothing Then
				FileManager.SelectedFile = file
				ASPxRichEdit1.Open(Server.MapPath(file.FullName))
			End If
		End If
	End Sub
	Protected Sub ASPxRichEdit1_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		If FileManager.SelectedFile IsNot Nothing Then
			ASPxRichEdit1.Open(Server.MapPath(FileManager.SelectedFile.FullName))
		End If
	End Sub


End Class