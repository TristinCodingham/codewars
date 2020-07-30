let numbers = "1 2 3 -4 5";
const splitNums = numbers.split(" ");
console.log(Math.max(...splitNums), Math.min(...splitNums));