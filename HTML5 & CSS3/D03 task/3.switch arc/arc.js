var canvas = document.getElementById("canv1");

var ctx = canvas.getContext("2d");

var clock = false;
var count = 0;

function switchArc(){
    
    ctx.fillStyle = "yellow";
    ctx.beginPath();
    if(count < 10)
    {
        if(clock){ //bottom half circle
            ctx.clearRect(0,0,canvas.width ,canvas.height);
            ctx.arc(150,150,100,0,Math.PI , clock); //anticlockwise
            clock= false;
            count ++;
        }
        else{ //top half circle
            ctx.clearRect(0,0,canvas.width ,canvas.height); //clockwise
            ctx.arc(150,150,100,0,Math.PI , clock);
            clock= true;
            count ++;
        }
    }
    else{ //full circle
        ctx.clearRect(0,0,canvas.width ,canvas.height);
        ctx.arc(150,150,100,0, 2*Math.PI , true);
        clearInterval(Interval);
    }
    ctx.fill();
    ctx.stroke();

} 
var Interval = setInterval(switchArc, 500);

