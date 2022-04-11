<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutorisationForm.aspx.cs" Inherits="Lab3.AutorisationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <style>
        .container {
            max-width: 800px;
            margin: 0 auto;
        }

        .wrapper{
            margin-top: 100px;
            text-align:center;
        }

        .password{
            margin-bottom: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="wrapper">
                <div class="login">
                    <p>Введіть логін</p>
                    <asp:TextBox ID="login" runat="server" Width="190px" ></asp:TextBox>
                </div>
                <div class="password">
                    <p>Введіть пароль</p>
                    <asp:TextBox ID="pass" runat="server" Width="190px" TextMode="Password"></asp:TextBox>
                </div>
                 <asp:Button ID="Enter" runat="server" OnClick="Enter_Click" Text="Увійти" Width="86px" />
            </div>
        </div>
    </form>
</body>
</html>
