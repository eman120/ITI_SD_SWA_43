function setCookie(cookieName , cookieValue , ExpiryDate )
{
    if(ExpiryDate)
    {
        document.cookie = cookieName + "=" + cookieValue + ";expiress="+ ExpiryDate.toGMTString();
    }
    else
    {
        document.cookie = cookieName + "=" + cookieValue ;
    }
}

function getCookie(cookieName)
{
    var cookieValue;
    var cookie = document.cookie;
    cookie = cookie.split(";");
    
    for(var i = 0 ; i < cookie.length ; i++ )
    {
        if(cookieName.trim() ==  cookie[i].split("=")[0].trim())
        {
            cookieValue = cookie[i].split("=")[1].trim();
        }
    }
    return cookieValue;
}

function  allCookieList() // returns a list of all stored cookies
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

function deleteCookie(cookieName)
{
    var date = new Date();
    date.setDate(date.getDate()-1);

    document.cookie = cookieName+"=;expires="+date;
}

function hasCookie(cookieName) // Check whether a cookie exists or not
{
    if (getCookie(cookieName)) 
    return true;
    else 
    return false;
}