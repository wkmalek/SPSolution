<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=14.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
	<SharePoint:EncodedLiteral runat="server" text="<%$Resources:wss,multipages_homelink_text%>" EncodeMethod="HtmlEncode"/> - 
	<SharePoint:ProjectProperty Property="Title" runat="server"/>
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
				<WebPartPages:SPUserCodeWebPart runat="server" Description="My Web Part" Title="NewsStaisticsWebParts - NewestNews" AssemblyFullName="NewsStaisticsWebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=76113819e8097dfc" SolutionId="c7c8fa7e-4613-4056-9c35-5ae7e522ad90" ID="g_a337be41_f5d2_41f1_910b_b9ae087f21ea" TypeFullName="NewsStaisticsWebParts.NewestNews.NewestNews" __MarkupType="vsattributemarkup" __WebPartId="{A337BE41-F5D2-41F1-910B-B9AE087F21EA}" WebPart="true" __designer:IsClosed="true" partorder="2"></WebPartPages:SPUserCodeWebPart>

<WebPartPages:SPUserCodeWebPart runat="server" Description="My Web Part" Title="NewsStaisticsWebParts - NewestNews" AssemblyFullName="NewsStaisticsWebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=76113819e8097dfc" SolutionId="c7c8fa7e-4613-4056-9c35-5ae7e522ad90" ID="g_7a605d1f_0ce4_473e_bbf7_a654c46df472" TypeFullName="NewsStaisticsWebParts.NewestNews.NewestNews" __MarkupType="vsattributemarkup" __WebPartId="{7A605D1F-0CE4-473E-BBF7-A654C46DF472}" WebPart="true" __designer:IsClosed="true" partorder="4"></WebPartPages:SPUserCodeWebPart>

<WebPartPages:SPUserCodeWebPart runat="server" Description="My Web Part" Title="NewsStaisticsWebParts - NewsStats" AssemblyFullName="NewsStaisticsWebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=76113819e8097dfc" SolutionId="c7c8fa7e-4613-4056-9c35-5ae7e522ad90" ID="g_7610e4f2_ca90_437b_9bae_2b5c1406947b" TypeFullName="NewsStaisticsWebParts.NewsStats.NewsStats" __MarkupType="vsattributemarkup" __WebPartId="{7610E4F2-CA90-437B-9BAE-2B5C1406947B}" WebPart="true" __designer:IsClosed="true" partorder="6"></WebPartPages:SPUserCodeWebPart>

<WebPartPages:SPUserCodeWebPart runat="server" Description="My Web Part" Title="NewsStaisticsWebParts - NewsStats" AssemblyFullName="NewsStaisticsWebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=76113819e8097dfc" SolutionId="c7c8fa7e-4613-4056-9c35-5ae7e522ad90" ID="g_59c34761_a641_4655_9381_b679c72737d1" TypeFullName="NewsStaisticsWebParts.NewsStats.NewsStats" __MarkupType="vsattributemarkup" __WebPartId="{59C34761-A641-4655-9381-B679C72737D1}" WebPart="true" __designer:IsClosed="false" partorder="8"></WebPartPages:SPUserCodeWebPart>

<WebPartPages:SPUserCodeWebPart runat="server" Description="My Web Part" Title="NewsStaisticsWebParts - NewestNews" AssemblyFullName="NewsStaisticsWebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=76113819e8097dfc" SolutionId="c7c8fa7e-4613-4056-9c35-5ae7e522ad90" ID="g_e1cb7ad0_3d96_4bf8_b332_0f383ec21d81" TypeFullName="NewsStaisticsWebParts.NewestNews.NewestNews" __MarkupType="vsattributemarkup" __WebPartId="{E1CB7AD0-3D96-4BF8-B332-0F383EC21D81}" WebPart="true" __designer:IsClosed="true" partorder="10"></WebPartPages:SPUserCodeWebPart>

<WebPartPages:SPUserCodeWebPart runat="server" Description="My Web Part" Title="NewsStaisticsWebParts - NewestNews" AssemblyFullName="NewsStaisticsWebParts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=76113819e8097dfc" SolutionId="c7c8fa7e-4613-4056-9c35-5ae7e522ad90" ID="g_45be2fd7_f8a5_45ba_a2f0_c38ac56f61b5" TypeFullName="NewsStaisticsWebParts.NewestNews.NewestNews" __MarkupType="vsattributemarkup" __WebPartId="{45BE2FD7-F8A5-45BA-A2F0-C38AC56F61B5}" WebPart="true" __designer:IsClosed="false" partorder="12"></WebPartPages:SPUserCodeWebPart>

</ZoneTemplate></WebPartPages:WebPartZone>
			   &#160;
		   </td>
		   <td>&#160;</td>
		   <td valign="top" width="30%">
			   <WebPartPages:WebPartZone runat="server" FrameType="TitleBarOnly" ID="Right" Title="loc:Right"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>
			   &#160;
		   </td>
		   <td>&#160;</td>
		  </tr>
		 </table>
		</td>
	  </tr>
	</table>
</asp:Content>

