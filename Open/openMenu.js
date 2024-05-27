function openMenuFunction() {
    document.getElementById("menuBar").style.display="block";
}

function actionFunction() {
    var n = document.getElementById("numberBar").value;
    if (n == 1) {
        document.getElementById("menuBar").style.display="none";
        document.getElementById("factorialNo").style.display="block";
        console.log("Factorial Working");
    } else if (n == 2) {
        document.getElementById("menuBar").style.display="none";
        document.getElementById("triangleNo").style.display="block";
        console.log("Triangle Working");
    } else if (n == 0) {
        document.getElementById("menuBar").style.display="none";
        document.getElementById("answer").innerHTML= "";
        console.log("Exit Working");
    }
}

function fact_Function() {
    var fact = document.getElementById("factNo").value;
    var factorial=1;

    for(var i=1;i<=fact;++i) {
        factorial=factorial * i;
    }
    document.getElementById("answer").innerHTML = "Factorial of"+""+fact+" "+"is"+" "+ factorial;
    document.getElementById("menuBar").style.display="block";
    document.getElementById("factorialNo").style.display="none";
    document.getElementById("triangleNo").style.display="none";
    console.log("Factorial answer Working");

}

function tri_Function() {
    var triangular=parseInt(document.getElementById("triNo").value);
    var triangular_answer=triangular * (triangular+1)/2;
    document.getElementById("answer").innerHTML="Triangular Number of"+" "+triangular+" "+"is"+" "+triangular_answer;
    document.getElementById("menuBar").style.display="block";
    document.getElementById("factorialNo").style.display="none";
    document.getElementById("triangleNo").style.display="none";
    console.log("Triangle answer Working");
}