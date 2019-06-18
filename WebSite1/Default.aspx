<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
    </form>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
<Columns>
    <asp:TemplateField HeaderText="Name" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblId" runat="server" Text='<%# Eval("CustomerId") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Name" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Country" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("Country") %>'></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>
</Columns>
</asp:GridView>
</body>
</html>
