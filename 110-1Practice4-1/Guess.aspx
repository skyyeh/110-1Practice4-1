<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Guess.aspx.cs" Inherits="_110_1Practice4_1.Guess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
               <div>
            <asp:Label ID="lb_Num" runat="server" Text="已打碼(不重複的四個數字)"></asp:Label>
            <asp:Label ID="lb_Res" runat="server" Text="" Visible="false"></asp:Label>
            <asp:Button ID="btn_ShowNum" runat="server" Text="顯示數字結果" OnClick="btn_ShowNum_Click"/>
            <br />
            <asp:Label runat="server" Text="剩餘猜題次數" />
            <asp:TextBox ID="tb_Rem" runat="server" Text="3" ReadOnly="true"/>
            <br />
            <asp:Label runat="server" Text="請猜數字" />
            <asp:TextBox ID="tb_Num" runat="server" AutoPostBack="True" OnTextChanged="tb_Num_TextChanged"></asp:TextBox>
            <br />
            <asp:HyperLink ID="hk_Link" runat="server" NavigateUrl="Guess.aspx" Target="_top">重新開始</asp:HyperLink>
            <br />
            <asp:Label ID="lb_Msg" runat="server" Text="" />
        </div>
    </form>
</body>
</html>
