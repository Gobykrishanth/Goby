// Question 1
function reversesFunction() {
    let num = "32243";
    let x = "";
    for (i = num.length; i >= 0; i--) {
        x += num.charAt(i);
    }
    console.log(x);
}
reversesFunction();


// Question 2
function palindromeFunction() {
    let word = "madam";
    let x = "";
    for (i = word.length; i >= 0; i--) {
        x += word.charAt(i);
    }
    console.log(x);

    if (x == word) {
        console.log(`${word} is a palindrome `);
    } else {
        console.log(`${word} is not a palindrome`);
    }
}
palindromeFunction();

// Question 3
function uppercaseFunction() {
    let str1 = 'the quick brown fox'
    let str2 = str1.split(" ");
    for (i = 0; i < str2.length; i++) {
        str2[i] = str2[i].charAt(0).toUpperCase() + str2[i].slice(1);
    }
    console.log(str2.join(" "));
}
uppercaseFunction();


// Question 4

function longestWordFunction() {
    let word = 'Web Development Tutorial';
    let word1 = word.split(" ")
    let biggestWord = word1[0];
    for (i = 0; i < word1.length; i++) {
        if (biggestWord.length < word1[i].length) {
            biggestWord = word1[i];
        }
    }
    console.log(biggestWord);
}
longestWordFunction()


// Question 5
function numFunction() {
    let numbers = [1, 2, 3, 4, 5];
    numbers.sort((a,b)=> (a-b))
    console.log(`${numbers[1]},${numbers[numbers.length-2]}`);
}
numFunction()


// Question 6
function nuccaranceFunction() {

}

function countLetters(str) {
    // Create an empty object to store the counts
    const counts = {};
  
    // Loop through each character in the string
    for (let char of str) {
      // If the character is already a key in the counts object, increment its count
      // Otherwise, initialize its count to 1
      counts[char] = (counts[char] || 0) + 1;
    }
  
    // Return the counts object
    return counts;
  }
  
  // Example usage
  const str = "hello";
  const letterCounts = countLetters(str);
  console.log(letterCounts);
  


//   Question 7
function checkInteger() {
if(Number.isInteger) {
    throw new Error ()
}
}
checkInteger();


// function checkInteger(number) {
//     if (!Number.isInteger(number)) {
//         throw new Error('The number must be an integer.');
//     }
// }

// // Example usage:
// try {
//     checkInteger(5); // This will not throw an error
//     checkInteger(5.5); // This will throw an error
// } catch (error) {
//     console.error(error.message);
// }
