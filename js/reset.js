function showMsg_reset(){
    var x = document.getElementById("msg_reset");
    x.className = "show";
    setTimeout(function () {
        x.className = x.className.replace("show", "");
    }, 3000);
}