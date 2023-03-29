class FlightTicket {

    //or we can use constructor
    AddInfo(seat_num, flight_num, departure_airport, arrival_airport, travel_date) {
        this.seat_num = seat_num;    
        this.flight_num = flight_num;    
        this.departure_airport = departure_airport;    
        this.arrival_airport = arrival_airport;    
        this.travel_date = travel_date;    
    }

    DisplayInfo() { 
        let ticket = `Seat Number = ${this.seat_num}, Flight Number = ${this.flight_num}, 
        Departure Airport = ${this.departure_airport}, 
        Arrival Airport = ${this.arrival_airport}, Travel Date = ${this.travel_date}`;
        console.log(`Ticket Info is ${ticket}`);
    }
    GetInfo() { 
    //    return {
    //     seatNum: this.seat_num, 
    //     flightNum: this.flight_num, 
    //     departureAirport: this.departure_airport, 
    //     arrivalAirport: this.arrival_airport, 
    //     travelDate: this.travel_date
    //     };

        let ticket = `Seat Number = ${this.seat_num}, Flight Number = ${this.flight_num}, 
        Departure Airport = ${this.departure_airport}, 
        Arrival Airport = ${this.arrival_airport}, Travel Date = ${this.travel_date}`;
        return ticket;
    }
    UpdateInfo(newInfo) {
        if (newInfo.seat_num)
            this.seat_num = newInfo.seat_num; 
        if (newInfo.flight_num)
            this.flight_num = newInfo.flight_num;
        if (newInfo.departure_airport)
            this.departure_airport = newInfo.departure_airport; 
        if (newInfo.arrival_airport)
            this.arrival_airport = newInfo.arrival_airport; 
        if (newInfo.travel_date)
            this.travel_date = newInfo.travel_date;
    }
}

module.exports = {
    FlightTicket
}