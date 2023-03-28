const http = require("http");
const fs = require("fs");
var url ="";
http.createServer((req,res)=>{
    //logic
    if(req.url != "/favicon.ico"){
        console.log(req.url);
        url = req.url.toString();
        var urlArr = url.split("/");
        var op = urlArr[1];
        var sum = parseInt(urlArr[2]);
        switch(op){
            case "add":
                for(var i = 3 ; i < urlArr.length ; i++){
                    sum += parseInt(urlArr[i]);
                }
                console.log(sum);
                fs.appendFile("result.txt",sum.toString()+ "\n",()=>{})
                sum = 0;
            break;
            case "sub":
                for(var i = 3 ; i < urlArr.length ; i++){
                    sum -= parseInt(urlArr[i]);
                }
                console.log(sum);
                fs.appendFile("result.txt",sum.toString()+ "\n",()=>{})
                sum = 0;
            break;
            case "div":
                for(var i = 3 ; i < urlArr.length ; i++){
                    sum /= parseInt(urlArr[i]);
                }
                console.log(sum);
                fs.appendFile("result.txt",sum.toString()+ "\n",()=>{})
                sum = 0;
            break;
            case "mul":
                for(var i = 3 ; i < urlArr.length ; i++){
                    sum *= parseInt(urlArr[i]);
                }
                console.log(sum);
                fs.appendFile("result.txt",sum.toString() + "\n",()=>{})
                sum = 0;
            break;
        }
        res.writeHead(200,"ok",{"content-type":"text/plain"})
        res.write("<h1>Hello World at Server</h1>")
        res.end();
    }
}).listen(7000)
