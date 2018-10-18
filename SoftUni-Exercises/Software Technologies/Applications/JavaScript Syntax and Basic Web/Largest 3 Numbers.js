function solve(arr) {
    let sortedArrDescending = arr.sort(function (a, b) {
        return b - a;
    });

    for (let i = 0; i < sortedArrDescending.length; i++) {
        if (i <= 2) {
            console.log(sortedArrDescending[i]);
        } else {
            break;
        }
    }
}

solve([10, 30, 15, 20, 50, 5]);