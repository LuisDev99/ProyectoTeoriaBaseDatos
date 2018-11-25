<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Asp.net_Sign_Up.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>

    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <img src="Stock/Artboard Panel.png" class="panel" />
        </section>
        <div class="sec2">
            <div class="container">
                <div class="social">
                    <a href="https://www.fac
                        ebook.com"><asp:Image ID="Image1"  runat="server" ImageUrl="~/Stock/if_facebook_2308066.png" /></a>
                    <a href="https://plus.google.com"><asp:Image ID="Image2" runat="server" ImageUrl="~/Stock/if_google-plus_2308064.png" /></a>
                </div>

                <div class="content">
                    <h2>Entrar al mejor proyecto</h2>

                    <asp:TextBox ID="TextBox1" placeholder="Username" runat="server"></asp:TextBox><br />
                    <asp:TextBox ID="TextBox2" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox><br />
                    <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />

                    <asp:Label ID="Label1" Style="padding-left:4vw;padding-top:2vw;" Font-Size="Medium" ForeColor="red" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [login]"></asp:SqlDataSource>
</body>
</html>
