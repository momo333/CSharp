// Sorting an array means to arrange its elements in
// increasing order. Write a script to sort an array. Use
// the "selection sort" algorithm: Find the smallest
// element, move it at the first position, find the
// smallest from the rest, move it at the second
// position, etc.
// Hint: Use a second array

var myArray = [];
var arrayMax = 20;

var arrayNums = "";
for (var i = 0; i < arrayMax; i++) {
	myArray.push(Math.floor(Math.random()*10));
	arrayNums +=myArray[i];
	arrayNums +=" ";
}
console.log("The Array: ")
console.log(arrayNums);

for (var i = 0; i < myArray.length-1; i++) { 
	var min = i; 
	for (var j = i+1; j < myArray.length; j++) { 
		if(myArray[j] < myArray[min]) { 
			min = j; 
		}
	}
	if(min != i) { 
		var tmp = myArray[i];
		myArray[i] = myArray[min];
		myArray[min] = tmp;
	}
}

var sorted = "";
for (var i = 0; i <myArray.length; i++) {
	sorted +=myArray[i];
	sorted +=" ";
}
console.log("The sorted array: ")
console.log(sorted);
