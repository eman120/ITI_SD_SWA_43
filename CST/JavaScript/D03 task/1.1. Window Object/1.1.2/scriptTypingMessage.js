//var text = prompt("please enter the text you want to display");
//var list = text.split("");
//var n = list.length;
//var msg_interval;

/*
var notes1 = ["Your Message will be displayed charachter by charachter :)"];
var notes2 = ["few seconds and this window will terminate !!"];
*/
var win;
var count;
var msg = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eveniet repellendus eligendi eaque! Odio deleniti, enim voluptatem saepe cumque dolor corporis eos dolorum dolore iste consequuntur placeat et rem, sint accusamus?";

function showMessage() {
    openWin();
    count = 0;
    interv = setInterval("disMsg(msg , count++)", 50);
    //msg_interval = setInterval(display, 100);
}
/*
function display() {
    if (list.length==0)
    {
        clearInterval(msg_interval);

        setTimeout(closeWin, 2000);
    }
    else
    {
        win.document.write(list.shift());
    }
}
*/
function disMsg(message, index) {
    win.document.write(message[index]);
    if (index == message.length) {
        setTimeout(win.close() , 2000);
    }
}

function openWin() {
    win = open("D03-1-1-2 Typing Message.html", "", "width = 300 , height = 200");
    win.focus();
}
/*
function closeWin() {
    win.close();
}
*/
