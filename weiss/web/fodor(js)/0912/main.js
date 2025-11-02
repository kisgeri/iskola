function kiir()
{
    let valasz = document.getElementById("eredmeny");
    valasz.style.color="red";
    valasz.style.backgroundColor="yellow";
    valasz.innerHTML="<b>hibás név</b>";
}

function terulet(a,b)
{

    let valasz = document.getElementById("eredmeny");
    valasz.innerHTML="a terület "+ a*b+"cm2";
    valasz.style.color="";
    valasz.style.backgroundColor="";
}