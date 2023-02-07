/*
function myFun()
{
    var sum =0;
    for(var i=0 ; i<arguments.length ; i++)
    {
        sum+= arguments[i];
    }
    return sum;
}

console.log(myFun(5,6,7));

//============================================================================

function sum() {
    return Array.prototype.reduce.call(arguments, function(a, b) {
        return a + b;
    }, 0);
}

console.log(sum(5,8,7));

//============================================================================

const sum2 = (...args) => args.reduce((a, b) => a + b);

console.log(sum2(1, 3, 5, 7, 9));

//============================================================================

function sum3() {
    var args = Array.prototype.slice.call(arguments);
    var sum = args.reduce(function(a, b) {
        return a + b;
    })
    return sum;
}

console.log(sum3( 5, 7, 1, 2));
*/

//============================================================================
/*
function rev() {
    return Array.prototype.reverse.call(arguments);
}

console.log(rev(5,8,7));
*/

//============================================================================

const rev = (...args) => args.reverse();
//console.log(rev(5,8,7));
//============================================================================

function rev1() {
    return [].reverse.call(arguments);
}

console.log(rev1(5,8,7));


//============================================================================

function rev2() {
    return [].reverse.apply(arguments);
}

console.log(rev2(5,8,7));
