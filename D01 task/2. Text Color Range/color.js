var red = document.getElementById("red");
var green = document.getElementById("green");
var blue = document.getElementById("blue");
function change(){
    var color = 'rgb(' + red.value + ',' + green.value + ','  + blue.value+ ')';
    document.getElementById("txt").style.color = color;
}

red.addEventListener("input", change);
green.addEventListener("input", change);
blue.addEventListener("input", change);

//rgb(0,0,255)

// red.addEventListener("click",function(){
//     document.getElementById("txt").style.color = 'rgb(' + red.value + ',' + blue.value + ','  + green.value+ ')' ;
//     //"#"+(red.value).toString(16)+(green.value).toString(16)+(blue.value).toString(16);
//      //'"rgb(' + red.value + ',' + blue.value + ','  + green.value+ ')"' ;
//     console.log(red.value);
// })