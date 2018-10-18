function solve(arr) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] != 'Stop') {
            console.log(arr[i]);
        } else {
            break;
        }
    }
}

solve(['sadsa', 'string', 'Stop', 'test']);