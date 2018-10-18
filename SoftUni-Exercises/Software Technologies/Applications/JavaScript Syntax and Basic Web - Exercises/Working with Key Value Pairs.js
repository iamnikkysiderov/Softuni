function solve(arr) {
    let outputArr = [];
    let targetKey = arr[arr.length-1];

    for (let i = 0; i < arr.length-1; i++) {
        let currentElement = arr[i];
        let arrOfCurrentElement = currentElement.split(' ');

        outputArr[arrOfCurrentElement[0]] = arrOfCurrentElement[1];
    }

    if (outputArr.hasOwnProperty(targetKey)) {
        console.log(outputArr[targetKey]);
    } else {
        console.log('None')
    }
}

solve(['key value', 'key eulav', 'test tset', 'key']);