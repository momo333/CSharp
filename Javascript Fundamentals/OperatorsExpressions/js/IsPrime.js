//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.


var isPrime = true;
for (var i = 2; i <= 100; i++) {
	for (var j = 2; j <= 100; j++) {
		if (i != j && i % j == 0) {
			isPrime = false;
			break;
		}
	}
	if (isPrime) {
		console.log("Prime: " + i);
	}
	isPrime = true;
}
