<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script>
            function OnCommandExecuted(s, e) {
                if (e.commandName == "Open")
                    popupFM.ShowAtPos(100, 100);
            }

        var postponedCallbackRequired = false;
        function OnSelectedFileChanged(s, e) {
            if (e.file) {
                if (!richEdit.InCallback())
                    richEdit.PerformCallback();
                else
                    postponedCallbackRequired = true;
            }
            popupFM.Hide();
        }

        function OnRichEditEndCallback(s, e) {
            if (postponedCallbackRequired) {
                s.PerformCallback();
                postponedCallbackRequired = false;
            }
        }
        function OnExceptionOccurred(s, e) {
            e.handled = true;
            alert(e.message);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
           <dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" OnCallback="ASPxRichEdit1_Callback" ClientInstanceName="richEdit" >
             <Settings>
                 <Behavior Save="Disabled" SaveAs="Disabled" />
             </Settings>
            <ClientSideEvents CustomCommandExecuted="OnCommandExecuted" EndCallback="OnRichEditEndCallback"/>
        </dx:ASPxRichEdit>
        
        <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" Width="1000px" Height="100px" ClientInstanceName="popupFM">
            <ContentCollection>
                <dx:PopupControlContentControl>
                    <dx:ASPxFileManager ID="FileManager" runat="server">
                    <settings rootfolder="Rich_documents" thumbnailfolder="~/Thumb/" AllowedFileExtensions=".docx,.doc,.rtf,.txt"></settings>
                        <ClientSideEvents SelectedFileChanged="OnSelectedFileChanged" CallbackError="OnExceptionOccurred"/>
                </dx:ASPxFileManager>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
    </form>
</body>
</html>
