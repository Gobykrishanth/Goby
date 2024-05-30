const readlineSync = require('readline-sync');

const products = [];


let str = "";

while (str != "no") {
let productID = readlineSync.question('Enter product ID :');
let productName = readlineSync.question('Enter product Name :');
let productPrice = Number(readlineSync.question('Enter product Price :'));


let product = {
    id:productID,
    name:productName,
    price:productPrice
}

products.push(product)

str = readlineSync.question("Do you want to continue yes/no")

}

console.log(products);