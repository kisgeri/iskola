//defer html-be hogy ne a js töltődjön először
function kiir()
{
    
    document.getElementById("eredmeny").innerText+=" kristály cukor ";
}
document.getElementById("gomb").onclick=kiir;//csak hozárendeli nem meghívja () nélkül

document.getElementById("gomb2").onclick=function() {eredmeny.innerText="névtelen függvény "};

document.getElementById("gomb3").addEventListener("click",kiir)
document.getElementById("gomb4").addEventListener("click", function(){eredmeny.innerText="addeventListener nevtelem "})

//parameteres
 function terulet(a,b)
 {
    return a*b;
 }

 document.getElementById("gomb5").onclick=function() {eredmeny.innerText=terulet(3,5)};

 //nyilfug
 document.getElementById("gomb6").addEventListener("click",()=>{eredmeny.innerText=terulet(10,5)})