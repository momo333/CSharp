// Problem 2. Correct brackets

// Write a JavaScript function to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).


function checkBrackets(string){
	var depth = 0;
	for (var i in string) {
		if(string[i]==='(') {
			depth++;
		} else if(string[i===')']) {
			depth--;
		} 
		if(depth<0){
			return false;
		} else if(depth>0) {
			return false;
		} else if(depth===0) {
			return true;
		}
	}
}

var exp = '( ( a + b ) / 5 – d )';
var exp2 = '( ( ) a + b ) / 5 – d )';

function print(str) {
	if(checkBrackets(str)) {
		console.log('The brackets in the expression are put correctly');
	} else {
		console.log('The brackets in the expression are not put correctly');
	}
}

print(exp);
print(exp2);
