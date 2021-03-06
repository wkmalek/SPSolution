﻿<%@ Register TagPrefix="WpNs2" Namespace="SubscriptionJob.SubscribeButton" Assembly="NewsFeedWP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=10ad000354663770"%>
<%@ Register TagPrefix="WpNs1" Namespace="WebParts.CategoryListWebPart" Assembly="WebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=1030d625f785d81b"%>
<%@ Register TagPrefix="WpNs0" Namespace="WebParts.NewsFeedVer2" Assembly="WebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=1030d625f785d81b"%>
<%@ Page language="C#" MasterPageFile="~masterurl/default.master"    Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=14.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:webpartpageexpansion="full" meta:progid="SharePoint.WebPartPage.Document"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Import Namespace="Microsoft.SharePoint" %> <%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
	<SharePoint:EncodedLiteral runat="server" text="<%$Resources:wss,multipages_homelink_text%>" EncodeMethod="HtmlEncode"/> 
	- <SharePoint:ProjectProperty Property="Title" runat="server"/>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageImage" runat="server"><img src="/_layouts/images/blank.gif" width='1' height='1' alt="" /></asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitleInTitleArea" runat="server">
			<label class="ms-hidden">
			<SharePoint:ProjectProperty Property="Title" runat="server"/></label>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderTitleAreaClass" runat="server">
<SharePoint:UIVersionedContent runat="server" UIVersion="<=3">
	<ContentTemplate>
		<style type="text/css">
		td.ms-titleareaframe, .ms-pagetitleareaframe {
			height: 10px;
		}
		div.ms-titleareaframe {
			height: 100%;
		}
		.ms-pagetitleareaframe table {
			background: none;
			height: 10px;
		}
		</style>
	</ContentTemplate>
</SharePoint:UIVersionedContent>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderAdditionalPageHead" runat="server">
	<meta name="CollaborationServer" content="SharePoint Team Web Site" />
<style type="text/css">
.s4-nothome {
	display:none;
}
</style>
	<script type="text/javascript">
// <![CDATA[
	var navBarHelpOverrideKey = "WSSEndUser";
// ]]>
	</script>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderSearchArea" runat="server">
	<SharePoint:DelegateControl runat="server"
		ControlId="SmallSearchInputBox"/>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderLeftActions" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageDescription" runat="server"/>
<asp:Content ContentPlaceHolderId="PlaceHolderBodyAreaClass" runat="server">
<style type="text/css">
.ms-bodyareaframe {
	padding: 0px;
}
</style>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderMain" runat="server">
	<table cellspacing="0" border="0" width="100%">
	  <tr class="s4-die">
	   <td class="ms-pagebreadcrumb">
		  <asp:SiteMapPath SiteMapProvider="SPContentMapProvider" id="ContentMap" SkipLinkText="" NodeStyle-CssClass="ms-sitemapdirectional" runat="server"/>
	   </td>
	  </tr>
	  <tr>
	   <td class="ms-webpartpagedescription">
		<SharePoint:ProjectProperty Property="Description" runat="server"/></td>
	  </tr>
	  <tr>
		<td>
		 <table width="100%" cellpadding="0" cellspacing="0" style="padding: 5px 10px 10px 10px;">
		  <tr>
		   <td valign="top" width="70%">
			   <WebPartPages:WebPartZone runat="server" FrameType="TitleBarOnly" ID="Left" Title="loc:Left"><ZoneTemplate>
				<WpNs0:NewsFeedVer2 runat="server" DataSourceID="" HelpMode="Modeless" SuppressWebPartChrome="False" ListUrl="" MissingAssembly="Cannot import this Web Part." PageSize="-1" IsIncludedFilter="" ViewContentTypeId="" IsVisible="True" DataMappingViewFields="{fa564e0f-0c70-4ab9-b863-0177e6ddd247},Text;" Title="NewsFeedVer2" ZoneID="Left" AutoRefresh="False" FrameType="Default" ManualRefresh="False" ExportControlledProperties="True" ItemStyle="Default" ID="g_eeec48ed_7ce5_4b04_86a8_c71c397e8a2f" ServerTemplate="10004" FrameState="Normal" ListGuid="14bc01de-752a-47a8-9a7d-c508d2e85314" PartOrder="2" ShowWithSampleData="False" ContentTypeBeginsWithId="0x0100C6414F7AC5D84BB1BBAD3A8A0F555A2F" AllowHide="True" CommonViewFields="NewsBody,Note;NewsTitle,Text;CompanyName,Text;" ViewFlag="0" UseSQLDataSourcePaging="True" PartImageLarge="" DataMappings="LinkUrl:|Description:|ImageUrl:|Title:{fa564e0f-0c70-4ab9-b863-0177e6ddd247},Title,Text;|" AllowMinimize="True" AsyncRefresh="False" InitialAsyncDataFetch="False" AutoRefreshInterval="60" Dir="Default" AllowZoneChange="True" PartImageSmall="" GroupStyle="DefaultHeader" IsIncluded="True" EnableOriginalValue="False" DetailLink="" UseCopyUtil="True" Filter1ChainingOperator="Or" WebUrl="~sitecollection" Description="" SortByDirection="Desc" ExportMode="All" AllowEdit="True" ConnectionID="00000000-0000-0000-0000-000000000000" AllowConnect="True" Filter2ChainingOperator="Or" ListId="00000000-0000-0000-0000-000000000000" AllowRemove="True" NoDefaultStyle="" HelpLink="" GroupByDirection="Desc" ListDisplayName="" __MarkupType="vsattributemarkup" __WebPartId="{EEEC48ED-7CE5-4B04-86A8-C71C397E8A2F}" WebPart="true" Height="" Width=""><DataFields>
