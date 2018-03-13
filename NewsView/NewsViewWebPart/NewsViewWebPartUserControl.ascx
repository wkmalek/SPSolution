<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsViewWebPartUserControl.ascx.cs" Inherits="NewsView.NewsViewWebPart.NewsViewWebPartUserControl" %>

<tr id="TR_1">
	<td id="TD_2">
		<div id="DIV_3">
		</div>
		<div id="DIV_4">
			<div id="DIV_5">
				March 12
			    <asp:Label runat="server" ID="PostDateVerb"/>
			</div>
		</div>
	</td>
	<td id="TD_6">
		<table id="TABLE_7">
			<tbody id="TBODY_8">
				<tr id="TR_9">
					<td id="TD_10">
					    <a href="http://win-sharepointd/blog/Lists/Posts/Post.aspx?ID=1" id="A_11"><asp:Label runat="server" ID="NewsTitle"/></a>
					</td>
					<td id="TD_12">
						<a href="javascript:" id="A_13">Edit</a>
					</td>
				</tr>
			</tbody>
		</table>
		<div id="DIV_14">
			<span id="SPAN_15">by</span>
			<nobr id="NOBR_16">
				<span id="SPAN_17"><a href="/blog/_layouts/userdisp.aspx?ID=1073741823" id="A_18"><asp:Label runat="server" ID="AuthorUserName"></asp:Label></a><img height="1" width="3" src="/_layouts/images/blank.gif" id="IMG_19" alt='' /><img height="12" width="12" src="/_layouts/images/blank.gif" alt="" id="IMG_20" /></span>
		    </nobr> <span id="SPAN_21"><asp:Label runat="server" ID="PostCreatedDate"/></span>
			<div id="DIV_22">
			</div>
		</div>
		<div id="DIV_23">
			<div id="DIV_24">
				<div id="DIV_25">
					<div id="DIV_26">
					    <asp:Label runat="server" ID="PostBody"/>
					</div>
				</div>
			</div>
		</div>
		<div id="DIV_35">
			<span id="SPAN_36"><span id="SPAN_37"><a href="http://win-sharepointd/blog/Lists/Posts/Post.aspx?ID=1" id="A_38"><img src="/_layouts/images/fgimg.png" alt="Permanent Link to Post" id="IMG_39" /></a></span></span> | <span id="SPAN_40"><span id="SPAN_41"><a href="javascript:navigateMailToLink('http://win-sharepointd/blog%2FLists%2FPosts%2FPost.aspx?ID%3D1')" id="A_42"><img src="/_layouts/images/fgimg.png" alt="Email Post Link" id="IMG_43" /></a></span></span> | <span id="SPAN_44"><span id="SPAN_45"><a href="http://win-sharepointd/blog/Lists/Posts/Post.aspx?ID=1" id="A_46"><img src="/_layouts/images/fgimg.png" alt="Number of Comments" id="IMG_47" /></a></span></span> <span id="SPAN_48"><a href="http://win-sharepointd/blog/Lists/Posts/Post.aspx?ID=1" id="A_49"><asp:Label runat="server" ID="NumberOfComments"></asp:Label></a></span>
		</div>
	</td>
</tr>

