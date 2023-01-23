var myc = document.querySelector('canvas');//use as html element
myc.width=innerWidth;
myc.height=innerHeight;

var ctx=myc.getContext('2d');

var img = new Image();

img.onload = function(){
    ctx.drawImage(img , 0 , 0 , 500 , 500);
    ctx.font = "35px tahoma";
    ctx.shadowColor = "white";
    ctx.shadowBlur = 3;
    ctx.shadowOffsetX = 3;
    ctx.shadowOffsetY = 3;
    ctx.fillStyle="white"; 
    ctx.fillText("It's gonna be ok sweetheart", 10, 450);
}
img.src = "images/0.jpg";

// ctx.beginPath();
// ctx.closePath();