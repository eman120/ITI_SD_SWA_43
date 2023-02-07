var listObj = function(start=0 , end=0 , step=0)
{
    var self = this;
    
    self.start = start;
    self.end = end;
    self.step = step;
    
    var list = [];
    var fillList = function()
    {
        if(isFinite(self.start) && isFinite(self.end) !== undefined)
        {
            for( var i = self.start ; i<= self.end ; i+=self.step )
            {
                    list.push(i);
            }
        }
    }

    if(self.start !== undefined && self.end !== undefined)
    {
        fillList();
    }

    Object.defineProperties(self ,
        {
            append : {
                value: function (num) {
                    if(list.length == 0 || num === list[list.length-1] + step )
                    {
                        list.push(num);
                    }
                }

            },

            prepend : {
                value: function (num) {
                    if(list.length == 0 || num === list[0] - step )
                    {
                        list.unshift(num);
                    }
                }

            },

            pop : {
                value: function () {
                    list.pop();
                }

            },

            dequeue : {
                value: function () {
                    list.shift();
                }

            },

            toString : {
                value: function () {
                    console.log(list.join(","));
                }

            },


        } )
}


var obj1 = new listObj(1 , 7 , 3);
obj1.toString();

obj1.append(10);
obj1.toString();

obj1.prepend(-2);
obj1.toString();

obj1.pop();
obj1.toString();

obj1.dequeue();
obj1.toString();

var obj2 = new listObj(1 , "s" , 3);

obj2.toString();