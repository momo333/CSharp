// Write an expression that checks if given integer is odd or even.


 // var a = prompt('Enter number a: ');
 // var b = prompt('Enter number b: ');

var a=1;
var b=2;

if(isEven(a)==true){
  console.log('The number ' + a +' is even!');
}else{
   console.log('The number ' + a +' is odd!');
}

if((isEven(b)===true)){
console.log('The number ' + b +' is even!');
}else{
   console.log('The number ' + b +' is odd!');
}

function isEven(number){
   return !(number % 2);
}