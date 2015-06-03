var input = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

var strArr = [];
var i;
var stringType = "normal";
for(i = 0; i < input.length; i++)
{
	if(input.substr(i, 8) == "<upcase>"){
		i+=8;
		stringType = "toUpper";	
	}
	else if (input.substr(i, 9) == "<mixcase>"){				
		i+=9;
		stringType = "toMix";
	}
	else if (input.substr(i, 9) == "<lowcase>"){
		i+=9;
		stringType = "toLower";
	}
	else if (input.substr(i, 9) == "</upcase>"){
		i+=9;
		stringType = "normal";
	}
	else if (input.substr(i, 10) == "</mixcase>" || input.substr(i, 10) == "</lowcase>"){
		i+=10;
		stringType = "normal";
	}
	if(stringType == "normal"){
		strArr.push(input.substr(i,1));
	}
	else if(stringType == "toUpper"){
		strArr.push(input.substr(i,1).toUpperCase());
	}
	else if (stringType == "toLower"){
		strArr.push(input.substr(i,1).toLowerCase());
	}
	else if (stringType == "toMix"){
					// random
					if(Math.floor(Math.random()*2) == 0){				
						strArr.push(input.substr(i,1).toUpperCase());
					}
					else{
						strArr.push(input.substr(i,1).toLowerCase());
					}
				}
			}
			console.log(strArr.join(''));