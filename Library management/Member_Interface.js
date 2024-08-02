// Check if the user is logged in
if (sessionStorage.getItem('loggedIn') !== 'true') {
    // Redirect to login page if not logged in
    window.location.href = 'login.html'; // Update this path as needed
}

// Logout function
function logout() {
    sessionStorage.removeItem('loggedIn');
    window.location.href = 'login.html'; // Redirect to login page on logout
}

// Example function to initialize member interface (if needed)
function initMemberInterface() {
    // Initialize member interface here, if needed
}

// Call the initialization function
initMemberInterface();

// Sample books data
const books = [
    { id: 1, title: 'The Great Gatsby', image: 'https://via.placeholder.com/150x200?text=The+Great+Gatsby', borrowedDate: '2024-07-01', returnedDate: '2024-07-15', description: 'A novel written by American author F. Scott Fitzgerald.' },
    { id: 2, title: '1984', image: 'https://via.placeholder.com/150x200?text=1984', borrowedDate: '2024-07-20', returnedDate: '2024-07-25', description: 'A dystopian social science fiction novel by English writer George Orwell.' },
    { id: 3, title: 'To Kill a Mockingbird', image: 'https://via.placeholder.com/150x200?text=To+Kill+a+Mockingbird', borrowedDate: '2024-07-30', returnedDate: '', description: 'A novel by Harper Lee published in 1960.' },
    { id: 4, title: 'Pride and Prejudice', image: 'https://via.placeholder.com/150x200?text=Pride+and+Prejudice', borrowedDate: '2024-08-01', returnedDate: '', description: 'A romantic novel by Jane Austen published in 1813.' }
];

// Function to display books
function displayBooks() {
    const container = document.getElementById('bookContainer');
    container.innerHTML = ''; // Clear any existing content

    books.forEach((book) => {
        const bookCard = document.createElement('div');
        bookCard.className = 'book-card';
        bookCard.innerHTML = `
            <img src="${book.image}" alt="${book.title}">
            <h3>${book.title}</h3>
            <p>${book.description}</p>
        `;
        container.appendChild(bookCard);
    });
}

// Function to show profile edit popup
function showPopup() {
    document.getElementById('profilePopup').classList.add('show');
}

// Function to hide profile edit popup
function hidePopup() {
    document.getElementById('profilePopup').classList.remove('show');
}

// Function to show browsing history popup
function showHistoryPopup() {
    const tableBody = document.getElementById('historyTable').getElementsByTagName('tbody')[0];
    tableBody.innerHTML = ''; // Clear existing rows

    books.forEach((book) => {
        const row = document.createElement('tr');
        row.innerHTML = `
            <td>${book.id}</td>
            <td>${book.title}</td>
            <td>${book.borrowedDate}</td>
            <td>${book.returnedDate || 'Not Returned'}</td>
        `;
        tableBody.appendChild(row);
    });

    document.getElementById('historyPopup').classList.add('show');
}

// Function to hide browsing history popup
function hideHistoryPopup() {
    document.getElementById('historyPopup').classList.remove('show');
}

// Initial display of books
displayBooks();
