// Problem 6. Extract text from HTML

// Write a function that extracts the content of a html page given as text.
// The function should return anything that is in a tag, without the tags.

var text = '<html> <head> <title>Sample site</title></head><body> <div>text <div>more text</div>and more...</div>in body</body></html> ';

function extractHTML(text) {
    for (var j = 0; j < text.length; j++) {
        var indexStart = text.indexOf('<');
        var indexEnd = text.indexOf('>');
        text = (text.replace(text.substring(indexStart, indexEnd + 1), ''));
    }
    return text;
}

var result = extractHTML(text);
console.log(result);