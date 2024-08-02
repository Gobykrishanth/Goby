const users = [
    { nic: '123456789V', password: 'password123' },
    { nic: '987654321X', password: 'securePass456' }
];

// Function to handle login
document.getElementById('loginForm').addEventListener('submit', function (event) {
    event.preventDefault();

    let nic = document.getElementById('loginNIC').value;
    let password = document.getElementById('loginPassword').value;

    // Check if the NIC and password match any user
    let user = users.find(user => user.nic === nic && user.password === password);

    if (user) {
        document.getElementById('loginMessage').textContent = "Login successful!";
        document.getElementById('loginMessage').style.color = "green";
        // Store login status in sessionStorage
        sessionStorage.setItem('loggedIn', 'true');
        // Redirect to the member interface page
        window.location.href = 'Member_Interface.html'; // Update this path as needed
    } else {
        document.getElementById('loginMessage').textContent = "Invalid NIC or password.";
        document.getElementById('loginMessage').style.color = "red";
    }
});
