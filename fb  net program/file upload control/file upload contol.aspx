<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="file upload contol.aspx.cs" Inherits="file_upload_control.file_upload_contol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />

        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" /><br />
        <asp:DropDownList ID="DdlPicturse" runat="server" AutoPostBack="true">
        </asp:DropDownList>
       <br />
         <asp:Image ID="Image1" runat="server" Height="170px" Width="319px" />
    </div>
    </form>
</body>
</html>
