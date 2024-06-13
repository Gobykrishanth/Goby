function myFunction2() {
    document.getElementById("question2").innerHTML = "Paragraph changed."; 
} 

{
    var carName = "Volvo";
    document.getElementById("question3").innerHTML = carName;
}

{
    // Question-4
    alert("Hello World!");
}

{
    let x = 5;
    let y = 10;
    document.getElementById("question8").innerHTML = x+y;
}

{
    // Question -9
    let x = 5;
    let y = 10;
    let z = x +y;
    alert(z)
}

{
    const firstName = "John";
    const lastName = "Doe";
    const age = 35;
    document.getElementById("question10").innerHTML = firstName + lastName + age;
}


{
    // Question - 11
    alert(10*5);
}


{
    // Question -12
    alert(10/2);
}

{
    // Question -14
    alert(15/9);
}

{
    function reverseString(str){
        const reversedString = 
        str.split("").reduce((acc, char) => char + acc, "");
        console.log(reversedString);
    }
    reverseString("Pest");
}

function myFunction19() {
    let a = 1;
    let b = 2;
    document.getElementById("question19").innerHTML = a+b; 
} 


function myFunction20() {
let minutes=prompt("Enter the minutes");
alert(convert(minutes));
function convert(minutes) { 
    return (minutes *60);
}
}

function myFunction21 () {
    let height = prompt ("Enter the Height");
    let base = prompt ("Enter the base");
    let area = height * base * 0.5;
    alert(convert(area));
    function convert(area) {
        return  (area);
    }
}


function myFunction22 () {
    let age = prompt("Enter age in Years");
    alert(convert(age));
    function convert (age) {
        return (age*365);
    }
}


function myFunction23 () {
    let length = prompt ("Enter Length");
    let width = prompt ("Enter Width");
    let perimeter  = length * 2 + width * 2; 
    alert (convert(perimeter));
    function convert (perimeter) {
        return (perimeter);
    }
}

function reverseWords(sentence) {
    let words = sentence.split(" ");
    for (let i = 0; i < words.length; i++) {
        words[i] = words[i].split("").reverse().join("");
    }
    let reversedSentence = words.join(" ");

    return reversedSentence;
}

let inputSentence = "Welcome to this Javascript Program!";
let reversed = reverseWords(inputSentence);
console.log(reversed);


