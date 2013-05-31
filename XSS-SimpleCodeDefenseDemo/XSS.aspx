<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XSS.aspx.cs" ValidateRequest="false" Inherits="XSS_SimpleCodeDefenseDemo.XSS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Input Data:"></asp:Label>
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <asp:Button ID="cmdBad" runat="server" Text="Bad" onclick="cmdBad_Click" />
        <asp:Button ID="cmdBetter" runat="server" Text="Better" 
            onclick="cmdBetter_Click" />
        <asp:Button ID="cmdBest" runat="server" Text="Best" onclick="cmdBest_Click" />
    </div>
    </form>
</body>
</html>
