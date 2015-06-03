// Write a function that reverses the digits of given
// decimal number. Example: 256  652

var number = Math.floor(Math.random()*100000);
console.log("The number is " + number);
console.log("The reversed number is: " + reverseNumber(number));

function reverseNumber(number){
	var result = 0;

	if(number<10){
		return number;
	}else{

		while(number){
			result = result * 10 + number % 10;
			number = Math.floor(number / 10);
		}

		return result;
	}
}