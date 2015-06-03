// Write a function that returns the last digit of given
// integer as an English word. Examples: 512  "two",
// 1024  "four", 12309  "nine"


var number = Math.floor(Math.random()*1000);
console.log("The number is " + number);
console.log("The last digit is " + transformLastDigitAsWord(number));

function transformLastDigitAsWord(number){
    switch (number % 10){
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
    }
}