// Write a script that finds the maximal increasing
// sequence in an array. Example:
// {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

var myArray = [];
var arrayMax = 20;

var arrayNums = "";
for (var i = 0; i < arrayMax; i++) {
	myArray.push(Math.floor(Math.random()*10));
	arrayNums +=myArray[i];
	arrayNums +=" ";
}

console.log(arrayNums);

var curr = 1;
var maxL = 0;
var lastIndex = 0;
for (var i = 1; i < myArray.length; i++) {
	if (myArray[i - 1] + 1 === myArray[i]) {
		curr++;
	}
	else {
		if (maxL < curr) {
			maxL = curr;
			curr = 1;
			lastIndex = i;
		}
	}
}
if (maxL < curr) {
	maxL = curr;
	lastIndex = myArray.length;
}

console.log("Maximum increasing sequence: ");
var result = "";
for (var i = 0; i < maxL; i++) {
	result+=myArray[lastIndex-maxL+i];
	result += " ";
};
console.log(result);