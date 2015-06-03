// Sort 3 real values in descending order.
// Use nested if statements.

//var a = console.prompt("Enter variable");
//var b = console.prompt("Enter variable");
//var c = console.prompt("Enter variable");


var a = -2;
var b = -7;
var c = 5;

if (a > b) {
	if (a > c) {
		result = a;
		if (b > c) {
			result += " " + b + " " + c;
		}
		else {
			result += " " + c + " " + b;
		}
	}
	else {
		result = c + " " + a + " " + b;
	}
}
else {
	if (b > c) {
		result = b;
		if (c > a) {
			result += " " + c + " " + a;
		}
		else {
			result += " " + a + " " + c;
		}
	}
	else {
		result = c + " " + b + " " + a;
	}
}
result += " are the sorted numbers";
console.log(result);