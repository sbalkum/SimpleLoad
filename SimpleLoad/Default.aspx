<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleLoad._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
			<p>
				<pre><asp:Literal ID="Literal1" runat="server"></asp:Literal></pre>
			</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
	
	<asp:Literal ID="Literal2" runat="server"></asp:Literal>
	
	<p>
		arguments:
		numdigits - number of digits of pi.  Defaults to 5000.
	</p>
	
</asp:Content>
