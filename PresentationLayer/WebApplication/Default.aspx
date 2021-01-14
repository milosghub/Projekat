<!DOCTYPE html>
<script runat="server">


</script>

<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
body {font-family: Arial, Helvetica, sans-serif;
      background-image:url("Images/g.jpg");
      background-size:cover;
}
form {
    background-color:white;
   width:50%;
   margin-left:25%;
   margin-right:25%;
    border: 3px solid #f1f1f1;}
h2{
    margin-left:400px;
}
 input[type=text], input[type=password] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
} 

button {
  background-color: #4CAF50;
  color: white;
  padding: 14px 20px;
  margin: 2px 0; /*bilo 8px 0*/
  border: none;
  cursor: pointer;
  width: 15%;  /*bilo 100%*/

  
}


button:hover {
  opacity: 0.8;
}

.cancelbtn {
  width: auto;
  padding: 10px 18px;
  background-color: #f44336;
}

.imgcontainer {
  text-align: center;
  margin: 24px 0 12px 0;
 
}

img.avatar {
  width: 40%;
  border-radius: 50%;
}

.container {
  padding: 16px;
}

span.psw {
  float: right;
  padding-top: 16px;
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
  span.psw {
     display: block;
     float: none;
  }
  .cancelbtn {
     width: 100%;
  }
}
</style>
</head>
<body>

<h2>Login Form</h2>

<form action="/action_page.php" method="post">
  <div class="imgcontainer">
    <img src="Images/avatar.png" alt="Avatar" class="avatar">
  </div>

  <div class="container">
    <label for="uname"><b>Username</b></label>
    <input type="text" placeholder="Enter Username" name="uname" required>

    <label for="psw"><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="psw" required>
        
 <!-- <button type="submit" aria-readonly="False" ><a href="About.aspx" target="_blank">Login</a> </button> -->
      <button type="submit"><a  href="About.aspx" target="_blank"  >Log  in</a> </button>  
    
  </div>

  <div class="container" style="background-color:#f1f1f1">
  <!--  <button type="button" class="cancelbtn" ><a href="About.aspx" target="_blank" >Cancel</a> </button> -->
    
  </div>
</form>

</body>
</html>
