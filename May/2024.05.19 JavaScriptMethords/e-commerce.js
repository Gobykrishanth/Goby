

let products = [];

function generateProductId() {
    return Math.ceil(Math.random() * 100)
}

function generateProductName() {
    const name = ["Smartphone","Laptops","Headphones","Television",
    "I-pad","Mouse","KeyBoard","Speakesrs","CPU"]
    return name [Math.floor(Math.random() * name.length)]
}

function generateProductPrice() {
    return (Math.random()* 1000).toFixed(2);
}

function generateProductQuantity() {
    return Math.ceil(Math.random() * 8)
}


for (let i = 0; i < 10; i++) {
    let product = {
      id: generateProductId(),
      name: generateProductName(),
      price: generateProductPrice(),
      quantity: generateProductQuantity()
    };
    products.push(product);
  }

  
  function searchProductsByName(products, name) {
    let searchResults = products.filter(product => product.name.toLowerCase().includes(name.toLowerCase()));
    console.log(searchResults);
}

let searchTerm = prompt("Enter product name to search:");
searchProductsByName(products, searchTerm);

function generateDiscount(products) {
    return products.map(product => {
        let discount = product.price * 0.1;
        let finalPrice = product.price - discount;
        return {...product, finalPrice: parseFloat(finalPrice.toFixed(2))};
    });
}

products = generateDiscount(products);
console.log("Products with Discount:", products.sort((a, b) => parseFloat(a.finalPrice) - parseFloat(b.finalPrice)));



let updatedProducts = products.filter(product => product.quantity !== 0);
console.log(updatedProducts);

function updateProducts(products) {
    for (let i = 0; i < products.length; i++) {
        if (products[i].quantity === 0) {
            products.splice(i, 1);
            i; 
        }
    }
    return products;
}
updatedProducts = updateProducts(products);
console.log("Updated Products:", updatedProducts);