function solve(number) {
    let arr = [];

    for (let i = 1; i <= Number(number); i++) {
        isSymmetric(i.toString());
    }

    function isSymmetric(numberToCheck) {
        let reversed = reverseString(numberToCheck);

        if (reversed === numberToCheck) {
            arr.push(numberToCheck);
        }
    }

    function reverseString(input) {
        let reversedString = input.toString().split('').reverse().join('');

        return reversedString.toString();
    }

    console.log(arr.join(' '));
}

solve(750);