document.querySelector("h1")
<h1>​DOM példa​</h1>​
document.querySelector("h1").innerText
'DOM példa'
document.querySelector("h1").innerText = "Fodor best"
'Fodor best'
document.querySelector("#eredmeny").innerText
'elso bekezdés'
document.querySelector("#eredmeny").innerText = "<i>második</i>"
'<i>második</i>'
document.querySelector("#eredmeny").innerHTML = "<i>második</i>"
'<i>második</i>'
document.getElementById("eredmeny")
<p id=​"eredmeny">​…​</p>​
document.querySelectorAll("p")
NodeList(6) [p#eredmeny, p.szamok, p.szamok, p.szamok, p.szamok, p.szamok]
document.querySelectorAll(".szamok")
NodeList(5) [p.szamok, p.szamok, p.szamok, p.szamok, p.szamok]
document.querySelectorAll(".szamok[2]")
VM635:1 Uncaught SyntaxError: Failed to execute 'querySelectorAll' on 'Document': '.szamok[2]' is not a valid selector.
    at <anonymous>:1:10
(anonymous) @ VM635:1
document.querySelectorAll(".szamok")[2]
<p class=​"szamok">​3​</p>​
document.querySelectorAll(".szamok")[2].innerText="31"
'31'
