//#region canvas
var canvas = document.getElementById("canv1");
var ctx = canvas.getContext("2d");

ctx.fillStyle = "black";
ctx.strokeStyle = "black";
//#endregion

// Define the Polygon class
class Polygon{
    constructor(height = 0 , width = 0 ){
        this.height = height;
        this.width = width;
    }
    // Override the toString() method
    toString(){
        return `It's the polygon`;
    }
}

// Define the Rectangle class that inherits from Polygon
class Rectangle extends Polygon{
    constructor(height , width){
        super(height,width)
        this.height = height;
        this.width = width;
    }
    // Calculate the area
    getArea(){
        return this.height * this.width;
    }
    // Override the toString() method
    toString(){
        return `Rectangle height = ${this.height} , width = ${this.width} and Area = ${this.getArea()}`;
    }

    draw( x , y , w , h){
        ctx.fillRect(x , y , w , h);
    }
}

// Define the Square class that inherits from Rectangle
class Square extends Rectangle{
    constructor(height){
        super(height,height)
        this.height = height;
    }
    
    // Override the toString() method
    toString(){
        return `Square height = ${this.height} , width = ${this.height} and Area = ${this.getArea()}`;
    }
    
    // Calculate the area
    // getArea(){
    //     return Math.pow(this.height , 2 );
    // }
    
    // draw( x , y , w , h){
    //     ctx.fillRect(x , y , w , h);
    // }
}

// Define the Circle class that inherits from Polygon
class Circle extends Polygon{
    constructor(radius){
        super(radius)
        this.radius = radius;
    }
    // Calculate the area
    getArea(){
        return Math.PI * this.radius * this.radius;
    }
    // Override the toString() method
    toString(){
        return `Circle radius = ${this.radius} and Area = ${this.getArea()}`;
    }
    draw(x , y , r , s , e){
        ctx.arc(x , y , r , s , e);
    }
}

// Define the Triangle class that inherits from Polygon
class Triangle extends Polygon{
    constructor(height , base ){
        super(height,base )
        this.height = height;
        this.base = base;
    }
    // Calculate the area
    getArea(){
        return (1/2) * this.height * this.base;
    }
    // Override the toString() method
    toString(){
        return `Triangle height = ${this.height} , base = ${this.base} and Area = ${this.getArea()}`;
    }
    draw(x1 , y1 , x2 , y2 , x3 , y3){
        ctx.moveTo(x1 , y1);
        ctx.lineTo(x2 , y2 );
        ctx.lineTo(x3 , y3);
    }
}

// Create instances of the different shapes
var r = new Rectangle(100 , 150);
var s = new Square(100);
var c = new Circle(50);
var t = new Triangle(100 , 100);

// Log the area and object parameters of each shape
console.log(r.toString());
console.log(s.toString());
console.log(c.toString());
console.log(t.toString());

// Draw the shapes to a canvas element

// Draw the Rectangle
r.draw(50, 50, r.width, r.height);

// Draw the Square
s.draw(300, 50, s.height, s.height);

ctx.beginPath();

// Draw the Circle
c.draw(250, 250, c.radius, 0, 2 * Math.PI);

// Draw the Triangle
t.draw(150, 350 ,150 + t.height, 350 + t.height , 250 + t.base, 350);
ctx.fill();

// ctx.moveTo(150, 350);
// ctx.lineTo(150 + t.height, 350 + t.height);
// ctx.lineTo(250 + t.base, 350);