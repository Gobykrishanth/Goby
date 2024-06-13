
// Question 01
// let votingAge = 18; 
// if (votingAge < 24) {
//     console.log("You are eligible to vote");
// }



// Question 02
// const number = prompt("Enter a number: ")
// if (number % 2 == 0) {
//     console.log("The number is even");
// }
// else {
//     console.log("The number is odd");
// }


// Question 03
// const number1 = prompt("Enter number 1: ")
// const number2 = prompt("Enter number 2: ")
// if (number1 > number2) {
//     console.log("{num1} is large than {num2");
// }
// else {
//     console.log("{num2} is large than {num1");
// }



// Question 04
// function isLeapYear(year) {
//     return (year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0);
// }

// const year = 2024;

// if (isLeapYear(year)) {
//     console.log(`${year} is a leap year`);
// } else {
//     console.log(`${year} is not a leap year`);
// }


// Question 05
// let alphabet  = 'a';

// switch (alphabet) {
//     case 'a':
//     case 'e':
//     case 'i':
//     case 'o':
//     case 'u':
//     case 'A':
//     case 'E':
//     case 'I':
//     case 'O':
//     case 'U':
//         console.log(alphabet + " is vowel");
//         break;
//         console.log(alphabet + " is consonant");
// }

// Question 06

// let sum = 0;

// for (let i = 1; i <= 10; i++) {
//     sum += i;
// }
// console.log(`The first 10 numbers' sum is ${sum}.`);



// Question 07

// function printShape(size) {
//     let middle = Math.ceil(size / 2);
//     let spaces = middle - 1;
//     let stars = 1;
    
//     for (let i = 1; i <= middle; i++) {
//         console.log(" ".repeat(spaces) + "*".repeat(stars));
//         spaces--;
//         stars += 2;
//     }
    
//     spaces = 1;
//     stars = size - 2;
//     for (let i = middle + 1; i <= size; i++) {
//         console.log(" ".repeat(spaces) + "*".repeat(stars));
//         spaces++;
//         stars -= 2;
//     }
// }

// printShape(7);


// Question 08


// function printShape() {
//     let height = 5; 
//     let width = height * 2 - 1; 
//     let row = 1;

//     while (row <= height) {
//         let spaces = height - row;
//         let stars = (row === height) ? width : (row * 2 - 1);
//         let line = '';

//         for (let i = 0; i < spaces; i++) {
//             line += ' ';
//         }

//         for (let i = 0; i < stars; i++) {
//             if (i === 0 || i === stars - 1 || row === height) {
//                 line += '*';
//             } else {
//                 line += ' ';
//             }
//         }

//         console.log(line);
//         row++;
//     }
// }
// printShape();