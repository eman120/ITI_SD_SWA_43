var win;
var Interval;
var flag = false;

function startInterval()
{
    Interval = setInterval("moveWin()",500);
}

function openWin() 
{
    win = open("D03-1-1-1 flying window.html", "", "width = 50 , height = 50");
    win.focus();
    startInterval();
}

function moveWin()
{
    if(win.screenX >= 1150 && win.screenY >= 500)
    {
        flag = false;
    }
    else if(win.screenX == 0 && win.screenY ==0)
    {
        flag = true;
    }

    if(flag)
    {
        win.moveBy(50 , 25);
    }
    else
    {
        win.moveBy(-50 , -25);
    }
}

function closeWin()
{
    win.close();
    win.focus();
}

function stopWin()
{
    clearInterval(Interval);
    win.focus();
}