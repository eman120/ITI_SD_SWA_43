//-------task 1--------
let x = 4;
let y = 6;

[x , y] = [y , x]
console.log("-------task 1--------")
console.log ("x = " , x);
console.log ("y = " ,y);

//-------task 2-----------------------------
function getMinMax(...z){
    return [Math.min(...z),Math.max(...z)];
}

let nums = [1 , 5 , 2 , 8];
let [min , max] = getMinMax(...nums);
console.log("-------task 2--------")
console.log("min = " , min);
console.log("max = " ,max);

///-------task 3----------------------------------------
var fruits = ["apple", "strawberry", "banana", "orange","mango"];

console.log("-------task 3--------");

//a. test that every element in the given array is a string
//The every() method tests whether all elements in the array pass the test implemented by the provided function. It returns a Boolean value.
const isStringsArray = arr => arr.every(i => typeof i === "string");
console.log("Is fruits a StringsArray ? " , isStringsArray(fruits));

//====================================================================
//b.test that some of array elements starts with "a"
const isStartWithA = arr => arr.startsWith('a');
console.log("Is fruits start with a ? " , fruits.some(isStartWithA));
//console.log(fruits.some((e)=>e.startsWith('a')));

//====================================================================
//c. generate new array filtered from the given array with only elements that starts with "b" or "s"
const isStartWithBorS = arr => arr.startsWith('b') ||  arr.startsWith('s');
console.log("Is fruits start with b or s ? " , fruits.some(isStartWithBorS));
//filter 
const result = fruits.filter(fruit => fruit.startsWith('b') ||  fruit.startsWith('s'));
console.log( result);

//====================================================================
///d.generate new array, each element of the new array contains a string declaring that you like the give fruit element

//The map() method creates a new array populated with the results of calling a provided function on every element in the calling array.
var likedFruits = fruits.map(element => "I like " + element); //creates new array
console.log(likedFruits);
//another way
var likedFruits1 = []
fruits.forEach(element => likedFruits1.push("I like " + element));
console.log(likedFruits1);

//====================================================================
//e.use forEach to display all elements of the new array from previous point
likedFruits.forEach(element => console.log(element));