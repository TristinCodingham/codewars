const names = [{name: 'Bart'}];
let formatNames = "";
names.forEach((obj, index) => {
    if(names.length === 1)
        formatNames = obj.name;
    else if(index < names.length - 2)
        formatNames += obj.name + ", ";
    else if(index < names.length - 1)
        formatNames += obj.name + " ";
    else
        formatNames += "& " + obj.name;
})
console.log(formatNames);