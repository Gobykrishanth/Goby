const readlineSync = require('readline-sync');

const products = [
    {
        id: 'P01',
        name: 'Apple',
        price: 100
    }
];

let productID = readlineSync.question('Enter product ID :');
let productName = readlineSync.question('Enter product Name :');
let productPrice = Number(readlineSync.question('Enter product Price :'));


let product = {
    id:productID,
    name:productName,
    price:productPrice
}

products.push(product)

console.log(products);