var arr = new Array();
var sum = 0;
var mul = 1;
var header;

for (var i =0 ; i <3 ; i++)
{
    arr[i] = parseInt(prompt("Enter " + (i+1)+ " Element in Array "));
    sum += arr[i];
    mul *= arr[i];
}

var div = arr[0] / arr[1] / arr[2];

var Color = "red";
header = "<h1>" + "Adding -- Multiplting -- Dividing 3 Numbers" + "</h1>" +"<br>" + "<hr>"+
"<span style= \"color: " + Color + "\">" + "Sum of the 3 Numbers " + "</span>" +"<span>"+ arr[0] + "+" + arr[1] + "+" + arr[2] + "=" + sum +"</span>"+ "<br>" + 
"<span style= \"color: " + Color + "\">" +  " Multiplication of the 3 Numbers "+ "</span>" +"<span>"+ arr[0] + "*" + arr[1] + "*" + arr[2] + "="+ mul + "</span>" + "<br>" + 
"<span style= \"color: " + Color + "\">" +  " Division of the 3 Numbers " + "</span>" +"<span>"+ arr[0] + "/" + arr[1] + "/" + arr[2] + "="+ div.toFixed(3) + "</span>" + "<br>";
document.write(header);