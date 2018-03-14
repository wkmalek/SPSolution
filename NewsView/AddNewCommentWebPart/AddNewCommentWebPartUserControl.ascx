<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddNewCommentWebPartUserControl.ascx.cs" Inherits="NewsView.AddNewCommentWebPart.AddNewCommentWebPartUserControl" %>
<tr id="TR_1">
	<td id="TD_2">
		<table id="TABLE_3">
			<tbody id="TBODY_4">
				<tr id="TR_5">
					<td id="TD_6">
						<div id="DIV_7">
							<table id="TABLE_8">
								<tbody id="TBODY_9">
									<tr id="TR_10">
										<td id="TD_11">
											<span id="SPAN_13">Add Comment</span>
										</td>
									</tr>
									<tr id="TR_14">
										<td id="TD_15">
											<span id="SPAN_16"></span>
											<table id="TABLE_17">
												<tbody id="TBODY_18">
													<tr id="TR_19">
														<td id="TD_20">
															<nobr id="NOBR_22">
																Title
															</nobr>
														</td>
														<td id="TD_23">
															<!-- FieldName="Title" FieldInternalName="Title" FieldType="SPFieldText" --> <span id="SPAN_24"><input name="ctl00$m$g_7c02ca48_9ec8_46f0_b625_e2d3fc6eba7b$ctl00$ctl03$ctl00$ctl00$ctl00$ctl04$ctl00$ctl00$TextField" type="text" maxlength="255" id="INPUT_25" /><br id="BR_26" /></span>
														</td>
													</tr>
													<tr id="TR_27">
														<td id="TD_28">
															<nobr id="NOBR_30">
																Body <span id="SPAN_31">*</span>
															</nobr>
														</td>
														<td id="TD_32">
															<!-- FieldName="Body" FieldInternalName="Body" FieldType="SPFieldNote" --><span id="SPAN_33"></span>
															<textarea name="ctl00$m$g_7c02ca48_9ec8_46f0_b625_e2d3fc6eba7b$ctl00$ctl03$ctl01$ctl00$ctl00$ctl04$ctl00$ctl00$TextField" rows="10" cols="20" id="TEXTAREA_34">
															</textarea><br id="BR_35" />
														</td>
													</tr>
													<tr id="TR_36">
														<td id="TD_37">
															<nobr id="NOBR_39">
																Attachments
															</nobr>
														</td>
														<td id="TD_40">
															<span id="SPAN_41"></span>
															<table id="TABLE_42">
															</table>
															<script type="text/javascript" id="SCRIPT_43">// <![CDATA[
	        var elm = document.getElementById("idAttachmentsTable");
	        var elmAttachmentRow =  document.getElementById("idAttachmentsRow")
	        if ((elm == null || elm.rows.length == 0) && (elmAttachmentRow!=null))
	            elmAttachmentRow.style.display='none';
		  // ]]>
															</script>
														</td>
													</tr>
												</tbody>
											</table>
											<table id="TABLE_44">
													<tbody id="TBODY_45">
														<tr id="TR_46">
															<td id="TD_47">
																<table id="TABLE_48">
																	<tbody id="TBODY_49">
																		<tr id="TR_50">
																			<td id="TD_51">
																				<img src="/_layouts/images/blank.gif" width="1" height="18" alt="" id="IMG_52" />
																			</td>
																			<td id="TD_53">
																				<table id="TABLE_54">
																					<tbody id="TBODY_55">
																						<tr id="TR_56">
																							<td id="TD_57">
																								<input type="button" name="ctl00$m$g_7c02ca48_9ec8_46f0_b625_e2d3fc6eba7b$ctl00$toolBarTbl$RightRptControls$ctl00$ctl00$diidIOSaveItem" value="Submit Comment" id="INPUT_58" accesskey="O" />
																							</td>
																						</tr>
																					</tbody>
																				</table>
																			</td>
																		</tr>
																	</tbody>
																</table>
																<input name="ctl00$m$g_7c02ca48_9ec8_46f0_b625_e2d3fc6eba7b$ctl00$ctl07$ctl00$owshiddenversion" type="HIDDEN" id="INPUT_59" />
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