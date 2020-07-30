function persistence(num) {
    if(num <= 9) // Check if num is single digit
        return 0;
    let numsMultiply; // Carry over num
    let count = 0; // Persistence count
    const factorial = (num) => {
        const splitNum = JSON.stringify(num).split("");
        splitNum.forEach((num, index) => {
            if(index === 0) // Start
                return numsMultiply = num;
            numsMultiply *= num; // Continue
        });
        count++; // Increase number of times factorial was called

        if(numsMultiply >= 10) // Need to loop again
            return factorial(numsMultiply);
        return numsMultiply; // Done
    }
    let persistenceNum = factorial(num);
    if(persistenceNum <= 9)
        return count; // Return persistant count
    
    
}
console.log(persistence(999)) === 4;

