function alphabetPosition(text) {
    const alphabet = "abcdefghijklmnopqrstuvwxyz".split("");
  
    text = text.split("").filter(letter => letter !== " ").map(letter => {
        let temp = [];
        alphabet.forEach((alpha, index) => {
            if(letter.toLowerCase() === alpha.toLowerCase()) {
                temp.push((index +1));
            }
        });
        return temp;
    }).filter(text => text.length >= 1).join(" ");
    return(text);
  }