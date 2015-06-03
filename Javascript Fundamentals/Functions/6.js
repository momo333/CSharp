// Write a function that checks if the element at given
// position in given array of integers is bigger than its
// two neighbors (when such exist).

var array =[2,3,5,14,8,5,12,5,94,2,5];

var index =5;

function checkIfBigger(array,index){
	if(array[5]>array[6] && array[5]>array[4]){
		return true;
	} else {
		return false;
	}
}

if(checkIfBigger(array, index)){
	console.log("The element with index " + index +
	 " is bigger than it's neighbours");
} else {
	console.log("The element with index " + index +
	 " is not bigger than it's neighbours");
}