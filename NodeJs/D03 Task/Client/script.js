// Fetch the client data from the server
document.getElementById("showData").addEventListener("click", () => {
  let clientData = "";
  fetch("/showData").then(response => response.json()).then(data => {
      // Build the HTML string for the client data table
      clientData += `
            <tr>
              <th>Name</td>
              <th>Mobile</td>
              <th>Email</td>
              <th>Address</td>
            </tr>`;
        for (let i = 0; i < data.length; i++) {
          clientData += `
            <tr>
              <td>${data[i].name}</td>
              <td>${data[i].mobile}</td>
              <td>${data[i].email}</td>
              <td>${data[i].address}</td>
            </tr>
          `;
        }
        
        window.document.getElementById("clientData").innerHTML = clientData;
      }).catch(error => {
        console.log(error)
    });
  });
  
  
  // Retrieve the clientData from local storage

// Set the clientData as the innerHTML of the clientData element

// Store the clientData in local storage
// localStorage.setItem('clientData', clientData);
// // Store the clientData in local storage
// localStorage.setItem('clientData', clientData);
// // window.document.getElementById("clientData").innerHTML = clientData;
// // Redirect to another page
// window.location.href = "http://localhost:7000/getAll";
// const clientDataN = localStorage.getItem('clientData');