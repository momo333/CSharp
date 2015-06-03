

// var coordX = console.prompt("Enter coordinate X: ");
// var coordY = console.prompt("Enter coordinate Y: ");

// var rectHeight = console.prompt("height");
// var rectWidth = console.prompt("width");

var coordX = 1;
var coordY = 1;
var RECTX = 1;
var RECTY = -1;
var x = 2;
var y = 3;
var radius = 4;
sX = x - coordX;
sY = y - coordY;
if ((sX*sX + sY*sY) <= (radius*radius)) {
	var result = "IS";
}
else {
	var result = "IS NOT";
}
console.log("The point with coordinates(X:" + x + " Y:" + y + ") " + result + " within a circle with radius of " + radius + "!");
console.log();
var rectHeight = 3;
var rectWidth = 5;
var topY = 0 + (rectHeight / 2);
var rightX = 0 + (rectWidth / 2);
var bottomY = 0 - (rectHeight / 2);
var leftX = 0 - (rectWidth / 2);
console.log("Rectangle Sides Coordinates: Top Y: " + topY + " Right X: " + rightX + " Bottom Y: " + bottomY + " Left X: " + leftX);
var rectangleX = x - RECTY;
var rectangleY = y - RECTX;
if ((rectangleY < topY) && (rectangleY > bottomY) && (rectangleX < rightX) && (rectangleX > leftX)) {
	var result = "IS";
}
else {
	var result = "IS NOT";
}
console.log("The given point "+ result +" within rectangle R (top="+ RECTY +", left="+ RECTY +", width="+ rectWidth +", height="+ rectHeight +")");