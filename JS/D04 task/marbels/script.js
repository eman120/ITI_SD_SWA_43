var length = 4;

var current = 0;
var prev = length;
var defaultSrc = "Images/marble1.jpg";
var newSrc = "Images/marble3.jpg";

var sliding;

var Elem = document.querySelector("#marbel");
console.log(Elem);
for(var i = 0 ; i <= length ; i++)
{
    Elem.innerHTML += "<img id= " + "'m" +  i + "'"  + "src='Images/marble1.jpg'></img>";
}
/*
var imgObj;
var imgObjPrev;
*/
function slideShow() {
    sliding = setInterval(function () {
        document.querySelector("#m"+current).src = newSrc;

        document.querySelector("#m"+prev).src = defaultSrc;

        prev = current;
        
        if (current == length) {
            current=0;
        }
        else {
           current++;
        }
    }, 500);

}

function stop() {
    clearInterval(sliding);
}         