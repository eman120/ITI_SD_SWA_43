var canvas = document.getElementById("canv1");
var ctx = canvas.getContext("2d");

var grad1 = ctx.createRadialGradient(100, 100, 10, 160, 80, 150);
grad1.addColorStop(0, "white")
grad1.addColorStop(1, "blue");

ctx.fillStyle=grad1;

var grad2 = ctx.createRadialGradient(160, 100, 0, 200, 150, 150);
grad2.addColorStop(0, "white")
grad2.addColorStop(1, "blue");

//ctx.fillStyle=grad2;


ctx.beginPath();
ctx.arc(100, 100, 100, 0, 2 * Math.PI);
ctx.fillStyle=grad1;
ctx.fill();

ctx.closePath();

ctx.beginPath();
ctx.fillStyle=grad2;
ctx.arc(100, 100, 70, 0, 2 * Math.PI);
ctx.fill();

ctx.font = "100px tahoma";
// ctx.shadowColor = "white";
// ctx.shadowBlur = 3;
// ctx.shadowOffsetX = 3;
// ctx.shadowOffsetY = 3;
ctx.fillStyle="white"; 
ctx.fillText("E", 70, 140);
ctx.closePath();