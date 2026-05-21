// var variables can be hoisted.
x=10;

console.log(x);
var x;

//let and const cant be hoisted -> throws reference error. 
/*var1=10;

console.log(var1);
let var1;*/
//error ->gives a syntax error,
/*carName="volvo";
const carName;*/

//JavaScript Initializations are Not Hoisted-> gives undefined
var x1=10;
console.log(x1,x3);
var x3=50;

//doesnt corresspond to 
var x1=10;
var x2=20;
console.log(x1,x2);
