<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jquery.aspx.cs" Inherits="K_Project.Jquery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <title>JQuery</title>
      <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet"
      integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous" />
       <script src = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
</head>
<body>
       

    <form id="form1" runat="server">
        <div>
            <p>welcome to jquery</p>
            <p>welcome to jquery again</p>
            <h1>heading 1</h1>
            <h2>heading 2</h2>
            <asp:Button ID="Button1" runat="server" value="click" Text="Button" OnClick="Button1_Click" />

        </div>
    </form>
    <script>
        $(document.ready(function () {
            $("#Btn").click(function () { 

        });
    </script>
</body>
</html>
