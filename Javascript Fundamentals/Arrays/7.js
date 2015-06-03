// Write a program that finds the index of given
// element in a sorted array of integers by using the
// binary search algorithm.

var myArray = [];
var arrayMax = 30;

var arrayNums = "";
for (var i = 0; i < arrayMax; i++) {
	myArray.push(Math.floor(Math.random()*50));
	arrayNums +=myArray[i];
	arrayNums +=" ";
}
var item = myArray[Math.floor(Math.random()*(myArray.length-1))];
console.log(arrayNums);
console.log("The index of " + item +" is: ");

console.log(binarySearch(myArray, item, 0, 30));

function binarySearch(arr, item, min, max){
    if(max < min){
        return -1;
    }
    var mid = min + Math.floor((max - min) / 2);

    if(arr[mid] > item){
        return binarySearch(arr, item, min, mid - 1);
    }
    else if(arr[mid] < item){
        return binarySearch(arr, item, mid + 1, max);
    }
    else{
        return mid;
    }
}
