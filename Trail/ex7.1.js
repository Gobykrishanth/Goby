const readlineSync = require('readline-sync');

const products = [
    {
        id: 'P01',
        name: 'Apple',
        price: 100
    },
    {
        id: 'P02',
        name: 'Mango',
        price: 50
    },
    {
        id: 'P03',
        name: 'Orange',
        price: 80
    }
];

let optionStr = "";
console.clear();
while (optionStr !== "exit") {

    let menuStr = ".....................\n" +
        "  **** 1 to add products \n" +
        "  **** 2 to Display Products \n" +
        "  **** 3 to search Products \n" +
        "  **** exit to Exit \n" +
        " Enter your Option :";

    optionStr = readlineSync.question(menuStr);

    switch (optionStr) {
        case "1":
            addProduct();
            break;

        case "2":
            displayProduct();
            break;

        case "3":
            searchProduct();
            break;

        case "exit":
            console.log("Exiting...");
            break;

        default:
            console.log("No Such Operation");
    }
}

function addProduct() {
    let productID = readlineSync.question('Enter product ID :');
    let productName = readlineSync.question('Enter product Name :');
    let productPrice = Number(readlineSync.question('Enter product Price :'));

    if (isNaN(productPrice)) {
        console.log("Invalid price. Please enter a valid number.");
        return;
    }

    let product = {
        id: productID,
        name: productName,
        price: productPrice
    };

    products.push(product);
    console.log("Product added successfully.");
}

function displayProduct() {
    console.log("===================================================");
    console.log("product ID\tproduct Name\tproduct Price");
    console.log("===================================================");
    for (let i = 0; i < products.length; i++) {
        console.log(`${products[i].id}\t\t${products[i].name}\t\t${products[i].price}`);
    }
    console.log("===================================================");
}

function searchProduct() {
    let searchProductName = readlineSync.question('Enter product name to search :');

    let foundIndex = -1;
    for (let i = 0; i < products.length; i++) {
        if (products[i].name === searchProductName) {
            foundIndex = i;
            break;
        }
    }

    if (foundIndex !== -1) {
        console.log(`Product found at index ${foundIndex}:`);
        console.log(`${products[foundIndex].id}\t\t${products[foundIndex].name}\t\t${products[foundIndex].price}`);
    } else {
        console.log("Product not found");
    }
}
