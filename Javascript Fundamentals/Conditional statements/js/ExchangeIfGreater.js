//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.

var a =2, b = 1;

if(a > b){
    exchangeVariables(a,b);
}


function exchangeVariables(a,b){
	var ex = a;
	a = b;
	b = ex;
printNumbers(a,b);	
}

function printNumbers(a, b){
    console.log(a + ' ' + b);
}

