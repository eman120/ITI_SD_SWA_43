
function throwException() {
    var err;
    if (arguments.length > 2) {
        err = new Error("invalid!!!! \n number of parameters exceeds 2 parameters");
        throw err;
    }
    else if (arguments.length < 2) {
        err = new Error("invalid!!!! \n number of parameters less than 2 parameters");
        throw err;
    }
    else {
        var sum = 0;
        for (var i = 0; i < arguments.length; i++) {
            sum += arguments[i];
        }
        console.log(sum);
    }
}


//throwException(1,2,3);
//throwException(1);
//throwException(1,2);
