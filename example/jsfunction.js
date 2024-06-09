// Question 01
function Q1() {
    let num = "32243";
    let x = "";
    for (let i = num.length; i >= 0; i = i - 1) {
        x = x + num.charAt(i);
    }
    console.log(x);
}
Q1();

// Question 02
function Q2() {
    let word = "madam";
    let x = "";
    for (let i = word.length; i >= 0; i = i - 1) {
        x = x + word.charAt(i);
    }
    if (word === x) {
        console.log("It's a Palindrom");
    }
    else {
        console.log("It's not aPalindrom");
    }
}
Q2();

// Question 03
function Q3() {
    let word = "the quick brown fox";
    word = word.split(" ");
    for (let i = 0; i < word.length; i = i + 1) {
        word[i] = word[i].charAt(0).toUpperCase() + word[i].slice(1);
    }
    console.log(word.join(" "));
}
Q3()

// Question 04
function Q4() {
    let word = "Web Development Tutorial";
    word = word.split(" ");
    let longSentence = word[0];
    for (let i = 0; i < word.length; i = i + 1) {
        if (longSentence.length < word[i].length) {
            longSentence = word[i];
        }
    }
    console.log(longSentence);
}
Q4();


// Question 5
function Q5() {
    let numbers = [1, 2, 3, 4, 5];
    numbers = numbers.sort(function (a, b) {
        return (a - b)
    });
    console.log(numbers[1] + "," + numbers[numbers.length - 2]);
}
Q5();

// Question 6
function Q6(str) {
    const letterCount = {};
    for (let char of str) {
        char = char.toLowerCase();
        if (/[a-z]/.test(char)) {
            letterCount[char] = letterCount[char] ? letterCount[char] + 1 : 1;
        }
    }
    return letterCount;
}
let str = "Hello World!";
const result = Q6(str);
console.log(result);


// Question 7
function Q7(num) {
    if (!Number.isInteger(num)) {
        throw new Error('The provided value is not an integer');
    }
    return num;
}
try {
    console.log(Q7(314));
    console.log(Q7(3.14));
} catch (e) {
    console.error(e.message);
}


// Question 8 
let num = 1;
try {
    num.toUpperCase();
} catch (e) {
    console.log(e.name);
}



// Question 9
function Q9(num1, num2) {
    if (num2 === 0) {
        throw new Error('Division by zero is not allowed');
    }
    return num1 / num2;
}

try {
    let result = Q9(10, 0);
    console.log(result);
} catch (e) {
    console.log(e.message);
}


// Question 10
function Q10(num) {
    if (num < 0) {
        throw new Error('Negative numbers not allowed');
    }
    return num;
}

try {
    let result = Q10(10);
    console.log(result);
    console.log(Q10(-10));
} catch (e) {
    console.log(e.message);
}


// Question 11
function Q11(arr) {
    if (arr.length === 0) {
        throw new Error("Array is Empty");
    }
    return arr;
}

try {
    console.log(Q11(["car", "bus"]));
    console.log(Q11([]));
} catch (e) {
    console.log(e.message);
}

// Question 12
function Q12(inputString) {
    if (inputString === "") {
        throw new Error("String cannot be empty")
    }
    return inputString;
}
try {
    console.log(Q12("Hi"));
    console.log(Q12(""));
} catch (e) {
    console.log(e.message);
}

// Question 13
let x = 1;
try {
    x.toPrecision(200)
}
catch (e) {
    console.log(e.name);
}

// Question 14
function Q14() {
    let y = 1;
    try {
        y.toUpperCase();
    }
    catch (e) {
        console.log(e.name);
    }
}
Q14();

// Question 15
function Q15() {
    try {
        decodeURI("###")
    } catch (e) {
        console.log(e.name);
    }
}
Q15();

// Question 16

function Q16(num) {
    if (num === 0) {
        throw new Error("Can't divided by 0")
    }
    return 10 / num;
}

try {
    console.log(Q16(0));
} catch (e) {
    console.log(e.message);
} finally {
    console.log("Cleanup code executed.");
}

// Question 17
try {
    eval("alert('Hello)");
}
catch (e) {
    console.log(e.name);
}

// Question 18
let value = 5;
try {
    value = y + 1;
}
catch (e) {
    console.log(e.name);
}

// Question 19

let jsonString = "{'name': 'Jhon', 'age': '30'";
try {
    let parseData = JSON.parse(jsonString);
    console.log("Parsed Data :", parseData);
} catch (e) {
    if (e instanceof SyntaxError) {
        console.error(e.name);
    } else {
        console.error(e.name);
    }
}