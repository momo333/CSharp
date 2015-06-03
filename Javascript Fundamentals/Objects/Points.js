// Problem 1. Planar coordinates

// Write functions for working with shapes in standard Planar coordinate system.
// Points are represented by coordinates P(X, Y)
// Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// Calculate the distance between two points.
// Check if three segment lines can form a triangle.


function createPoint(x,y){
	return{
		x:x,
		y:y
	};
}

function createLine(pointOne, pointTwo){
	return{
		pointOne:pointOne,
		pointTwo: pointTwo,
		lineDetails: function(){
			return 'Line point One(' + pointOne.x + ','  + pointOne.y+ ')' + '\n' +
			'Line point Two(' + pointTwo.x + ',' + pointTwo.y + ')';
		} 
	};
}

function getDistancePoints(x1,y1,x2,y2) {
	return Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

var point1 = createPoint(2,2);
var point2 = createPoint(3,3);

console.log('The distance between point1 and point2 is: ' + getDistancePoints(point1.x, point1.y, point2.x, point2.y));

function formTriangle(lineA, lineB, lineC) {
	var a = getDistancePoints(lineA.pointA, lineA.pointB);
	var b = getDistancePoints(lineB.pointA, lineB.pointB);
	var c = getDistancePoints(lineC.pointA, lineC.pointB);
	if ((a + b > c) && (a + c > b) && (c + b > a)) {
		return true;
	} else {
		return false;
	}
}

var lineOne = createLine(createPoint(2,3),createPoint(3,4));
var lineTwo = createLine(createPoint(3,4), createPoint(5,5));
var lineThree = createLine(createLine(6,6),createLine(7,7));

if(formTriangle(lineOne, lineTwo, lineThree)){
	console.log('The lines can form triangle.')
} else {
	'The lines cannot for triangle.';
}