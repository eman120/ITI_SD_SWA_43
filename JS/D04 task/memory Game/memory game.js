var arrImage=['images/circle.png','images/square.png','images/triangle.jpg','images/circle.png','images/square.png','images/triangle.jpg'];
shuffleArray(arrImage);
var allImage=document.getElementsByTagName('img');
var memoryGame=document.querySelector('#memoryGame');
var arrOpen=[]
memoryGame.addEventListener('click',function(e)
{
//   console.log(e.target);
//   console.log(allImage);
  for(var i=0;i<allImage.length;i++)
  {
    if(e.target==allImage[i])
    {
        console.log(allImage[i])
        
        e.target.src=arrImage[i];
        console.log("change");
    } 
   

  }
  setTimeout(function(){
    if(arrOpen.length==1)
    {
        console.log(arrOpen.length);
        if(e.target.src!=arrOpen[0].src)
        {
            e.target.src="images/question.png";
            arrOpen[0].src="images/question.png";
        }
        arrOpen.pop();
    }
    else arrOpen.push(e.target);

  },500);
  

//   allImage.forEach(function(item,index){
//     console.log(item);
//       if(e.target==item)
//       {
          
//           item.src=arrImage[index];
//       }
//   })
})

function shuffleArray(array) {
    for (var i = array.length - 1; i > 0; i--) {
       // console.log(Math.random() * (i + 1));
        var j = Math.floor(Math.random() * (i + 1));
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
