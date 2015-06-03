// Write a function that counts how many times given
// number appears in given array. Write a test function
// to check if the function is working correctly.

 var number = 5;

var array =[2,3,5,14,8,5,12,5,94,2,5];

function countOcurrences(number,array){
	var count = 0;
	for (var i = 0; i < array.length; i++) {
		if(array[i]===number){
			count++;
		}
	};
	return count;
}

console.log("The number " + number + " has "+
 countOcurrences(number,array) + " occurrences");