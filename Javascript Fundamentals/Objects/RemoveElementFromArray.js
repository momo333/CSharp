// Write a function that removes all elements with a
// given value
//  Attach it to the array type
//  Read about prototype and how to attach methods


var array =  [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

function remove(arr, item) {
      for(var i = arr.length; i--;) {
          if(arr[i] === item) {
              arr.splice(i, 1);
          }
      }
  }

  console.log(array);
  remove(array,4);
  console.log(array);