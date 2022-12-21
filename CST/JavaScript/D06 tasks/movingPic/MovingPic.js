var rightPic;
var leftPic;
var bottomPic;
var interval;
var dir;
function init() {
    rightPic = document.getElementById("r_img");
    leftPic = document.getElementById("l_img");
    bottomPic = document.getElementById("b_img");

    document.getElementById("label1").innerText = "<img src= 'icon1.gif' style= 'left:0px' />";
    document.getElementById("label2").innerText = "<img src= 'icon2.gif' style= 'left:0px' />";
    document.getElementById("label3").innerText = "<img src= 'TOP.gif' style= 'top:0px' />";
}

function state_fun() //change go to stop ,, move pics
{
    if (document.getElementById("state").value == "stop") {
        document.getElementById("state").value = "go";
        stopPics();
    }
    else if (document.getElementById("state").value == "go") {
        document.getElementById("state").value = "stop";
        interval = setInterval("movingPics ()", 50);
    }
}

function reset_pos() {
    rightPic.style.left = "11px";
    leftPic.style.left = "11px";
    bottomPic.style.top = "11px";

    document.getElementById("label1").innerText = "<img src= 'icon1.gif' style= 'left:0px' />";
    document.getElementById("label2").innerText = "<img src= 'icon2.gif' style= 'left:0px' />";
    document.getElementById("label3").innerText = "<img src= 'TOP.gif' style= 'top:0px' />";
}

function movingPics() {
    //var loc;
    var actualLoc;

    loc = getComputedStyle(bottomPic).top;
    actualLoc = parseInt(loc);

    if (actualLoc > 9) // to inside
    {
        dir = 0;
    }
    else if (actualLoc == -254) // to outside
    {
        dir = 1;
    }

    switch (dir) {
        case 0: //inside
            actualLoc -= 5;
            bottomPic.style.top = actualLoc + "px";

            loc = getComputedStyle(leftPic).left;
            actualLoc=parseInt(loc);
            actualLoc+=5;
            leftPic.style.left=actualLoc+"px";

            loc = getComputedStyle(rightPic).left;
            actualLoc=parseInt(loc);
            actualLoc-=5;
            rightPic.style.left=actualLoc+"px";
        break;
        case 1: //outside
            actualLoc += 5;
            bottomPic.style.top = actualLoc + "px";

            loc = getComputedStyle(leftPic).left;
            actualLoc=parseInt(loc);
            actualLoc-=5;
            leftPic.style.left=actualLoc+"px";

            loc = getComputedStyle(rightPic).left;
            actualLoc=parseInt(loc);
            actualLoc+=5;
            rightPic.style.left=actualLoc+"px";
        break;
    }

    document.getElementById("label1").innerText = "<img src= 'icon1.gif' style= 'left:" + rightPic.style.left + "' />";
    document.getElementById("label2").innerText = "<img src= 'icon2.gif' style= 'left:" + leftPic.style.left + "' />";
    document.getElementById("label3").innerText = "<img src= 'TOP.gif' style= 'top:" + bottomPic.style.top + "' />";
}

function stopPics() {
    clearInterval(interval);
    document.getElementById("label1").innerText = "<img src= 'icon1.gif' style= 'left:" + rightPic.style.left + "' />";
    document.getElementById("label2").innerText = "<img src= 'icon2.gif' style= 'left:" + leftPic.style.left + "' />";
    document.getElementById("label3").innerText = "<img src= 'TOP.gif' style= 'top:" + bottomPic.style.top + "' />";
}