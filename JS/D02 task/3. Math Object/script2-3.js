const num_pattern = /^[0-9]+$/;


//==========================circle area
var radius =0;

do {
    radius = parseInt(prompt("Enter the value of a circle’s radius", "Type your value here"));
}
while (!(num_pattern.test(radius)))

var area = 2 * Math.PI * radius;
alert("Total area of the circle is " + area);

//=============================Square root
var input;

do {
    input = parseInt(prompt("Enter the value you want to calculate its square root", "Type your value here"));
}
while (!(num_pattern.test(input)))

var result =Math.sqrt(input);
alert("Square root of " + input + " is " + result);

//=============================angle cos
var angle;
var header;

do {
    angle = parseInt(prompt("Enter the angle to calculate its cos value" , "Type your value here"));
}
while (!(num_pattern.test(angle)))

var angleCos = Math.cos((angle * Math.PI) / 180).toFixed(4);

header = "<h1>" + "Cos " +angle + "\u00B0 is " + angleCos + "</h1>";
document.write(header);