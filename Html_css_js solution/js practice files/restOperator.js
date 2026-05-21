const user={name:"tony",age:"25" , city:"kalmar"}

const {name,...rest}=user

console.log(name+rest.age);