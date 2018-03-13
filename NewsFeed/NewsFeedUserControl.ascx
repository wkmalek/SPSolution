<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsFeedUserControl.ascx.cs" Inherits="NewsFeedWP.NewsFeed.NewsFeedUserControl" %>

<link rel="stylesheet" type="text/css" href="../../../_layouts/WebParts/NewsFeed/style.css" />

<div id="wrapper">
    <div id="content">
        <div class="articles">
            <h2 class="title"><asp:Label runat="server" ID="ArticleTitleLabel" Text="Articles"/></h2>
            <asp:Repeater runat="server" ID="Posts">
                <ItemTemplate>   
                    <!--Post-->
                    <div class="post">
                        <div class="details">
                            <p class="l"> <span class="category"><a href="#"> <asp:Label runat="server" ID="PostCategoryLabel" Text=<%# Eval("PostCategory") %>/> </a></span> - Posted by <a href="#"><asp:Label runat="server" ID="AuthorLabel" Text=<%# Eval("PostAuthor") %>/></a> on <asp:Label runat="server" ID="DateLabel" Text=<%# Eval("PostDate") %>/> </p>
                            <p class="r"> <a href="#"><%# Eval("CommentsCount") %></a> </p>
                        </div>
                        <div class="thumb"><a href="#"><img src=<%# Eval("ImageLink") %> alt="" /></a></div>
                        <h2><a href="#"><asp:Label runat="server" Text=<%# Eval("ArticleTitle") %> ID="ShortDescriptionLabel"/></a></h2>
                        <p><asp:Label runat="server" ID="BodyLabel" Text=<%# Eval("ShortDescription") %>/></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>
</div>
