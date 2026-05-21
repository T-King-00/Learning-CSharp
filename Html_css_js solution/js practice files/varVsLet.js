//var and let redeclariton in same block
{
    //cant re declare let var1;
    /* let var1=10;
     let var1=20;
     console.log(var1,var2);*/

    //can re declare var var1 in same scope;
    var var1=1;
    var var1=2;
    console.log(var1);
}

//let variables can be redeclared , but var cant
/*Re declaring let variable inside block doesnt change the let  variable outside.*/
let z=1;
{
    let z=10;
    console.log(z);
}
console.log(z);
    
//while redeclation var changes it's value outside the block and rest of the code.    
var zz=1;
{
    var zz=10;
    console.log(zz);
}
console.log(zz);
var name="tony";
printName();
function printName(){
    console.log(name);

}   
