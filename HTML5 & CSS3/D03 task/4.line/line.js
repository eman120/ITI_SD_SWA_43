var canvas = document.getElementById("canv1");

var ctx = canvas.getContext("2d");
var x = 100;
var y = 100;
var Interval;

ctx.beginPath();
ctx.fillStyle = "red";
ctx.strokeStyle = "red";
ctx.moveTo(0 , 0);

function moveLine(){
    ctx.lineTo(x+=5,y+=5);
    console.log(x , y)
    if(x == canvas.width+5 && y == canvas.height+5) // 450
    {
        clearInterval(Interval);
        alert("animation end");
    }
    ctx.lineWidth =10;
    ctx.fill();
    ctx.stroke();
}

Interval = setInterval(moveLine , 500);

console.log(canvas.width , canvas.height)