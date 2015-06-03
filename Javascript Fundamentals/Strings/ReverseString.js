// Write a JavaScript function that reverses a string and returns it.

function reverse(str) {
  var rev = '';
  for (var i = str.length - 1; i >= 0; i--)
    rev += str[i];
  return rev;
}

var word = "reverseword";
console.log(word);
console.log("The reverse word is: " + reverse(word));