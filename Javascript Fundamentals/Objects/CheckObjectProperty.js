// Problem 4. Has property
// Write a function that checks if a given object contains a given property.
// var obj  = …;
// var hasProp = hasProperty(obj, 'length');

var car = {
	manifacturer:"Mazda",
	model:'6',
	year: 2010
}

function hasProperty(obj, prop){
	return obj.hasOwnProperty(prop);
}

console.log(hasProperty(car, 'model'));