//### Problem 10. Find palindromes
//*	Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var input = 'abba madam kjjjkh woler `wow sos peace ';
var arrayOfStrings = input.replace(/^[\s,.!?+(-)]+|[\s,.!?+(-)]+$/g, "").split(/[\s,.!?+(-)]+/);
var i;
for (i = 0; i < arrayOfStrings.length; i++)
{
	str = arrayOfStrings[i];
	var IsPalindrom = false;
	var j;
	for (j = 0; j < str.length / 2; j++)
	{
		if (str[j] == str[str.length - 1 - j])
		{
			IsPalindrom = true;
		}
		else
		{
			IsPalindrom = false;
			break;
		}
	}
	if (IsPalindrom == true && str.length > 1)
	{
		console.log(str);
	}
}