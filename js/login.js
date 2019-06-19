function getInfo(){
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    console.log("Your username is: " + username + "and your password is: " + password);
}

function GetUserInfo(){
    var request_url = '';

    $.ajax({
        url: request_url,
        type: "POST",
        dataType: "html",
        success: function(response){
            // Do something with your response here
            alert(response);
        }
    });
}

console.log(GetUserInfo());