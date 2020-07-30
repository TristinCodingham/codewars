function findEvenIndex(arr) {
    if(arr.length === 1)
        return 0;
    const centerNumMap = arr.map((center, centerIndex) => {
        let sumLeft = 0;
        let sumRight = 0;
        let equalSides = [];
        let arrayDone = false;

        arr.forEach((num, index) => {
            if(centerIndex === index && arr.length === 1)
                equalSides.push(centerIndex);
            else if(centerIndex === index) 
                return;
            else if(centerIndex < index) {
                sumRight += num;
                arrayDone = (index === arr.length - 1) ? true : false;
            }
            else 
                sumLeft += num;

            if(sumLeft === sumRight && arrayDone) 
                equalSides.push(centerIndex);
            else if(sumLeft === sumRight && arr.length - 1 == centerIndex)
                equalSides.push(centerIndex);
        });
        return equalSides;
    });
    const centerNum = centerNumMap.filter(num => (num !== undefined && num.length >= 1));
    if(centerNum[0] === undefined || centerNum[0] === Infinity)
        return -1;
    return Math.min(...centerNum.filter((a) => a.length >= 1));
}

const array = [8];

console.log("Result", findEvenIndex(array));