// Problem 9. Extract e-mails
// Write a function for extracting all email addresses from given text.
// All sub-strings that match the format @… should be recognized as emails.
// Return the emails as array of strings.


var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. \
Fusce viverra, erat nec volutpat convallis, lectus arcu interdum \
justo, in suscipit lacus dolor at ante. Quisque quis lacus arcu.\
Pellentesque Impad1945@superrito.com consectetur elementum sem Broure256@armyspy.com, sed vehicula sapien. Aliquam\
fermentum pellentesque urna at egestas. Morbi eu dui auctor, fermentum ZThaters32@rhyta.com\
nulla nec, posuere lacus. Curabitur nisl sem, semper eu vehicula ut,\
pharetra a nisl. Vestibulum RArly1960@gustr.com bibendum nisl in massa hendrerit, nec pharetra\
dui vehicula.";
var regex = /[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,4}/gi;
var matches = text.match(regex);

for (var i = 0; i < matches.length; i++) {
	console.log(matches[i]);
}
