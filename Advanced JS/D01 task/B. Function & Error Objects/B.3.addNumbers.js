function addingNumbers ()
{
    var err;
    var sum =0;
    if (arguments.length ==0)
    {
        err = new Error("you don't enter any data!!!");
        throw err;
    }
    
    else 
    {
        var sum =0;
        for(var i=0 ; i<arguments.length ; i++)
        {
            if (isNaN(arguments[i]))
            {
                err = new Error("please enter numbers only!!!");
                throw err;
            }
            else{

                sum += arguments[i]; 
            }
        }
        console.log(sum);
    }
}

//addingNumbers ();
//addingNumbers (1 , "a" , 3);
//addingNumbers (1 , 2 , 3);
