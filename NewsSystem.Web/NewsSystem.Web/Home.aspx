<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NewsSystem.Web.Home"%>
<asp:Content  ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h1>News</h1>
  <h2>Most Popular Articles</h2>
  <asp:Repeater runat="server" ID="repeaterArticle" 
       ItemType="NewsSystem.Data.Models.Article"
       SelectMethod="repeaterArticle_GetData1">
  <ItemTemplate>
      <h3>
        <a href="~/ViewArticle.aspx?id=<%# Item.Id %>"><%#:Item.Title %></a>
        <small><%#: Item.Category.Name %></small>
      </h3>
      <p>
        <%#: Item.Content %>
      </p>
      <p>
        Likes: <%# Item.Likes.Count() %>
      </p>
      <i>
        by <%#: Item.Author.UserName %> created on: <%# Item.DateCreated %>
      </i>
    </ItemTemplate>
  </asp:Repeater>

  <asp:ListView runat="server" ID="lvCategories"
    ItemType="NewsSystem.Data.Models.Category"
    SelectMethod ="lvCategories_GetData">
    <LayoutTemplate>
      <h2>All categories</h2>
      <div runat="server" ID="itemPlaceHolder"></div>
    </LayoutTemplate>
    <ItemTemplate>
      <h3><%#: Item.Name %></h3>
      <asp:ListView runat="server" 
        ItemType="NewsSystem.Data.Models.Article"
        DataSource="<%# Item.Articles.OrderByDescending(x =>x.DateCreated).Take(3) %>">
        <LayoutTemplate>
          <ul>
            <li runat="server" ID="itemPlaceholder"></li>
          </ul>
        </LayoutTemplate>
        <ItemTemplate>
          <a href="~/ViewArticle.aspx?id=<%# Item.Id %>">
            <strong><%#: Item.Title %></strong> <i>by <%# Item.Author.UserName %></i>
          </a>
        </ItemTemplate>
      </asp:ListView>
    </ItemTemplate>
    <EmptyDataTemplate>
      No articles.
    </EmptyDataTemplate>
  </asp:ListView>
</asp:Content>
