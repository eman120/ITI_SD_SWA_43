function init(){}
var err;

function setCookie(cookieName,cookieValue,expiryDate) // Sets a cookie based on a cookie name, cookie value, and expiration date.
{
    if(arguments.length >3)
    {
        err = new Error("number of params exceed 3 params!!!!");
        throw err;
    }
    else if(arguments.length <2)
    {
        err = new Error("number of params less than 2 params!!!!");
        throw err;
    }
    // console.log(expiryDate);
    else
    {
        if(isFinite(arguments[0]))
        {
            err = new Error("please enter only string in the cookie Name!!!!");
            throw err;
        }
        else
        {
            
            if (expiryDate && (expiryDate instanceof Date))
            {
                    document.cookie = cookieName+"="+cookieValue+";expires="+expiryDate.toString(); 
                    //console.log(expiryDate.toString());
                }
                else
                {
                    document.cookie = cookieName+"="+cookieValue; 
                }
        }
    }
}
function getCookie(cookieName) {
    var cookie_val;

    var cookie = document.cookie;
    cookie = cookie.split(";");

    if(arguments.length <1)
    {
        err = new Error("you didn't enter any params!!!!");
        throw err;
    }

    else if(arguments.length >1)
    {
        err = new Error("number of params exceed 1 params!!!!");
        throw err;
    }
    else if(!(document.cookie.includes(cookieName)))
    {
        err = new Error("there is no such cookie Name!!!!");
        throw err;
    }
    else{

        for ( var i =0;i<cookie.length ; i++)
        {
            if (cookieName.trim() == (cookie[i].split("="))[0].trim())
            {
                cookie_val = cookie[i].split("=")[1].trim(); //remove spaces before and after string
                // console.log((cookie[i].split("="))[0].trim());
                // console.log((cookie[i].split("="))[1].trim());
            }
    
        }
        return cookie_val;
    }
}

function deleteCookie(cookieName) //Deletes a cookie based on a cookie name.
{
    if(arguments.length <1 )
    {
        err = new Error("you didn't enter any params!!!!");
        throw err;
    }
    else if(arguments.length >1)
    {
        err = new Error("number of params exceed 1 params!!!!");
        throw err;
    }
    else if(!(document.cookie.includes(cookieName))) // hasCookie
    {
        err = new Error("there is no such cookie Name!!!!");
        throw err;
    }
    else
    {
        var date = new Date();
        date.setDate(date.getDate()-1);
    
        document.cookie = cookieName+"=;expires="+date; 
    }
}

function  allCookieList() // returns a list of all stored cookies
{
    if(arguments.length >0)
    {
        err = new Error("allCookieList shouldn't take any params!!!!");
        throw err;
    }
    else
    {
        var cookie = document.cookie;
        var cookie_arr=[];
    
        cookie = cookie.split(";");
        for ( var i =0;i<cookie.length ; i++)
        {
            cookie_arr[(cookie[i].split("="))[0].trim()] = (cookie[i].split("="))[1].trim() ;
        }
        return cookie_arr;
    }
}

function hasCookie(cookieName) // Check whether a cookie exists or not
{
    if(arguments.length <1)
    {
        err = new Error("you didn't enter any params!!!!");
        throw err;
    }
    else if(arguments.length >1)
    {
        err = new Error("number of params exceed 1 params!!!!");
        throw err;
    }
    else if(!(document.cookie.includes(cookieName)))
    {
        err = new Error("there is no such cookie Name!!!!");
        throw err;
    }
    else
    {
        if (getCookie(cookieName)) 
        return true;
        else 
        return false;
    }
}