const readlineSync = require('readline-sync');

const products = [
    {
        id: 'P01',
        name: 'Apple',
        price: 100
    },
    {
        id: 'P01',
        name: 'Mango',
        price: 50
    },
    {
        id: 'P01',
        name: 'Orange',
        price: 80
    }
];

let optionStr = "";
while (optionStr !== "exit") {

    let menuStr = ".....................\n" +
        "  **** 1 to add products \n" +
        "  **** 2 to Display Products \n" +
        "  **** 3 to search Products \n" +
        "  **** exit to Exit \n" +
        " Enter your Option :";

    optionStr = readlineSync.question(menuStr);

    switch (optionStr) {
        case "1": addProduct();
            break;

        case "2": displayProduct();
            break;
            

            case "3": searchProduct();
            break;
        default: console.log("No Such Operation");
    }
}

function addProduct() {
    let productID = readlineSync.question('Enter product ID :');
    let productName = readlineSync.question('Enter product Name :');
    let productPrice = Number(readlineSync.question('Enter product Price :' ));

    let product = {
        id: productID,
        name: productName,
        price: productPrice
    }

    products.push(product);
}

function displayProduct() {
    for (let i = 0; i < products.length; i++) {
        console.log(`${products[i].id}\t\t${products[i].name}\t\t${products[i].price}`);
    }
    console.log("-------------------------------------------");
}

function searchProduct() {
    let searchProductName = readlineSync.question('Enter product name to search :');

    let status = 0;
    for ( let i = 0; i < products.length; i=i+1) {
        if (products[i].name == searchProductName) {
            status = -1;
            break;
        } else {
            status = 0;
        }
    }

    if (status == 1) {
        console.log("Product Found");
    } else {
        console.log("Product not found");
    }
}
