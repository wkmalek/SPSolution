<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsCommentsWebPartUserControl.ascx.cs" Inherits="NewsView.NewsCommentsWebPart.cs.NewsCommentsWebPartUserControl" %>
<tr id="TR_1">
	<td id="TD_2">
		<table id="TABLE_3">
			<tbody id="TBODY_4">
				<tr id="TR_5">
					<td id="TD_6">
						<div id="DIV_7">
							<div id="DIV_8">
								<a name="Comments" id="A_9"></a>
								<h3 id="H3_10">
									Comments
								</h3>
								<table id="TABLE_11">
									<tbody id="TBODY_12">
										<tr id="TR_13">
											<td id="TD_14">
											    <asp:Label runat="server" ID="CommentTitle"/>
											</td>
											<td id="TD_16">
												<a href="javascript:" id="A_17">Edit</a>
											</td>
										</tr>
									</tbody>
								</table>
								<div id="DIV_18">
									<div id="DIV_19">
										<div id="DIV_20">
										    <asp:Label runat="server" ID="CommentBody"/>
										</div>
									</div>
								</div>
								<div id="DIV_21">
									<nobr id="NOBR_22">
									    <span id="SPAN_23"><a href="/blog/_layouts/userdisp.aspx?ID=1073741823" id="A_24"><asp:Label ID="UserName"/></a><img height="1" width="3" src="/_layouts/images/blank.gif" id="IMG_25" alt='' /><img height="12" width="12" src="/_layouts/images/blank.gif" alt="" id="IMG_26" /></span>
								    </nobr> on <span id="SPAN_27"><asp:Label runat="server" ID="DateCreated"/></span>
								</div>
							</div>
						</div>
					</td>
				</tr>
			</tbody>
		</table>
		<div id="DIV_28">
		</div>
	</td>
</tr>