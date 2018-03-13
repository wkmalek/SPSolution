<%@ Assembly Name="NewsFeedWP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=10ad000354663770" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="NewsFeedWP.Layouts.NewsDataObjects.News" MasterPageFile="~masterurl/default.master" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls"
Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages"
Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <WebPartPages:WebPartZone runat="server" FrameType="None" ID="NewsWP"/>
    
    <ZoneTemplate>

    </ZoneTemplate>
    </WebPartPages:WebPartZone>
    <WebPartPages:WebPartZone runat="server" FrameType="None" ID="CommentsWP"/>
    
    <ZoneTemplate>

    </ZoneTemplate>
    </WebPartPages:WebPartZone>
</asp:Content>
