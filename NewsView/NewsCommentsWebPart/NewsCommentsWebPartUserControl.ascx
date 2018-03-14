<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsCommentsWebPartUserControl.ascx.cs" Inherits="NewsView.NewsCommentsWebPart.cs.NewsCommentsWebPartUserControl" %>


<tr id="ATR_1">
    <td id="ATD_2">
        <table id="ATABLE_3">
            <tbody id="ATBODY_4">
            <tr id="ATR_5">
                <td id="ATD_6">
                    <div id="ADIV_7">
                        <div id="ADIV_8">
                            <a name="Comments" id="AA_9"></a>
                            <h3 id="AH3_10">
                                Comments
                            </h3>
<asp:Repeater ID="Repeater" runat="server">
    
    <ItemTemplate>
        
        <table id="ATABLE_11">
            <tbody id="ATBODY_12">
            <tr id="ATR_13">
                <td id="ATD_14">
                    <asp:Label runat="server" ID="CommentTitle" Text='<%# DataBinder.Eval(Container.DataItem, "[\"Title\"]") %>'/>
                </td>
                <td id="ATD_16">
                    <a href="javascript:" id="AA_17">Edit</a>
                </td>
            </tr>
            </tbody>
        </table>
        <div id="ADIV_18">
            <div id="ADIV_19">
                <div id="ADIV_20">
                    <asp:Label runat="server" ID="CommentBody" Text='<%# DataBinder.Eval(Container.DataItem, "[\"Body\"]") %>'/>
                </div>
            </div>
        </div>
        <div id="ADIV_21">
            <nobr id="ANOBR_22">
                <span id="ASPAN_23"><a href="/blog/_layouts/userdisp.aspx?ID=1073741823" id="AA_24"><asp:Label ID="UserName" /></a><img height="1" width="3" src="/_layouts/images/blank.gif" id="AIMG_25" alt='' /><img height="12" width="12" src="/_layouts/images/blank.gif" alt="" id="AIMG_26" /></span>
            </nobr> on <span id="ASPAN_27"><asp:Label runat="server" ID="DateCreated" /></span>
        </div>

    </ItemTemplate>
</asp:Repeater>


								
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