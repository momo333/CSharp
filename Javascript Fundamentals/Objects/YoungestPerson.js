// Problem 5. Youngest person

// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

function createPerson(firstname, lastname, age){
	return {
		firstname:firstname,
		lastname:lastname,
		age:age,
	}
}


var people = [
createPerson("Ivan", "Ivanov",23),
createPerson("Georgi", "Georgiev",24),
createPerson("Petar", "Petrov", 25),
createPerson("John", "Johnson",26)
]

function findYoungestPerson(people){
	var youngestPerson,
	minAge=Infinity;

	for(var i in people ){
		if(people[i].age<minAge){
			youngestPerson = people[i];
			minAge=people[i].age;
		}
	}
	return youngestPerson;
}

var youngestPerson=findYoungestPerson(people);
console.log("The youngest person is: " + youngestPerson.firstname + " " + youngestPerson.lastname);
