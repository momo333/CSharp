// 3. Write a script that finds the maximal sequence of
// equal elements in an array.

var myArray = [];
var arrayMax = 20;

var arrayNums = "";
for (var i = 0; i < arrayMax; i++) {
  myArray.push(Math.floor(Math.random()*10));
  arrayNums +=myArray[i];
  arrayNums +=" ";
}

console.log(arrayNums);
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

var seqMaxElem = "";
seqMaxElem+=element;
for (var i = 1; i < maxLength; i++) {
	seqMaxElem+=", ";
	seqMaxElem+=element;
};
console.log();
console.log("The max sequence of equal elements: ");
console.log(seqMaxElem)
