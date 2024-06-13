const fruits = ["Apple", "Avocado", "Dates", "Grape", "Jackfruit"];
const Vegetables = ["Broccoli ", "Carrot ", "Leek", "Bean"];

// Question 2
console.log (fruits.toString());
console.log (Vegetables.toString());

// Question 3
console.log (fruits[2]);
console.log (Vegetables.at(0));

// Question 4
console.log (fruits.join("-"));
console.log (Vegetables.join("_"));

// Question 5
console.log (fruits.pop());
console.log (fruits);
console.log (Vegetables.pop());
console.log (Vegetables);

// Question 6
console.log  (fruits.push("Mango"));
console.log (fruits);
console.log  (Vegetables.push("ladies finger"));
console.log (Vegetables);

// Question 7
console.log (fruits.splice(2,1));
console.log (Vegetables.splice(2,2));

// Question 8
const merge = fruits.concat(Vegetables);
console.log(merge);

// Question 9
console.log (fruits.slice(1,3));


// Question 10
console.log (merge.sort());
console.log (merge);

// Question 11
const merge2 = merge.reverse();
console.log(merge2);

// Question 12
console.log(fruits.indexOf("Grape"));
console.log(Vegetables.indexOf("3"));

// Question 13
console.log(fruits.includes(0));
console.log(Vegetables.includes(6));


// Array Methord
function addFunction() {
    var newName = document.getElementById("addText").value;
    fruits.push(newName);
    var retu = fruits.toString();
    document.getElementById("res").innerHTML = retu;
    console.log(retu);
}

function removeFunction() {
    var newName = document.getElementById("removeText").value;
    var x = fruits.indexOf(newName);
    // console.log(x);
    fruits.splice(x,1);
    var retu = fruits.toString();
    document.getElementById("res").innerHTML = retu;
    console.log(retu);
}


function sortFunction() {
    var 
}