<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RSSReader.aspx.cs" Inherits="WebForsmsDemo.RSSReader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br><br>

    <asp:TextBox ID="txtUrl" runat="server" Height="16px" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="GetFiltr" Onclick="BtnGet_Click" style="background-color:greenyellow" />
    <div class="row">
        <div class="col-xs-6">   
      <asp:Repeater ID="Repeater1" runat="server" ItemType="WebForsmsDemo.Model.RssItem">
        <ItemTemplate>
         
            <h3><%# Item.Title %></h3>
            <span><%# Item.pubDate %></span>
            <h3><%# Item.Description %></h3>
            </ItemTemplate>

        </asp:Repeater>

        </div>
        <div class="col-xs-6">
                  <asp:Repeater ID="Repeater2" runat="server" ItemType="WebForsmsDemo.Model.RssItem">
        <ItemTemplate>
         
            <h3><%# Item.Title %></h3>
            <span><%# Item.pubDate %></span>
            <h3><%# Item.Description %></h3>
            </ItemTemplate>

        </asp:Repeater>

        </div>
    </div>

  
</asp:Content>
