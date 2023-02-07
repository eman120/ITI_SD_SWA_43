var Rectangle = function (wid , hei){
    this.width = wid ,
    this.height = hei,
    this.perimeter = function(){
        return (this.width + this.height)*2;
    }
    this.area = function(){
        return this.width * this.height;
    }
    this.displayInfo = function(){
        console.log("The width = " + this.width + ", height = " + this.height + " , area = " + this.area() + " , and perimeter = " + this.perimeter());
    }
}

var rect1 = new Rectangle(15 , 20);
rect1.displayInfo();
var rect2 = new Rectangle(20 , 25);
rect2.displayInfo();