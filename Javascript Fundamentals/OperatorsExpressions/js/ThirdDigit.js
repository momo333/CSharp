//Write an expression that checks for given integer if its third digit (right-to-left) is 7.


// var number = prompt('Enter width of the rectangle: ');

var number=4728;

console.log(checkThirdDigit(number));


function checkThirdDigit(number){
    return (Math.floor(number / 100) % 10) === 7;
}



