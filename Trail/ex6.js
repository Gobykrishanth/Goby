const readlineSync = require('readline-sync');

const products = [];

let optionStr = "";
while (optionStr !== "exit") {

    let menuStr = ".....................\n" +
        "  **** 1 to add products \n" +
        "  **** 2 to Display Products \n" +
        "  **** exit to Exit \n" +
        " Enter your Option :";

    optionStr = readlineSync.question(menuStr);

    switch (optionStr) {
        case "1": addProduct();
            break;

        case "2": displayProduct();
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
