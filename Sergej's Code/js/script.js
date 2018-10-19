//Funkcija koja prikazuje ili sakriva navigaciju na malim ekranima
function myFunction() {
	document.body.scrollTop = 0; 
    document.documentElement.scrollTop = 0;
    var x = document.getElementById("navDemo");
    if (x.className.indexOf("w3-show") == -1) {
        x.className += " w3-show";
    } else { 
        x.className = x.className.replace(" w3-show", "");
    }
}

//Funkcija koja sakriva navigaciju na malim ekranima
function myNewFunction() {
	var x = document.getElementById("navDemo");
	if (x.className.indexOf("w3-show") != -1) {
		x.className = x.className.replace(" w3-show", "");
	}
}

//Pokretanje funkcije na scroll dogadjaj
window.onscroll = function() {mojaFunkcija()};

//Funkcija koja proverava koliko piksela je skrolovao korisnik
function mojaFunkcija() {
  if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
        var x = document.getElementById("navDemo");
	if (x.className.indexOf("w3-show") != -1) {
		x.className = x.className.replace(" w3-show", "");
	}
  } 
} 