function solve(arr) {
    let outputArr = [];
    let targetKey = arr[arr.length-1];

    for (let i = 0; i < arr.length-1; i++) {
        let currentElement = arr[i];
        let arrOfCurrentElement = currentElement.split(' ');

        if (outputArr.hasOwnProperty(arrOfCurrentElement[0])) {
            outputArr[arrOfCurrentElement[0]] += ' ' + arrOfCurrentElement[1];
        } else {
            outputArr[arrOfCurrentElement[0]] = arrOfCurrentElement[1];
        }
    }

    if (outputArr.hasOwnProperty(targetKey)) {
        let outputValueArr = outputArr[targetKey].split(' ');

        for (let i = 0; i < outputValueArr.length; i++) {
            console.log(outputValueArr[i]);
        }
    } else {
        console.log('None');
    }
}

solve(['key value', 'key eulav', 'test tset', 'key']);