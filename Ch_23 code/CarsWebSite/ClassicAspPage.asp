<%@ language="VBScript" %>
<html>
<head>
    <title>The Cars Page</title>
</head>
 <body>
    <h1 align="center">Here is what you sent me:</h1>
    <P align="center"> <b>User Name: </b>
    <%= Request.QueryString("txtUserName") %> <br>
    <b>Password: </b>
    <%= Request.QueryString("txtPassword") %> <br>
    </P>
</body>
</html>
