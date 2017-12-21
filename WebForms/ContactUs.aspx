<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="BlackLight.Recruitment.WebForms.ContactUs" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Contact Us</h2>
    
    <asp:Panel runat="server" ID="ContactFormPanel">
        <div>
            <asp:Label runat="server" AssociatedControlID="Name" Text="Your Name:" />
            <asp:TextBox runat="server" ID="Name" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="Name" Text="Name is required" />
        </div>
        <div>
            <asp:Label runat="server" AssociatedControlID="Email" Text="Your Email Address:" />
            <asp:TextBox runat="server" ID="Email" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email" Text="Email is required" />
            <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email" ErrorMessage="Invalid Email Format"></asp:RegularExpressionValidator>
            <!-- Todo: validate the email address -->
        </div>
        <div>
            <asp:Label runat="server" AssociatedControlID="Message" Text="Your message:" />
            <asp:TextBox ID="Message" runat="server" TextMode="MultiLine" Width="400px" Height="100px"></asp:TextBox>
            <!-- Todo: allow them to actually enter a message -->
        </div>

        <div>
            <asp:Button runat="server" ID="ContactUsBtn" Text="Send" OnClick="ContactUsBtnClick" />
            <!-- Todo: send this info back to the server -->
        </div>
    </asp:Panel>

    <asp:Panel runat="server" ID="FeedbackPanel" Visible="false">
        <p>Thanks for contacting us, <asp:Literal runat="server" ID="extraFeedbackText" />we'll get back to you soon.</p>
        <!-- Todo: show this panel after submission -->
    </asp:Panel>

</asp:Content>
