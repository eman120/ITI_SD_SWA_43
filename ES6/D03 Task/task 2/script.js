const student = { 
    name: "Mohamed", 
    address: "123 St.", 
    age: 40,
    toString (){
      return `Name is ${this.name} , Address is ${this.address} and Age is ${this.age}`
    }
}
const validator = {
    set: function(target, prop, value) {
        if(target.hasOwnProperty(prop)){
            if (prop === 'name' && typeof value === 'string' && value.length === 7) {
              target[prop] = value;
            } else if (prop === 'address' && typeof value === 'string') {
              target[prop] = value;
            } else if (prop === 'age' && isFinite(value) && value >= 25 && value <= 60) {
              target[prop] = value;
            } else {
                console.log(`Invalid property value ${prop}`);
            }
        }
        else{
            console.log("Invalid property");
        }
    }
  };
  
  const obj = new Proxy(student, validator);

  // obj.name = 'EEmmaan'; // will be set because the name is a string of 7 characters
  // obj.address = '123 Main St.'; // will be set because the address is a string
  // obj.age = 30; // will be set because the age is between 25 and 60
  // console.log(obj.toString()); // { name: 'EEmmaan', address: '123 Main St.', age: 30 }


  obj.name = 'Eman'; // will be set because the name is a string of 7 characters
  obj.address = 123 ; // will be set because the address is a string
  obj.age = 23; // will be set because the age is between 25 and 60
  console.log(obj.toString()); // { name: 'Mohamed', address: '123 Main St.', age: 30 }