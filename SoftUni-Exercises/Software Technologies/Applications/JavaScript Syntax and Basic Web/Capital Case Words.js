function solve(str) {
    let arr = str.toString().split(/\W+/);

    arr = arr.filter(function(x){
        return (x !== (undefined || null || ''));
    });

    let outputArr = [];
    let capitalCase = false;

    for (let i = 0; i < arr.length; i++) {
        let word = arr[i];

        for (let j = 0; j < word.length; j++) {
            if (word[j] >= 'A' && word[j] <= 'Z') {
                capitalCase = true;
            } else {
                capitalCase = false;

                break;
            }
        }

        if (capitalCase) {
            outputArr.push(word);
        }
    }

    console.log(outputArr.join(', '));
}

solve('We start by Javascript, JSON, JAVA and Rest');