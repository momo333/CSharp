// Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
// Example:
// The target sub-string is in
// The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

function countOcurrences(str, value){
   var regExp = new RegExp(value, "gi");
   return str.match(regExp) ? str.match(regExp).length : 0;  
}

var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
var str = "in";

console.log("Number ocurrencies of substring: " + countOcurrences(text,str) + " times.");