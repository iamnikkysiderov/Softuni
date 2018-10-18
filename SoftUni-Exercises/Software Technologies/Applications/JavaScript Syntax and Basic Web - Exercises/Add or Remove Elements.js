function solve(arr) {
    let mainArr = [];

    for (let i = 0; i < arr.length; i++) {
        let currentElement = arr[i];
        let arrOfCurrentElement = currentElement.split(' ');

        let command = arrOfCurrentElement[0];
        let value = arrOfCurrentElement[1];

        if (command === 'add') {
            mainArr.push(value);
        } else if (command === 'remove') {
            mainArr.splice(value, 1);
        }
    }

    for (let i = 0; i < mainArr.length; i++) {
        console.log(mainArr[i]);
    }
}

solve(['add 3', 'add 5', 'remove 2', 'remove 0', 'add 7']);