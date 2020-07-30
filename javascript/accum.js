let string = "RqaEzty";
let mumbling = "";
const adder = (num, index) => {
    let pairs = "";
    for(let i = 0; i < string.length; i++) {
        if(i == 0)
            pairs += num.toUpperCase();
        else
            pairs += num.toLowerCase();
    }
    mumbling += index >= 1 ? "-" + pairs.slice(0, index + 1) : pairs.slice(0, index + 1);
}
string.split("").map(adder);
console.log(mumbling);
