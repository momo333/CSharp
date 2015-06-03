// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
// Calculates and prints its real roots.

//var a = console.prompt("Enter a");
//var b = console.prompt("Enter b");
//var c = console.prompt("Enter c");

var a = 1;
var b = 1;
var c = 3;
if (a == 0) {
	console.log("This is not an quadric equation!");
}
else {
	var discriminant = (b * b) - (4 * a * c);
	if (discriminant > 0) {
		var x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
		var x2 = (-b - Math.sqrt(discriminant)) / (2 * a);
		console.log("The equation roots are: \nX1:" + x1 +" \nX2: " + x2);
	}
	else if (discriminant == 0) {
		var x = -b / (2 * a);
		console.log("The equation has only one root: " + x);
	}
	else if (discriminant < 0) {
		console.log("The equation doesn't have solution!");
	}
}