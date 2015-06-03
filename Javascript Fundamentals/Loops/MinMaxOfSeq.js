// Write a script that finds the max and min number from a sequence of numbers.

var myArray = [];
var arrayMax = 40;

var arrayNums = "";
for (var i = 0; i < arrayMax; i++) {
  myArray.push(Math.floor(Math.random()*10000));
  arrayNums +=myArray[i];
  arrayNums +=" ";
}

console.log(arrayNums);

var max = -Infinity;
var min = Infinity;
for (var i = 0; i < arrayMax; i++) {
	if (myArray[i] > max) {
		max = myArray[i];
	}
	if (myArray[i] < min) {
		min = myArray[i];
	}
}
console.log("Max: " + max + " Min: " + min);