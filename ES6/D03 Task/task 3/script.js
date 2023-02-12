//#region another way
// function insertData(data){
//     var tableBody = document.querySelector("#tb");
//     data.forEach(row =>{
//         tableBody.appendChild(createRow(row));
//     })
// }

// function createRow(data){
//     var row = document.createElement("tr");

//     row.appendChild(createCell("th" , data.id));
//     row.appendChild(createCell("td" , data.name));
//     row.appendChild(createCell("td" , data.username));
//     row.appendChild(createCell("td" , data.phone));
//     row.appendChild(createCell("td" , data.email));
//     row.appendChild(createCell("td" , data.website));
//     row.appendChild(createCell("td" , data.company.name));
//     row.appendChild(createCell("td" , data.address.city));

//     return row;
// }

// function createCell(element , text){
//     var newElement = document.createElement(element);
//     newElement.innerText = text;
//     return newElement;
// }

// fetch('https://jsonplaceholder.typicode.com/users')
// .then(response => response.json()
//     .then((data) => insertData(data)))
// .catch((error) => console.log(error));

//#endregion

fetch('https://jsonplaceholder.typicode.com/users')
.then(response => response.json())
.then(data => {
    var tableBody ='';
    for(var i = 0 ; i <data.length ; i++){
        tableBody += `
            <tr>
                <td>${data[i].id}</td>
                <td>${data[i].name}</td>
                <td>${data[i].username}</td>
                <td>${data[i].phone}</td>
                <td>${data[i].email}</td>
                <td>${data[i].website}</td>
                <td>${data[i].company.name}</td>
                <td>${data[i].address.city}</td>
            </tr>
        `
    }
    document.getElementById("tb").innerHTML = tableBody;
})
.catch((error) => console.log(error));