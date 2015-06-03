// Write a function that finds all the occurrences of
// word in a text
//  The search can case sensitive or case insensitive

word = 'dog';
text = 'The domestic dog is a usually furry canid. The global dog population is estimated to between 700 million to over one billion, making the dog the most abundant member of order Carnivora.'
var count = countWordInText(word,text);

function countWordInText(word,text){
 var results=0;
 var a=text.indexOf(word)

 while(a!=-1){
   text=text.slice(a*1+word.length);
   results++;
   a=text.indexOf(word);
 }
return results;
}

console.log('The word ' + word + ' occurrences: ' + count);