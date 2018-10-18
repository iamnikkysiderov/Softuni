function solve(arr) {
    let n = Number(arr[0]);
    let outputArr = new Array(n);

    for (let i = 1; i < arr.length; i++) {
        let currentString = arr[i];
        let arrOfCurrentString = currentString.split(' - ');

        outputArr[arrOfCurrentString[0]] = arrOfCurrentString[1];
    }

    for (let i = 0; i < outputArr.length; i++) {
        if (outputArr[i] == null) {
            console.log(0);
        } else {
            console.log(outputArr[i]);
        }
    }
}

solve(['2', '0 - 5', '0 - 6', '0 - 7']);