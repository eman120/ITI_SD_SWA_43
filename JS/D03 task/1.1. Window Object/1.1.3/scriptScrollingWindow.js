var win;
var Msg = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, mollitia est doloribus temporibus voluptas vero incidunt a officia at sed! Unde eum praesentium placeat blanditiis voluptatem incidunt, omnis sed magnam!Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, mollitia est doloribus temporibus voluptas vero incidunt a officia at sed! Unde eum praesentium placeat blanditiis voluptatem incidunt, omnis sed magnam!Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, mollitia est doloribus temporibus voluptas vero incidunt a officia at sed! Unde eum praesentium placeat blanditiis voluptatem incidunt, omnis sed magnam!Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, mollitia est doloribus temporibus voluptas vero incidunt a officia at sed! Unde eum praesentium placeat blanditiis voluptatem incidunt, omnis sed magnam!Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, mollitia est doloribus temporibus voluptas vero incidunt a officia at sed! Unde eum praesentium placeat blanditiis voluptatem incidunt, omnis sed magnam!Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, mollitia est doloribus temporibus voluptas vero incidunt a officia at sed! Unde eum praesentium placeat blanditiis voluptatem incidunt, omnis sed magnam!Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, mollitia est doloribus temporibus voluptas vero incidunt a officia at sed! Unde eum praesentium placeat blanditiis voluptatem incidunt, omnis sed magnam!Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, mollitia est doloribus temporibus voluptas vero incidunt a officia at sed! Unde eum praesentium placeat blanditiis voluptatem incidunt, omnis sed magnam!Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eveniet repellendus eligendi eaque! Odio deleniti, enim voluptatem saepe cumque dolor corporis eos dolorum dolore iste consequuntur placeat et rem, sint accusamus?Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eveniet repellendus eligendi eaque! Odio deleniti, enim voluptatem saepe cumque dolor corporis eos dolorum dolore iste consequuntur placeat et rem, sint accusamus?Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eveniet repellendus eligendi eaque! Odio deleniti, enim voluptatem saepe cumque dolor corporis eos dolorum dolore iste consequuntur placeat et rem, sint accusamus?";
var interv;
var m;
function start()
{
    openWin();
    disMsg(Msg);
}
function openWin()
{
    win = open("D03-1-1-3 scrolling windw.html" , "" , "width = 300 ,height = 100");
}
function disMsg (message)
{
    m = win.document.write(message);
    interv = setInterval("winScroll()" , 200);
    //win.close();
}
function winScroll()
{
    win.scrollBy(0,50);
}