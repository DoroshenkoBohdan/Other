<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="Lab3.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Дані</title>

    <style>
        .container{
            width: 50%;
            margin: 0 auto;
        }

        .wrapper {
            text-align:center;
            display:flex;
            justify-content:space-between;
            align-items: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">
            <div class="wrapper">
                <div>
                    <asp:GridView ID="data_doctors" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>

                <div>
                    <asp:GridView ID="data_patients" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>
                <div>
                    <asp:ListBox id="depart" 
                       Rows="4"
                       Width="100px"
                       SelectionMode="Single" 
                       runat="server" 
                       placeholder="Відділення">
                    </asp:ListBox>
                    <br />
                    <br />
                    <asp:ListBox id="year" 
                       Rows="4"
                       Width="100px"
                       SelectionMode="Single" 
                       runat="server" 
                       placeholder="Відділення">
                    </asp:ListBox>
                    <br />
                    <br />
                    <asp:Button ID="task1" runat="server" OnClick="Task1_Click"  Text="Завдання 1" Width="86px" />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="task2" runat="server" OnClick="Task2_Click"  Text="Завдання 2" Width="86px" />
                </div>
            </div>
         </div>
    </form>
</body>
</html>
