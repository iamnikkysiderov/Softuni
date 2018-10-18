function solve(arr) {
    let firstNum = arr[0];
    let secondNum = arr[1];

    if (secondNum >= firstNum) {
        console.log(firstNum * secondNum);
    } else {
        console.log(firstNum / secondNum);
    }
}

solve([5, 6]);