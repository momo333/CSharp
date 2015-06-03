// Write a script that converts a str in the range [0…999] to words, corresponding to its English pronunciation.

// var str = console.prompt("Enter str");
var number=235;
var str =number.toString();

var ones = ["", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];
var tens = ["", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];
var specialDigits = ["Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];
var result="";
switch (str.length) {
                case 1: // 1-9
                if (str[0] === 0) {
                	result="Zero";
                }
                else {
                	result=ones[str[0]];
                }
                break;
                case 2: // 10 - 99
                if (str[0] === 1) {
                	result=specialDigits[str[1]];
                }
                else {
                	result=tens[str[0]] + " " + ones[str[1]];
                }
                break;
	            case 3: // 100 - 999
	            if (str[1] === 1) {
	            	result=ones[str[0] + " hundred and " + specialDigits[str[2]]];
	            }
	            else {
	            	if (str[1] != 0 || str[2] != 0) {
	            		result=ones[str[0]] + " hundred and " + tens[str[1]] + " " + ones[str[2]];
	            	}
	            	else {
	            		result=ones[str[0]] + " hundred " + tens[str[1]] + " " + ones[str[2]];
	            	}
	            }
	            break;
	            default:
	            break;
	        }
	        console.log(result);
