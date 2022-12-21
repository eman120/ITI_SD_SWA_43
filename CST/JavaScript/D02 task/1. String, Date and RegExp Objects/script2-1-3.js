var input = prompt("Enter a string : ", "Apple");

function findLargestWord(str)
{
    strArr = str.split(" ");
    var longestWord  = strArr[0];
    for(var i =1 ; i<strArr.length ; i++)
    {
        if(strArr[i].length > longestWord.length)
        {
            longestWord = strArr[i];
        }
        else if(strArr[i].length == longestWord.length)
        {
            continue;
        }
    }
    return longestWord;
}

var word = findLargestWord(input);
console.log(word);
header = "<h6>" + "The largest Word is  " + word + "</h6>";
document.write(header);