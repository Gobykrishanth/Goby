// Question 1
function findLargestInteger(num1, num2) {
    if (num1 > num2) {
        return num1;
    } else {
        return num2;
    }
}

let num1 = 47;
let num2 = 35;
let result = findLargestInteger(num1, num2);
document.getElementById("Q1").innerHTML = (`The largest integer among ${num1} & ${num2} is ${result}`)



// Question 2
function sortFunction() {
    var a = Number(document.getElementById("first").value);
    var b = Number(document.getElementById("second").value);
    var c = Number(document.getElementById("third").value);

    if (a > b && b > c) {
        alert(`${a},${b},${c},`)
    } else if (a > c && c > b) {
        alert(`${a},${c},${b},`)
    } else if (b > a && a > c) {
        alert(`${b},${a},${c},`)
    } else if (b > c && c > a) {
        alert(`${b},${C},${a},`)
    } else if (c > b && b > a) {
        alert(`${c},${b},${a},`)
    } else {
        alert(`${c},${a},${b},`)
    }
}

// Question 3
function isLeapYear(year) {
    return (year % 4 === 0 & year % 100 !== 0) | (year % 400 === 0);
}
const year = prompt("Enter an year");
if (isLeapYear(year)) {
    console.log(`${year} is a leap year`);
} else {
    console.log(`${year} is not a leap year`);
}


// Querstion 4
let i = 1;
let Number = '';
for (i = 12; i <= 24; i = i + 1) {
    Number = Number + i + " "
}
console.log(Number);



// Question 5
const numbersArray = [1, 13, 22, 123, 49];
sum = 0;
for (i = 0; i < numbersArray.length; i++) {
    sum += numbersArray[i];
}
console.log(sum);




// Question 6
for (j = 0; j<=15; j++) {
    if(j%2==0) {
        alert(`${j} is even`);
    } else {
        alert(`${j} is odd`);
    }
}



// Question 7
for (let a=0; a < 5; a++) {
    let numb = "";
    for (let b=0; b <=a; b++) {
        numb = numb + "*"
    }
    console.log(numb);
}



//  Question 8
numw = 0;
for (i = 0; i < 1000; i++) {
    if (i % 3 == 0 & i % 5 == 0) {
        numw = numw + i;
    }
}
console.log(numw);


// Question 9
for (let i = 6; i >= 1; i--) {
    let num = "";

    for (let j = 1; j <= i * 2 - 1; j += 2) {
        num += j + ", ";
    }
    console.log(`Next line is : \" ${num} \"`);
}


// Question 10

const library = [ 
    {
        author: 'Bill Gates',
        title: 'The Road Ahead',
        readingStatus: true
    },
    {
        author: 'Steve Jobs',
        title: 'Walter Isaacson',
        readingStatus: true
    },
    {
        author: 'Suzanne Collins',
        title:  'Mockingjay: The Final Book of The Hunger Games', 
        readingStatus: false
    }];
for (i = 0; i < library.length; i++) {
    const book = library[i];
    console.log(`${book.readingStatus}`);
}

