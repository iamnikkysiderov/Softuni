function solve(numbers) {
    let allElements = numbers[0].split(' ');
    let firstNum = Number(allElements[0]);
    let secondNum = Number(allElements[1]);
    let thirdNum = Number(allElements[2]);

    if (firstNum + secondNum === thirdNum) {
        if (firstNum > secondNum) {
            [firstNum, secondNum] = [secondNum, firstNum]
        }

        console.log(`${firstNum} + ${secondNum} = ${thirdNum}`);
    } else if (firstNum + thirdNum === secondNum) {
        if (firstNum > thirdNum) {
            [firstNum, thirdNum] = [thirdNum, firstNum]
        }

        console.log(`${firstNum} + ${thirdNum} = ${secondNum}`);
    } else if (secondNum + thirdNum === firstNum) {
        if (secondNum > thirdNum) {
            [secondNum, thirdNum] = [thirdNum, secondNum]
        }

        console.log(`${secondNum} + ${thirdNum} = ${firstNum}`);
    } else {
        console.log('No');
    }
}

solve(['8 15 7'])