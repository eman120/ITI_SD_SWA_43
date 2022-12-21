function init()
{
    document.addEventListener('contextmenu', function(event){
        event.preventDefault();
        alert("you can't open context menu -_<");
    } );
}