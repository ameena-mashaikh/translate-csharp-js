//Need a function to simulate rolling dice. Math.random() possibly? Two parameters are necessary
//Switch Statements to set the number equal to the string of the number spelled out '
//Need to account for Doubles if both dice rolled are the same value
//Need to add values of the dice and display the equation using strings



const diceTotal = () => {

    let die1 = rolledDice();
    let die2 = rolledDice();

    let ans = ''
    if (die1[0] === die2[0]) {
        ans += `${die1[1]} + ${die2[1]} = ${die1[0] + die2[0]} DOUBLES!!!`
    }
    else {
        ans += `${die1[1]} + ${die2[1]} = ${die1[0] + die2[0]}`
    }

    return ans
}




const rolledDice = () => {

    let value = diceValue(1, 6);
    let valueStr = '';





    switch (value) {
        case 1:
            valueStr += 'one'
            break;
        case 2:
            valueStr += 'two'
            break;
        case 3:
            valueStr += 'three'
            //dice2Str += 'three'
            break;
        case 4:
            valueStr += 'four'
            //dice2Str += 'four'
            break;
        case 5:
            valueStr += 'five'
            //dice2Str += 'five'
            break;
        case 6:
            valueStr += 'six'
            //dice2Str += 'six'
            break;
    }


    return [value, valueStr];
}







const diceValue = (min, max) => {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

for (let i = 0; i <= 10; i++) {
    console.log(diceTotal())
}