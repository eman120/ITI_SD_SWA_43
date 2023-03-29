const http = require("http");
const fs = require("fs");
let mainHtml = fs.readFileSync("../Client/main.html").toString();
let welcomeHtml = fs.readFileSync("../Client/welcome.html").toString();
let styleCSS = fs.readFileSync("../Client/style.css").toString();
let scriptJS = fs.readFileSync("../Client/script.js").toString();
let favIcon = fs.readFileSync("../Client/Icons/scientist.png");
// let favIcon = fs.readFileSync("../Client/Icons/favicon.ico");
let clientHtml = fs.readFileSync("../Client/getAll.html").toString();
let client=[];
if (fs.readFileSync("clients.json").length >0) {
  client = JSON.parse(fs.readFileSync("clients.json"));

}

let clientName="";
let mobileAddress="";
let email="";
let address="";
let d = "";

http.createServer((req,res)=>{
    //#region GET
    if(req.method == "GET"){
        switch(req.url){
            case '/':
            case '/main.html':
            case '/Client/main.html':
                res.write(mainHtml);
            break;
            case '/':
            case '/welcome.html':
            case '/client/welcome.html':
                res.write(welcomeHtml);
            break;
            case '/style.css':
            case '/Client/style.css':
                res.write(styleCSS);
            break;
            case '/favicon.ico':
            case '/Client/scientist.png':
                res.write(favIcon);
            break;
            case '/script.js':
            case '/Client/script.js':
                res.write(scriptJS);
            break;
            case "/showData":
            case "/Client/showData":
                // console.log(JSON.stringify(client));
                res.write(JSON.stringify(client));
            break;
            case "/getAll":
            case "/Client/getAll":
                // console.log(JSON.stringify(client));
                res.write(clientHtml);
            break;
        }
        res.end();
    }
    //#endregion

    //#region POST
    else if (req.method == "POST"){
        req.on("data" , (data)=>{
            d = data.toString().split("=");
            clientName = d[1].split("&")[0].replace('+' , ' ');
            mobileAddress = d[2].split("&")[0].replace('+' , ' ');
            email = d[3].toString().split("&")[0].replace('%40' , '@');
            address = d[4].toString().split("&")[0].replace('+' , ' ').replace('%2C' , ',');
            let clientData = { name: clientName, mobile: mobileAddress, email: email, address: address };

            ///create new file , if it doesn't exist
            // ENOENT error code which is raised when the file does not exist. If this error is raised, we assume that the file does not exist, and create a new one with an empty array. Then we proceed to parse the contents of the file, and add the new client data to the array. Finally, we write the updated array back to the file.
            fs.readFile("clients.json", (err, data) => {
                if (err) {
                  if (err.code === "ENOENT") {
                    console.log("clients.json file does not exist. Creating a new one...");
                    data = "[]";
                  } else {
                    console.error(err);
                    return res.end("Error reading file");
                  }
                }
                
                let clients = [];
                if (data && data.length > 0) {
                    clients = JSON.parse(data);
                }
              
                clients.push(clientData);
              
                fs.writeFile("clients.json", JSON.stringify(clients), (err) => {
                  if (err) throw err;
                  console.log("Data written to file");
                });
              });
        

            ///doesn't create new file , if it doesn't exist
            // if(fs.existsSync("clients.json")){

            //     fs.readFile("clients.json", (err, data) => {
            //         if (err) {
            //           console.error(err);
            //           return res.end("Error reading file");
            //         }
            //         // let clients = [];
            //         // try {
            //         //   clients = JSON.parse(data);
            //         // } catch (err) {
            //         //     console.error(err);
            //         //   return res.end("Error reading file");
            //         // }
              
            //         let clients = [];
            //         if (data && data.length > 0) {
            //             clients = JSON.parse(data);
            //         }
    
            //         clients.push(clientData);
              
            //         fs.writeFile("clients.json", JSON.stringify(clients), (err) => {
            //           if (err) throw err;
            //           console.log("Data written to file");
            //         });
            //       });
            // }
            // else {
            //     console.log(`File \"clients.json\" does not exist`);
            // }
        });
        req.on("end", () => {
            res.write(
              welcomeHtml
                .replace("{clientName}", clientName)
                .replace("{MobileNumber}", mobileAddress)
                .replace("{Email}", email)
                .replace("{Address}", address)
            );
        
            res.end();
          });
    }
    //#endregion

    //#region Default
    else{
        res.end("Please Select Common Method");
    }
    //#endregion
}).listen(7000,()=>{console.log("Listining on Port 7000")})