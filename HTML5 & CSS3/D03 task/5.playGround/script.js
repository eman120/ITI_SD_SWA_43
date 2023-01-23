var canvas = document.getElementById("canv1");
var ctx = canvas.getContext("2d");

// ctx.rotate(70* Math.PI / 180);

var grad1 = ctx.createLinearGradient(0, 10, 30, 280);
grad1.addColorStop(0, "blue");
grad1.addColorStop(1, "white");

ctx.fillStyle = grad1;
ctx.strokeStyle = grad1;
ctx.fillRect(0, 0, canvas.width, canvas.height);
// ctx.strokeRect(0, 0, 100, 100);

var grad3 = ctx.createLinearGradient(0,260, 100, 500);
grad3.addColorStop(0, "black");
grad3.addColorStop(0.5, "white");
grad3.addColorStop(1, "white");

ctx.strokeStyle = grad3;
ctx.lineWidth = 3;
//ctx.fillRect(0, 250, canvas.width, canvas.height/2);
ctx.moveTo(150,260);
ctx.lineTo(150 , 150);
ctx.lineTo(300 , 150);
ctx.lineTo(300 , 260);
ctx.stroke();

var grad2 = ctx.createLinearGradient(0, 250,  30, 500);
grad2.addColorStop(0, "green");
grad2.addColorStop(1, "white");

ctx.fillStyle = grad2;
ctx.strokeStyle = grad2;
ctx.fillRect(0, 250, canvas.width, canvas.height/2);
// ctx.strokeRect(0, 0, 100, 100);

var grad3 = ctx.createRadialGradient(190, 100, 0, 190, 130, 170);
grad3.addColorStop(0, "white")
grad3.addColorStop(1, "black");

ctx.beginPath();
ctx.fillStyle=grad3;
ctx.arc(230, 250, 40, 0, 2 * Math.PI);
ctx.fill();