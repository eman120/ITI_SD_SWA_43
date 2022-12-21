function init()
{
    var mainDiv = window.document.body.firstElementChild;
    var imgDiv = mainDiv.firstElementChild;

    imgDiv.style.textAlign = "right"; //moving div to right

    var newImg = document.createElement("img"); //create image element
    newImg.src = "dom.jpg"; //add image source

    var newDiv = document.createElement("div"); //create div element
    newDiv.style.textAlign = "left"; //moving div to left
     
    mainDiv.append(newDiv);
    newDiv.append(newImg);


    var ulDiv = imgDiv.nextElementSibling;
    var ulElement = ulDiv.firstElementChild;
    ulElement.style = "list-style-type: circle";
}