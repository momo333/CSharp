//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//var a = console.prompt("Enter variable");
//var b = console.prompt("Enter variable");
//var c = console.prompt("Enter variable");


var a = -3;
var b = -2;
var c = -1;
var result = "Check your entered a, b and c!";

var positive = true;
if (a >= 0) {
	if (b > 0 && c < 0) {
		positive = false;
	}
	else if (b < 0 && c > 0) {
		positive = false;
	}
}
else {
	if (b > 0 && c > 0) {
		positive = false;
	}
	else if (b < 0 && c < 0) {
		positive = false;
	}
}
if (positive) {
	result = "The product will be positive!";
}
else {
	result = "The product will be negative!";
}
console.log(result);
