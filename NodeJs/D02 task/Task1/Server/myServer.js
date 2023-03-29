// Create your own module that can be used in flight tickets reservation
// o Let the flight ticket contains info about
//  seat num,
//  flight num,
//  departure and arrival airports
//  Travelling date.
// o User can display, get and update info of his ticket

let {FlightTicket} = require("../Task1/Modules/myModule");

// Create a new flight ticket
///using constructor
// let ticket1 = new FlightTicket('A15', 'AI202', 'DEL', 'LHR', '2023-04-15');
///using AddInfo function
let ticket1 = new FlightTicket();
ticket1.AddInfo('A15', 'AI202', 'DEL', 'LHR', '2023-04-15');

// Display the ticket information
ticket1.DisplayInfo();

// Get the ticket information
let ticketInfo = ticket1.GetInfo();
// console.log(`Ticket Info Get: ${JSON.stringify(ticketInfo)}`);
console.log(`Ticket Info Get: ${ticketInfo}`);

// Update the ticket information
ticket1.UpdateInfo({
    seat_num: 'B12',
    arrival_airport: 'JFK'
});

// Display the updated ticket information
ticket1.DisplayInfo();