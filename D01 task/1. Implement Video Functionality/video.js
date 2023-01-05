var vid = document.getElementById("video");
var slide = document.getElementById("videoSlide");
var volumeSlide = document.getElementById("volume");
var speedSlide = document.getElementById("speed");
var totalTime = document.getElementById("totalTime");
var time = document.getElementById("time");
var result;
var Interval;

slide.value = 0;

//control the video slidder
slide.addEventListener("input",function(){
    vid.currentTime = slide.value;
})

//start the video
document.getElementById("play").addEventListener("click",function(){
    vid.play(); //on time update
    // Interval = setInterval(function(){
    //     slide.value++;
    // },500);
    vid.addEventListener('timeupdate',function(){
        slide.value = vid.currentTime;
        time.innerText = new Date(parseInt(vid.currentTime) * 1000).toISOString().slice(11, 19) + " /";
        totalTime.innerText = new Date(parseInt(vid.duration) * 1000).toISOString().slice(11, 19);
    });
})

//stop the video
document.getElementById("stop").addEventListener("click",function(){
    vid.pause();
    //vid.defaultPlaybackRate =1.0;
})

//back to the video start
document.getElementById("backToBegin").addEventListener("click",function(){
    vid.play();
    vid.currentTime = 0;
    slide.value = slide.min;
})

//back 5 seconds 
document.getElementById("back").addEventListener("click",function(){
    vid.currentTime = vid.currentTime - 5;
    slide.value = vid.currentTime;
})

//next 5 seconds 
document.getElementById("next").addEventListener("click",function(){
    vid.currentTime = vid.currentTime + 5;
    slide.value = vid.currentTime;
})

//go to the video end 
document.getElementById("nextToEnd").addEventListener("click",function(){
    if(!vid.ended){
        vid.currentTime = vid.duration;
        slide.value = slide.max;
    }
})

//volume slider
volumeSlide.addEventListener("input",function(){
    vid.volume = volumeSlide.value;
})

//mute button
var btn = document.getElementById("mute");
btn.addEventListener("click",function(){
    if(btn.value == "mute")
    {
        vid.muted = true;
        btn.value = "unmute";
    }
    else{
        vid.muted = false;
        btn.value = "mute";

    }
})

//speed slider
speedSlide.addEventListener("input",function(){
    vid.playbackRate = speedSlide.value;
})
