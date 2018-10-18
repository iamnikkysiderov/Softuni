function solve(arr) {
    let arrAsObj = arr.map(JSON.parse);
    let output = {};

    for (let element of arrAsObj) {
        let town = element['town'];
        let income = Number(element['income']);

        if (output.hasOwnProperty(town)) {
            output[town] += income;
        } else {
            output[town] = income;
        }
    }

    let sortedArr = Object.keys(output).sort();

    for (let town of sortedArr) {
        console.log(`${town} -> ${output[town]}`);
    }
}

solve(['{"town":"Sofia", "income":200}',
    '{"town":"Varna", "income":120}',
    '{"town":"Pleven", "income":60}',
    '{"town":"Varna", "income":70}']);