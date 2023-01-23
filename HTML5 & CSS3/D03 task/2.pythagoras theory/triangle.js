// conditionizr.config({
//     assets: "/Assets/",
//     tests: {
//         "chrome": ["style"],
//         "firefox": ["style"],

//     }
// })

conditionizr.load("MathPoly.js", ["chrome"])
conditionizr.load("MathPoly.css", ["chrome"])

var canvas = document.getElementById("canv1");

var ctx = canvas.getContext("2d");

ctx.beginPath();
ctx.moveTo(200,200);
ctx.lineTo(300 , 200);
ctx.lineTo(300 , 20);
ctx.closePath();
ctx.strokeStyle = "red";
ctx.fillStyle  = 'red';
ctx.fill();
ctx.stroke();

ctx.strokeStyle = "black";
ctx.fillStyle  = 'black';
ctx.font = "20pt Georgia";
ctx.fillText("a" , 250 , 250);
ctx.fillText("b" , 200 , 100);
ctx.fillText("c" , 350 , 100);

