<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddNewCommentWebPartUserControl.ascx.cs" Inherits="NewsView.AddNewCommentWebPart.AddNewCommentWebPartUserControl" %>
<style type="text/css">
    .auto-style1 {
        width: 79px;
    }
</style>
<tr id="CTR_1">
	<td id="CTD_2">
		<table id="CTABLE_3">
			<tbody id="CTBODY_4">
				<tr id="CTR_5">
					<td id="CTD_6">
						<div id="CDIV_7">
							<table id="CTABLE_8">
								<tbody id="CTBODY_9">
									<tr id="CTR_10">
										<td id="CTD_11">
											<span id="CSPAN_13">Add Comment</span>
										</td>
									</tr>
									<tr id="CTR_14">
										<td id="CTD_15">
											<span id="CSPAN_16"></span>
											<table id="CTABLE_17">
												<tbody id="CTBODY_18">
													<tr id="CTR_19">
														<td id="CTD_20" class="auto-style1">
															<nobr id="CNOBR_22">
																Title
															</nobr>
														</td>
														<td id="CTD_23">
														    <!-- FieldName="Title" FieldInternalName="Title" FieldType="SPFieldText" --> <span id="SPAN_24"><asp:TextBox runat="server" ID="Title"/><br id="CBR_26" /></span>
														</td>
													</tr>
													<tr id="CTR_27">
														<td id="CTD_28" class="auto-style1">
															<nobr id="CNOBR_30">
																Body <span id="CSPAN_31">*</span>
															</nobr>
														</td>
														<td id="CTD_32">
															<!-- FieldName="Body" FieldInternalName="Body" FieldType="SPFieldNote" --><span id="SPAN_33"></span>
														    <asp:TextBox runat="server" TextMode="MultiLine" ID="Body" Columns="20" Rows="10" />
															<br id="CBR_35" />
														</td>
													</tr>
												</tbody>
											</table>
											<table id="CTABLE_44">
													<tbody id="CTBODY_45">
														<tr id="CTR_46">
															<td id="CTD_47">
																<table id="CTABLE_48">
																	<tbody id="CTBODY_49">
																		<tr id="CTR_50">
																			<td id="CTD_51">
																				<img src="/_layouts/images/blank.gif" width="1" height="18" alt="" id="CIMG_52" />
																			</td>
																			<td id="CTD_53">
																				<table id="CTABLE_54">
																					<tbody id="CTBODY_55">
																						<tr id="CTR_56">
																							<td id="CTD_57">
																								<asp:Button runat="server" ID="SubmitComment" Text="Submit comment" OnClick="SubmitComment_OnClick"/>
																							</td>
																						</tr>
																					</tbody>
																				</table>
																			</td>
																		</tr>
																	</tbody>
																</table>
																<input name="ctl00$m$g_7c02ca48_9ec8_46f0_b625_e2d3fc6eba7b$ctl00$ctl07$ctl00$owshiddenversion" type="HIDDEN" id="CINPUT_59" />
															</td>
														</tr>
													</tbody>
												</table>
										</td>
									</tr>
								</tbody>
							</table>
						</div>
					</td>
				</tr>
			</tbody>
		</table>
	</td>
</tr>