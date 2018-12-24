<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="KnowledgeSystem.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>level struct</title>
     <link rel="stylesheet" href="style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="fRow" style="border:1px solid blue">
        
        <div>
            <fieldset>
   <legend>Cписок Елементів</legend>
            <asp:Button CssClass="myBtn" ID="findallContacts" runat="server" OnClick="findallContacts_Click" Text="Show the list" />
                </fieldset>
            <hr />
            <asp:Literal ID="ltrContacts" runat="server" />
        </div>
        <hr />
        <asp:Label ID="lblErrorMessage" runat="server" />
     
             <fieldset>
   <legend>Введіть дані</legend>
        ContactId:<br />
        <asp:TextBox ID="tb13" runat="server"></asp:TextBox>
        <br />
        <br />
        AuthorId:<br />
        <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
        <br />
        <br />
        Full Name:<br />
        <asp:TextBox ID="tb2" runat="server"></asp:TextBox>
        <br />
        <br />
        Place:<br />
        <asp:TextBox ID="tb3" runat="server"></asp:TextBox>
        <br />
        <br />
        City:<br />
        <asp:TextBox ID="tb4" runat="server"></asp:TextBox>
        <br />
        <br />
        Description:<br />
        <asp:TextBox ID="tb5" runat="server"></asp:TextBox>
        <br />
        <br />
        Number:<br />
        <asp:TextBox ID="tb8" runat="server"></asp:TextBox>
        <br />
        <br />
        Email:<br />
        <asp:TextBox ID="tb9" runat="server"></asp:TextBox>
        <br />
        <br />
        Room:<br />
        <asp:TextBox ID="tb10" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblErrorMessage0" runat="server" />
        <br />
        <br />
        <asp:Button CssClass="myBtn" ID="bt1" runat="server" OnClick="bt1_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button CssClass="myBtn" ID="bt2" runat="server" OnClick="bt2_Click" Text="Update" />
                 </fieldset>
              </div>
    <div class="sRow">
                <fieldset>
   <legend>Введіть дані, Delete</legend>
        
        ID:
        <asp:TextBox ID="tb11" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblErrorMessage1" runat="server" />
        <br />
        <asp:Button CssClass="myBtn" ID="bt3" runat="server" OnClick="bt3_Click" Text="Delete" />
        <br />
        <br />
                    </fieldset>
                    <fieldset>
   <legend>Введіть дані, Update</legend>
        Find:<br />
        ID:<br />
        <asp:TextBox ID="tb12" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblErrorMessage2" runat="server" />
        <br />
        <asp:Button CssClass="myBtn" ID="bt4" runat="server" OnClick="bt4_Click" Text="Find" />
        <br />
            <asp:Literal ID="ltrContacts0" runat="server" />
                        </fieldset>
         </div> 
    </form>
</body>
</html>
