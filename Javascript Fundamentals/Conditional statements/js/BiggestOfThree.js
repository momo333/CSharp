// Write a script that finds the biggest of three numbers.
// Use nested if statements.

//var a = console.prompt("Enter variable");
//var b = console.prompt("Enter variable");
//var c = console.prompt("Enter variable");


var a = -3;
var b = -2;
var c = -1;

if (a > b) {
	if (a > c) {
		result = a;
	}
	else {
		result = c;
	}
}
else {
	if (b > c) {
		result = b;
	}
	else {
		result = c;
	}
}
result += " is the biggest number!";
console.log(result);

