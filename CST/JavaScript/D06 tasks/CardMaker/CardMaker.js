function init(){
    for (var i=1;i<7; i++)
    {
        document.getElementById(i.toString()).checked = false;
    }

}

function select_img(imageSrc)
{
    setCookie("imgSrc" , imageSrc);
    for (var i=0;i<6;i++)
    {
        //document.images[i].style.border = "none";
        document.getElementsByTagName("img")[i].style.border = "";
    }
    document.getElementById(imageSrc).style.border = "solid";
    document.getElementById(imageSrc).style.borderColor = "red";
}

function generate_card()
{
    setCookie("messageText", document.getElementById("message").value);
    open("previewCard.html" , "" , "width = 400 , height = 400");
}

function card()
{
    focus();
    document.getElementById("img").src = getCookie("imgSrc");
    document.getElementById("txt").innerHTML = getCookie("messageText");
}

function close_win()
{
    close();
}