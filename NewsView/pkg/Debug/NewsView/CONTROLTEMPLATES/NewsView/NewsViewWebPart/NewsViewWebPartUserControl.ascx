<%@ Assembly Name="NewsView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9da26fdeb1039315" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsViewWebPartUserControl.ascx.cs" Inherits="NewsView.NewsViewWebPart.NewsViewWebPartUserControl" %>

<tr id="BTR_1">
	<td id="BTD_2">
		<div id="BDIV_3">
		</div>
		<div id="BDIV_4">
			<div id="BDIV_5">
				March 12
			    <asp:Label runat="server" ID="PostDateVerb"/>
			</div>
		</div>
	</td>
	<td id="BTD_6">
		<table id="BTABLE_7">
			<tbody id="BTBODY_8">
				<tr id="BTR_9">
					<td id="BTD_10">
					    <a href="http://win-sharepointd/blog/Lists/Posts/Post.aspx?ID=1" id="BA_11"><asp:Label runat="server" ID="NewsTitle"/></a>
					</td>
					<td id="BTD_12">
						<a href="javascript:" id="BA_13">Edit</a>
					</td>
				</tr>
			</tbody>
		</table>
		<div id="BDIV_14">
			<span id="BSPAN_15">by</span>
			<nobr id="BNOBR_16">
				<span id="BSPAN_17"><a href="/blog/_layouts/userdisp.aspx?ID=1073741823" id="BA_18"><asp:Label runat="server" ID="AuthorUserName"></asp:Label></a><img height="1" width="3" src="/_layouts/images/blank.gif" id="BIMG_19" alt='' /><img height="12" width="12" src="/_layouts/images/blank.gif" alt="" id="BIMG_20" /></span>
		    </nobr> <span id="BSPAN_21"><asp:Label runat="server" ID="PostCreatedDate"/></span>
			<div id="BDIV_22">
			</div>
		</div>
		<div id="BDIV_23">
			<div id="BDIV_24">
				<div id="BDIV_25">
					<div id="BDIV_26">
					    <asp:Label runat="server" ID="PostBody"/>
					</div>
				</div>
			</div>
		</div>
		<div id="BDIV_35">
			<span id="BSPAN_36"><span id="BSPAN_37"><a href="http://win-sharepointd/blog/Lists/Posts/Post.aspx?ID=1" id="BA_38"><img src="/_layouts/images/fgimg.png" alt="Permanent Link to Post" id="BIMG_39" /></a></span></span> | <span id="BSPAN_40"><span id="BSPAN_41"><a href="javascript:navigateMailToLink('http://win-sharepointd/blog%2FLists%2FPosts%2FPost.aspx?ID%3D1')" id="BA_42"><img src="/_layouts/images/fgimg.png" alt="Email Post Link" id="BIMG_43" /></a></span></span> | <span id="BSPAN_44"><span id="BSPAN_45"><a href="http://win-sharepointd/blog/Lists/Posts/Post.aspx?ID=1" id="BA_46"><img src="/_layouts/images/fgimg.png" alt="Number of Comments" id="BIMG_47" /></a></span></span> <span id="BSPAN_48"><a href="http://win-sharepointd/blog/Lists/Posts/Post.aspx?ID=1" id="BA_49"><asp:Label runat="server" ID="NumberOfComments"></asp:Label></a></span>
		</div>
	</td>
</tr>