</DataFields>
<SampleData>
<dsQueryResponse>
                    <Rows>
                        <Row Title="Item 1" LinkUrl="http://Item1" Group="Group Header" __begincolumn="True" __begingroup="True" />
                        <Row Title="Item 2" LinkUrl="http://Item2" __begincolumn="False" __begingroup="False" />
                        <Row Title="Item 3" LinkUrl="http://Item3" __begincolumn="False" __begingroup="False" />
                    </Rows>
                    </dsQueryResponse></SampleData>
<Xsl>
<xsl:stylesheet xmlns:x="http://www.w3.org/2001/XMLSchema" version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:cmswrt="http://schemas.microsoft.com/WebPart/v3/Publishing/runtime" exclude-result-prefixes="xsl cmswrt x" > <xsl:import href="/Style Library/XSL Style Sheets/Header.xsl" /> <xsl:import href="/Style Library/XSL Style Sheets/ItemStyle.xsl" /> <xsl:import href="/Style Library/XSL Style Sheets/ContentQueryMain.xsl" /> </xsl:stylesheet></Xsl>
</WpNs0:NewsFeedVer2>

</ZoneTemplate></WebPartPages:WebPartZone>
			   &nbsp;
		   </td>
		   <td>&nbsp;</td>
		   <td valign="top" width="30%">
			   <WebPartPages:WebPartZone runat="server" FrameType="TitleBarOnly" ID="Right" Title="loc:Right"><ZoneTemplate>
				<WpNs1:CategoryListWebPart runat="server" ID="g_cdb95648_7905_4a7b_9ff2_65b028ea4892" Description="My Visual WebPart" Title="CategoryListWebPart" __MarkupType="vsattributemarkup" __WebPartId="{CDB95648-7905-4A7B-9FF2-65B028EA4892}" WebPart="true" __designer:IsClosed="false" partorder="2"></WpNs1:CategoryListWebPart>

<WpNs2:SubscribeButton runat="server" ID="g_e46578d7_c7b0_40db_b81d_7cae36695d9a" Description="My Visual WebPart" Title="SubscribeButton" __MarkupType="vsattributemarkup" __WebPartId="{E46578D7-C7B0-40DB-B81D-7CAE36695D9A}" WebPart="true" __designer:IsClosed="false" partorder="4"></WpNs2:SubscribeButton>

<WebPartPages:SPUserCodeWebPart runat="server" Description="My Visual Web Part" Title="NewsStaisticsWebParts - NewsStatsWP" AssemblyFullName="NewsStaisticsWebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=76113819e8097dfc" SolutionId="c7c8fa7e-4613-4056-9c35-5ae7e522ad90" ID="g_1ef524e1_79c7_48e0_b6b0_453bfe93ecc1" TypeFullName="NewsStaisticsWebParts.NewsStatsWP.NewsStatsWP" __MarkupType="vsattributemarkup" __WebPartId="{1EF524E1-79C7-48E0-B6B0-453BFE93ECC1}" WebPart="true" __designer:IsClosed="false" partorder="6"></WebPartPages:SPUserCodeWebPart>

<WebPartPages:SPUserCodeWebPart runat="server" Description="My Visual Web Part" Title="NewsStaisticsWebParts - NewestNewsStats" AssemblyFullName="NewsStaisticsWebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=76113819e8097dfc" SolutionId="c7c8fa7e-4613-4056-9c35-5ae7e522ad90" ID="g_1ed904ae_6f7e_410b_b98c_a7efbda2556e" TypeFullName="NewsStaisticsWebParts.NewestNewsStats.NewestNewsStats" __MarkupType="vsattributemarkup" __WebPartId="{1ED904AE-6F7E-410B-B98C-A7EFBDA2556E}" WebPart="true" __designer:IsClosed="false" partorder="8"></WebPartPages:SPUserCodeWebPart>

</ZoneTemplate></WebPartPages:WebPartZone>
			   &nbsp;
		   </td>
		   <td>&nbsp;</td>
		  </tr>
		 </table>
		</td>
	  </tr>
	</table>
</asp:Content>
