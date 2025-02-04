<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Create</h2>
    <%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>
    <% using (Html.BeginForm())
       {%>
    <fieldset>
        <legend>Fields</legend>
        <p>
            <label for="Id">
                Id:</label>
            <%= Html.TextBox("Id") %>
            <%= Html.ValidationMessage("Id", "*") %>
        </p>
        <p>
            <label for="Name">
                Name:</label>
            <%= Html.TextBox("Name") %>
            <%= Html.ValidationMessage("Name", "*") %>
        </p>
        <p>
            <label for="Age">
                Age:</label>
            <%= Html.TextBox("Age") %>
            <%= Html.ValidationMessage("Age", "*") %>
        </p>
        <p>
            <label for="Street">
                Street:</label>
            <%= Html.TextBox("Street") %>
            <%= Html.ValidationMessage("Street", "*") %>
        </p>
        <p>
            <label for="City">
                City:</label>
            <%= Html.TextBox("City") %>
            <%= Html.ValidationMessage("City", "*") %>
        </p>
        <p>
            <label for="State">
                State:</label>
            <%= Html.TextBox("State") %>
            <%= Html.ValidationMessage("State", "*") %>
        </p>
        <p>
            <label for="ZipCode">
                Zipcode:</label>
            <%= Html.TextBox("ZipCode") %>
            <%= Html.ValidationMessage("ZipCode", "*") %>
        </p>
        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%=Html.ActionLink("Back to List", "Index","Person") %>
        <%=Html.ActionLink("Details", "Details","Person") %>
    </div>
</asp:Content>
