function kerulet(a,b){

        return "A kerülett: "+ (2*(a+b))
    
}
function terulet(a,b){

        return "A területt: "+ a*b
    
    
}
document.querySelector("input[type='button']").addEventListener("click", function()
{
    let oldal1 = Number(document.getElementById("szam").value)   
    let oldal2 = Number(document.getElementById("szam1").value)
    if (oldal1 <= 0 || oldal2 <=0 ) {
        eredmeny.innerHTML = "Érvénytelen számok"   
    }
    else {
        eredmeny.innerHTML = terulet(oldal1, oldal2)
        eredmeny.innerHTML += "<br>"+kerulet(oldal1, oldal2)
    }

})