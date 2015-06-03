// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

// var number = console.prompt("Enter number");

var number = 50;

for (var i = 1; i <= number; i++) {
	if(i%21!=0){
		console.log(i);
	}
};