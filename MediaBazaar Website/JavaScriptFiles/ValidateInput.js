function validateChangePassword() {

    var passwordOne = document.forms["changePassword"]["newPassword"].value;
    var passwordTwo = document.forms["changePassword"]["newPasswordCheck"].value;
   var text;
    if (passwordOne == ""||passwordOne.length<8) {
       text= "password should not be less than 8 charecters ";
      document.getElementById("validInput").innerHTML = text;
      return false;
    }
      if (passwordOne !=passwordTwo) {
         text= "the password shoud be the same in the confirm password";
        document.getElementById("validInput").innerHTML = text;
        return false;
      }
      return true;
}