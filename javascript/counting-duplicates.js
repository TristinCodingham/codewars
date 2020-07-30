let text = "Indivisibility";

text = text.split("");
let lastDupe = "";

const dupesMap = text.map((char, charIndex) => {
    let dupes;
    text.forEach((check, checkIndex) => {
        if(charIndex === checkIndex)
            return;
        else if(lastDupe.toLowerCase().includes(char.toLowerCase())) {
            lastDupe += char.toLowerCase();
            return;
        }
        else if(char.toLowerCase() === check.toLowerCase()) {
            lastDupe += char.toLowerCase();
            return dupes = char.toLowerCase();
        }
    })
    return dupes;
}).filter(char => char !== undefined);

console.log(dupesMap);




// let text = "Indivisibility";
// text = text.split("");
// let lastDupesArr = [];
// let arrIndex = 0;
// let count = 0;
// let deleteCount = 0;

// const dupesMap = (char, charIndex) => {
//     let dupes;
//     text.forEach((check, checkIndex) => {
//         if(charIndex === checkIndex)
//             return;
//         else if(lastDupesArr.length >= 1 && lastDupesArr[arrIndex] === char.toLowerCase()) {
//             arrIndex++;
//             return;
//         }
//         else if(char.toLowerCase() === check.toLowerCase()) {
//             return dupes = char.toLowerCase();
//         }
//     })
//     if(dupes !== undefined)
//         lastDupesArr.push(dupes);
//     return dupes;
// };
// const res = text.map(dupesMap).filter(char => (char !== undefined));
// lastDupesArr.forEach((char, charIndex) => {
//     lastDupesArr.forEach((check, checkIndex) => {
//         if(charIndex == checkIndex)
//             return;
//         else if(char == check)
//             return lastDupesArr.splice(0, 1);
//     })
// })
// console.log(lastDupesArr);
