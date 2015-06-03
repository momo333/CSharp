// Write a function that groups an array of people by age, first or last name.
// The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)

function createPerson(firstname, lastname, age){
	return {
		firstname:firstname,
		lastname:lastname,
		age:age,
	}
}

function groupBy(arr, prop) {
	var groupedArr = [];
 
	for(var i = 0, len = arr.length; i < len; i++){
		if(!groupedArr[arr[i][prop]]) {
			groupedArr[arr[i][prop]] = [];
		}
		groupedArr[arr[i][prop]].push(arr[i]);
	}
	return groupedArr;
}

var people = [
createPerson("John", "Johnson",26),
createPerson("Petar", "Petrov", 25),
createPerson("Ivan", "Ivanov",23),
createPerson("Georgi", "Georgiev",24)
]

var grouped = groupBy(people,'age');
console.log(grouped);

