var myClass = function(id , loc , addr)
{
    this.ID = id,
    this.location =  loc,
    this.address = addr,
    this.getSetGen = function () {
        for (var prop in this) {
            if (typeof (this[prop]) != 'function') {
                // Getter
                this["get" + prop] = (
                    function (p) {
                        return function () {
                            return this[p];
                        }
                    }
                )(prop)
                // Setter                
                this["set" + prop] = (
                    function (p) {
                        return function (val) {
                            this[p] = val;
                        }
                    }
                )(prop)
            }

        }
    }
}

var myObj =
{
    name: "Eman",
    age: 23,
    sayHi: function () {console.log('hi')},
}

var obj = new myClass(16 , "imbaba" , "Giza");
console.log("Obj before : " + Object.keys(obj));
obj.getSetGen();
console.log("Obj after : " +Object.keys(obj));

console.log("myObj before : " + Object.keys(myObj));
obj.getSetGen.apply(myObj);
console.log("myObj after : " + Object.keys(myObj));