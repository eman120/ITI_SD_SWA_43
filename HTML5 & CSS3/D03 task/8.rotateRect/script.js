var canvas = document.getElementById("canv1");
var ctx = canvas.getContext("2d");

var Interval;
var x= 50 , y=30;
var angle = 0, direction = 1;
var count = 0;
ctx.fillStyle = "pink";
ctx.globalAlpha = 0.8;

//var angle = 30 * Math.PI / 180 ;
//var dlt = -30 * Math.PI / 180;
//ctx.beginPath();
//ctx.clearRect(0,0, 1000, 1000);
//ctx.moveTo(x,y);
//ctx.translate(500,300);
// ctx.strokeStyle = "pink";
// ctx.strokeWidth = 5;

Interval = setInterval(function(){
    rotateRect() ;
    //ctx.restore();
}, 200);


function rotateRect(){
    ctx.save();
    ctx.beginPath();
    ctx.translate(canvas.width/2, canvas.height/2);
    ctx.rotate(angle * Math.PI / 180);
    console.log(angle);
    ctx.fillRect(-100 , 50*.1, 100, 40);
    ctx.restore();
    angle += (20*direction);
    if (angle >= 360 || angle <= 0){
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        direction *= -1;
    }
    // ctx.lineTo(300,300);
    // ctx.stroke();
    //count++;
    //ctx.save();
    // Reset transformation matrix to the identity matrix
    //ctx.setTransform(1, 0, 0, 1, 0, 0);
    // if(count == 12){
    //     ctx.save();
    // }

    // if(count > 12){
    //     // clearInterval(Interval);
    //     if(angle == 30 * Math.PI / 180){
    //         angle = - 30 * Math.PI / 180;
    //     }
    //     else{
    //         angle = 30 * Math.PI / 180;
    //     }
    //     count = 0;
    //     //ctx.restore();
    //     //ctx.rotate(angle);
    //     ctx.clearRect(-500,-300, canvas.width, canvas.height);
    // }

    // if(){
    //     ctx.rotate(angle);
    //     ctx.fillRect(x , y, 100, 50);
    // }
}




// var canvas = document.getElementById('canv1');
// if (canvas.getContext) {
//     var context = canvas.getContext('2d'), angle = 0, direction = 1;

//     context.globalAlpha = 0.5;

//     setInterval(function(){
//         context.save();
//         context.beginPath();
//         context.translate(canvas.width/2, canvas.height/2);
//         context.rotate(angle * Math.PI / 180);
//         context.rect(-100 , 50*.1, 100, 40);
//         context.fillStyle = 'lightpink';
//         context.fill();
//         context.restore();

//         angle += (20*direction);
//         if (angle >= 360 || angle <= 0){
//             context.clearRect(0, 0, canvas.width, canvas.height);
//             direction *= -1;
//         }
//     },300)
// }
