const num_pattern = /^[0-9]+$/;
var arr = [5];
var header;
var sortDesc = [5];
var sortAsc = [5];

for (var i =0 ; i <5 ; i++)
{
    do{
        arr[i] = parseInt(prompt("Enter " + (i+1)+ " Element in Array "));
        sortAsc[i] = arr[i];
        sortDesc[i] = arr[i];
    }
    while(!(num_pattern.test(arr[i])))
}

sortDesc.sort(function compareNumbersDesc(a, b) 
{
    return b - a;
});
sortAsc.sort(function compareNumbers(a, b) 
{
    return a - b;
});


var Color = "red";
header = "<h1>" + "Sorting" + "</h1>" + "<hr>"+
"<span style= \"color: " + Color + "\">" + "U've entered the values of " + "</span>" +"<span>"+ arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] +"</span>"+ "<br>" + 
"<span style= \"color: " + Color + "\">" +  " Ur values after being sorted ascending "+ "</span>" +"<span>"+ sortAsc[0] + "," + sortAsc[1] + "," + sortAsc[2] + "," + sortAsc[3] + "," + sortAsc[4] + "</span>" + "<br>" + 
"<span style= \"color: " + Color + "\">" +  " Ur values after being sorted descending " + "</span>" +"<span>"+ sortDesc[0] + "," + sortDesc[1] + "," + sortDesc[2] + "," + sortDesc[3] + "," + sortDesc[4]  + "</span>" + "<br>";
document.write(header);