<%@ Application Language="C#" %>
<script runat="server">

    void Application_Start(Object sender, EventArgs e) 
    { 
        Application["SimplePI"] = 3.14F; 
    }

    void Session_Start(Object sender, EventArgs e)
    {
        // To prove session state data is available from a Web service,
        // simply assign a random number to each user. 
        Random r = new Random();
        Session["SessionRandomNumber"] = r.Next(1000);
    }   
</script>
