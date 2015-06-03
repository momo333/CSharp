// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

//var a = console.prompt("Enter a");
//var b = console.prompt("Enter b");
//var c = console.prompt("Enter c");
//var d = console.prompt("Enter d");
//var e = console.prompt("Enter e");

var a = 5;
var b = 3;
var c = 7;
var d = 4;
var e = 1;

var max = a;
if (max < b) {
	max = b;
}
if (max < c) {
	max = c;
}
if (max < d) {
	max = d;
}
if (max < e) {
	max = e;
}
result = max;
result += " is the biggest number!";
console.log(result);