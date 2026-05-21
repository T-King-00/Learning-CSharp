const numbers={
    x:1,
    y:5,
    sum: function (x,y){
        console.log(this.x+this.y);
    }
}

const arrnumbers={
    x:6000,
    y:5000
}

// numbers.sum.call(arrnumbers);
numbers.sum.call(arrnumbers);

let willCall=numbers.sum.bind(arrnumbers);
willCall();
