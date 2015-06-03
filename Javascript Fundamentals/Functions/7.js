// Write a function that returns the index of the first
// element in array that is bigger than its neighbors, or
// -1, if there’s no such element.

var array =[2,3,5,14,8,5,12,5,94,2,5];

if(checkIfBigger(array)===-1){
	console.log("There is no such element!");
} else {
console.log("The element with index " + checkIfBigger(array));	
}


function checkIfBigger(array){
	for (var i = 1, len = array.length; i < len; i++) {
		if(array[i]>array[i+1] && array[i]>array[i-1]){
			return i;
			break;
		} 	
	};
	return -1;
}




