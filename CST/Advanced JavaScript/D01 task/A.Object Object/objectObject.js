var lnkdLstObj = {
    data: [],
    pushVal: function (val) {
        if (this.data.length == 0) {
            this.data.push({ value: val }); //push an item at the end of the list with the passed value
        }
        else if (val <= this.data[this.data.length - 1].value) {
            throw ("The data is less than the sequence");
        }
        else if (arguments.length != 1) {
            throw ("Please enter at least one parameter");
        } else {
            this.data.push({ value: val });
        }
    },
    popVal: function () {
        if (this.data.length == 0) {
            throw ("Linked List is Empty");
        }
        else {
            this.data.pop(); //remove an item from the end of the list
        }
    },
    removeVal: function (val) {
        var flag = 0;
        if (arguments.length == 0) {
            throw ("enter at least one parameter");
        }
        if (this.data.length == 0) {
            throw ("Linked List is Empty");
        }
        for (var i = 0; i < this.data.length; i++) {
            if (this.data[i].value === val) {
                this.data.splice(i, 1);
                flag = 1;
            }
        }
        if (!flag) {
            throw ("this value doesn't exist");
        }
    },
    insertVal: function (val) {
        if (arguments.length != 1) {
            throw ("enter at least one parameter");
        }
        
        if(val > this.data[this.data.length-1].value)
        {
          this.data.push({value:val});
        }

        else{
            for (var i = 0; i < this.data.length; i++) {
                if (this.data[i].value > val) {
                    this.data.splice(i, 0, { value: val });
                    break;
                }
            }
        }
    },
    enqueueVal:function(val)
    {
      if(arguments.length!=1)
      {
          throw ("Enter at least on parameter");
      }
      else if(val<this.data[0].value)
      {
        this.data.unshift({value:val}); //enter an item from the beginning of the list
      }
      else
      throw ("Enter number less than this value");
    },
    dequeueVal: function () {
        if (this.data.length == 0) {
            throw ("Linked List is Empty");
        }
        else {
            this.data.shift(); //remove an item from the beginning of the list
        }
    },
    Display: function () {
        if (this.data.length == 0) {
            throw ("Linked List is Empty");
        }
        else {
            for (var i = 0; i < this.data.length; i++) {
                console.log(this.data[i].value)
            }
        }
    }
}




console.log("Linked list after pushing data : ");
lnkdLstObj.pushVal(1);
lnkdLstObj.pushVal(2);
lnkdLstObj.pushVal(3);
lnkdLstObj.pushVal(4);
lnkdLstObj.Display();

console.log("------------------------");

console.log("Linked list after poping data : ");
lnkdLstObj.popVal();
lnkdLstObj.Display();

console.log("------------------------");

console.log("Linked list after dequeue data : ");
lnkdLstObj.dequeueVal();
lnkdLstObj.Display();

console.log("------------------------");

console.log("Linked list after inserting data : ");
lnkdLstObj.insertVal(2.5);
lnkdLstObj.insertVal(5);
lnkdLstObj.Display();

console.log("------------------------");

console.log("Linked list after removing data : ");
lnkdLstObj.removeVal(3);
lnkdLstObj.Display();