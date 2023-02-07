var imgArr = [];

var current = 0;

var sliding;

imgArr[0] = "Images/1.jpg";

imgArr[1] = "Images/2.jpg";

imgArr[2] = "Images/3.jpg";

imgArr[3] = "Images/4.jpg";

imgArr[4] = "Images/5.jpg";

imgArr[5] = "Images/6.jpg";



function nextImg() {

    imgObj = document.getElementById("image");
    if (current < imgArr.length - 1) {
        imgObj.src = imgArr[++current];
    }

}

function prevImg() {
    imgObj = document.getElementById("image");
    if (current > 0) {
        imgObj.src = imgArr[--current];
    }

}

function slideShow() {
    imgObj = document.getElementById("image");
    sliding = setInterval(function () {
        if (current < imgArr.length - 1) {
            imgObj.src = imgArr[++current];
        }
        else {
            current = 0;
            imgObj.src = imgArr[current++];
        }
    }, 500);

}
function stop() {
    clearInterval(sliding);
}