let existingNICs = [];

// Function to simulate password encryption (for demonstration purposes)
function encryptPassword(password) {
    return btoa(password); // Simple encryption using base64 encoding
}

// User Creation
document.getElementById('memberCreationForm').addEventListener('submit', function (event) {
    event.preventDefault();

    let username = document.getElementById('createUsername').value;
    let nic = document.getElementById('createNIC').value;
    let email = document.getElementById('createEmail').value;
    let mobileNumber = document.getElementById('createMobileNumber').value;
    let password = encryptPassword(document.getElementById('createPassword').value);

    // Check if NIC already exists
    if (existingNICs.includes(nic)) {
        document.getElementById('creationMessage').innerText = "NIC already registered.";
        return;
    }

    existingNICs.push(nic); // Add only the NIC to the array

    // Display a success message and reset the form
    document.getElementById('creationMessage').textContent = "Account successfully created. Redirecting to login...";
    setTimeout(function() {
        window.location.href = 'login.html'; // Redirect to login page after 2 seconds
    }, 2000);
});
