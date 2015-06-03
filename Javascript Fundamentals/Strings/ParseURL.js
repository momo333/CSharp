// Problem 7. Parse URL
// Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
// Return the elements in a JSON object.
var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

function parseUrl(url) {
	var match = /(.*):\/\/(.*)(\/.*)/.exec(url);
	return {protocol: match[1], server: match[2], resource: match[3]};
}


var resultObject = parseUrl(url);
for (var i in resultObject) {
	console.log(i+': '+ resultObject[i]);
}
