let prices = [300,600,1000,800]
function szamol(){
    let index = document.getElementById("fruits").options.selectedIndex
    let darab = Number(document.getElementById("quantity").value)
    result.innerHTML="egység ár: "+prices[index]+" Ft <br>fizetendő: "+(darab*prices[index])+" Ft"
}

document.getElementById("fruits").onchange= szamol
document.getElementById("quantity").onchange= szamol
//nodejs otthonra