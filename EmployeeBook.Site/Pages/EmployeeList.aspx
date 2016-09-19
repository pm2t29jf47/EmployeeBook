<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="EmployeeBook.Site.Pages.EmployeeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:DetailsView ID="InsertEmployeeDetailsView" runat="server" ItemType="EmployeeBook.Site.ViewModels.EmployeeViewModel" DefaultMode="Edit"
            SelectMethod="SelectDefaultEmployeeViewModel" UpdateMethod="InsertEmployee" AutoGenerateRows="False" DataKeyNames="ID">
            <Fields>
                <asp:TemplateField>
                    <EditItemTemplate>
                        
                    </EditItemTemplate>
                </asp:TemplateField>
            </Fields>
        </asp:DetailsView>
    </div>
</asp:Content>
