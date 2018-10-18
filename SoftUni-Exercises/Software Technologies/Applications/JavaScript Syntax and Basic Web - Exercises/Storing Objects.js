function solve(arr) {
    let peopleGrades = [];

    for (let i = 0; i < arr.length; i++) {
        let currentElement = arr[i];
        let arrOfCurrentElement = currentElement.split(' -> ');

        let nameOfCurrentPerson = arrOfCurrentElement[0];
        let ageOfCurrentPerson = arrOfCurrentElement[1];
        let gradeOfCurrentPerson = arrOfCurrentElement[2];

        console.log(`Name: ${nameOfCurrentPerson}`);
        console.log(`Age: ${ageOfCurrentPerson}`);
        console.log(`Grade: ${gradeOfCurrentPerson}`);
    }
}

solve(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90']);