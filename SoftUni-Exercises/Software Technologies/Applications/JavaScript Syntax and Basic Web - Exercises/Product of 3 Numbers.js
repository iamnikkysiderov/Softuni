function solve(arr) {
    let countOfNegatives = 0;

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] < 0) {
            countOfNegatives++;
        }
    }

    if (countOfNegatives % 2 == 0) {
        console.log('Positive');
    } else {
        console.log('Negative');
    }
}

solve([3, 4, -1]);