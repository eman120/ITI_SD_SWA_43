/*1) Create your own function that accepts multiple parameters to
generate course information and display it. Assume that the
function accepts course information as object that contains
courseName, courseDuation, courseOwner.
if any of required field is not set in function call it should have
default values as follows: courseName=”ES6” ,
courseDuration=”3days”, courseOwner=”JavaScript”.
Bonus: through exception if passed object includes properties
other than those described above
Note: user is allowed not to pass all of these properties, he can
pass needed properties only*/

//#region task1
console.log("------------------task 1-----------------");
function crsGenerator(crsInfo){
    var defCrsInfo = {
        courseName : "ES6" , 
        courseDuation : "3days", 
        courseOwner : "JavaScript"
    };

    var result = Object.assign({} , defCrsInfo , crsInfo);

    if(Object.keys(result).length != Object.keys(defCrsInfo).length){
        throw new Error("invalid");
    }

    return result;
    // `courseName is ${result.courseName} ,
    // courseDuation is ${result.courseDuation} ,
    // courseOwner is ${result.courseOwner}`;
}

var crsInfoObj1 ={
    courseName : "AdvJS" , 
    courseDuation : "5days", 
    courseOwner : "JavaScript"
}
var crsInfoObj2 ={ 
    courseDuation : "5days", 
    courseOwner : "JavaScript"
}
// var crsInfoObj3 ={ 
//     courseLink : "https://"
// }
console.log(crsGenerator(crsInfoObj1));
console.log(crsGenerator(crsInfoObj2));
// console.log(crsGenerator(crsInfoObj3));

//#endregion

/*2) Create a generator that returns fibonacci series that takes only
one parameter. Make two different implementations as
described below:
a.the parameter passed determines the number of elements
displayed from the series.
b.the parameter passed determines the max number of the
displayed series should not exceed its value.*/

//#region task 2
console.log("------------------task 2-----------------");
console.log("fibonacci series 1 : ");
function * fibonacciSeries1(num){
    let lst =[0 , 1];
    yield lst[0]; //first element
    for(let i = 1 ; i < num ; i++){
        lst.push(lst[i] + lst[i-1]);
        yield lst[i];
    }

    // let fst = 0 , snd = 1 ;
    // for(let i = 0 ; i < num ; i++){
    //     let res = fst ;
    //     let tmp = fst + snd;
    //     fst = snd;
    //     snd = tmp ;
    //     yield res;
    // }
}
let iter1 = fibonacciSeries1(7);
console.log(iter1.next());
console.log(iter1.next());
console.log(iter1.next());
console.log(iter1.next());
console.log(iter1.next());
console.log(iter1.next());
console.log(iter1.next());
//-----------------------------------------------------------
console.log("fibonacci series 2 : ");
function * fibonacciSeries2(num2){
    let lst =[0,1];
    yield lst[0];
    for(let i = 1 ; lst[i] < num2 ; i++){
        lst.push(lst[i] + lst[i-1]);
        yield lst[i];
    }
}
let iter2 = fibonacciSeries2(7);
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
//#endregion

/*3) create your own object that has [Symbol.replace] method so
that if any long string (e.g. its length exceed 15 characters )called
replace and pass your object as replace method parameter it will
display only 15 character of string with terminating “…”*/

//#region task 3
console.log("------------------task 3-----------------");
var myObj = {
    [Symbol.replace] :function(str , len){
        if(str.length > len){
            return str.substring(0 , len)+"...";
        }
        return str;
    }
}

let strOriginal = "123456789123456789";
let strReplaced = strOriginal.replace(myObj , 15);
console.log("Original String : " ,strOriginal);
console.log("Replaced String : " ,strReplaced);
console.log("small String : " ,"123456".replace(myObj , 15));

//#endregion

/*4) Create an iterable object by implementing @@iterator method
i.e. Symbol.iterator, so that you can use for..of and retrieve its
properties.
Bonus: make proper updates to retrieve the object’s properties
and its values.*/
//#region task 4
console.log("------------------task 4-----------------");
var iterObj = {
    Name: "eman",
    ID : "43",
    Track : "SD",
    Year : "2023",
    genFun: function* (){
        var keys = Object.keys(iterObj);
        for(const key of keys){
            if(key != "genFun")
                yield [key , iterObj[key]]; 
        }
    }
}

for(const iter of iterObj.genFun()){
    console.log(iter); 
}
//#endregion