
var inputName ;
var phoneNumber ;
var mobileNumber ;
var Email ;
var Color ;

do{
    inputName = prompt("Enter your name : ", "Eman");
}
while (!(inputName.match(/^([a-zA-Z]+)$/g))) 

do{
    phoneNumber = prompt("Enter your phoneNumber : ", "12345378");
}
while (!(phoneNumber.match(/^[0-9]{8}$/))) 

do{
    mobileNumber = prompt("Enter your mobileNumber : ", "01117702484");
}
while (!(mobileNumber.match(/^01[0-2][0-9]{8}$/))) 

do{
    Email = prompt("Enter your Email : ", "Eman@gmail.com");
}
while (!(Email.match(/^([a-zA-Z]+@[a-zA-Z]+.[a-zA-Z]+)$/))) 

do{
    Color = prompt("Enter your Color : (red , green or blue) ", "red");
}
while (!(Color == "red" || Color == "green" || Color == "blue" ) )

/*header = "<h1>" + "Entering User INFO" + "</h1>" +"<br>" + "<hr>"+
"<span style= \"color: " + Color + "\">" + "Welcome dear guest " + "</span>" +"<span>"+ inputName +"</span>"+ "<br>" + 
"<span style= \"color: " + Color + "\">" +  " your phoneNumber is "+ "</span>" +"<span>"+ phoneNumber + "</span>" + "<br>" + 
"<span style= \"color: " + Color + "\">" +  " your mobileNumber is " + "</span>" +"<span>"+ mobileNumber + "</span>" + "<br>" + 
"<span style= \"color: " + Color + "\">" +  " your Email is " + "</span>" +"<span>"+ Email + "</span>";*/

document.write(header);
