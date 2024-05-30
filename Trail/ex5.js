const readlineSync = require('readline-sync');

const products = [
    {
        id: 'P01',
        name: 'Apple',
        price: 100
    }
];

function addProduct() {
    let productID = readlineSync.question('Enter product ID :');
    let productName = readlineSync.question('Enter product Name :');
    let productPrice = Number(readlineSync.question('Enter product Price :'));


    let product = {
        id: productID,
        name: productName,
        price: productPrice
    }

    products.push(product)
}

function displayProduct() {
    for (let i = 0; i < products.length; i = i + 1) {
        console.log(`${products[i].id}\t\t${products[i].name}\t\t${products[i].price}`);
    }
    console.log("-------------------------------------------")
}

displayProduct();