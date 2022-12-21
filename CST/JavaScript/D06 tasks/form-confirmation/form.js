function init(){
    reassign();
    //create new Event
    var newEvent = new Event("Time");
    //listen -- register
    document.getElementById("sub").addEventListener("Time" , function(){
        var name = document.getElementById("username");
        var age = document.getElementById("userage");
        if(name.value == "" && age.value == "")
        {
            alert("You haven't entered any data yet!!!!!");
        }
    });
    
    setTimeout(function(){
        document.getElementById("sub").dispatchEvent(newEvent);
    },30000);
}

function confirmMessage()
{
    var confirmSubmit = confirm("Do you really want to submit?");  //excute a confirmation massage 
    if(confirmSubmit)
    {
        document.getElementById("sub").type = "submit";
        open("welcomeWin.html" , "" , "width = 200 , height = 200");  //pop up window 
    }   
}

function closeWin()
{
    close();
}

function reassign()
{
  document.getElementById("username").value="";
  document.getElementById("userage").value = "";
  document.getElementById("sub").type = "button";
}