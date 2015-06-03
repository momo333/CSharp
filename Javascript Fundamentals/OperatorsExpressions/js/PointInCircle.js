 
// Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). 

var x=1;
var y = 2;
var radius = 3;

if ((x * x + y * y) <= (radius * radius)) {
	var result = "IS";
}
else {
	var result = "IS NOT";
}
console.log("The point with coordinates(X:" + x + " Y:" + y + ") "+ result +" within a circle with radius of "+ radius +"!");