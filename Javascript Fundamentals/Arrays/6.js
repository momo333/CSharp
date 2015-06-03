// Write a program that finds the most frequent
// number in an array. Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


var myArray = [];
var arrayMax = 30;

var arrayNums = "";
for (var i = 0; i < arrayMax; i++) {
	myArray.push(Math.floor(Math.random()*50));
	arrayNums +=myArray[i];
	arrayNums +=" ";
}

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

var maxLength = 0;
var element = myArray[0];
var curr = 1;
for (var i = 1; i < myArray.length; i++) {
	if(myArray[i-1]===myArray[i]){
		curr++;
	}else{
		if(curr>maxLength){
			maxLength=curr;
			curr=1;
			element=myArray[i+1];
		}
	}
};
if(curr>maxLength){
	maxLength=curr;
	element=myArray[myArray.length-1];
}


console.log("The most frequent element: " + element + ", times: " + maxLength );