let cpf = document.getElementById('cpf')
cpf.style.display = "none";
let cnpj = document.getElementById('cnpj')
cnpj.style.display = "none";
let data = document.getElementById('data')
data.style.display = "none";
let checkbox = document.getElementById('fisica');
let checkbox2 = document.getElementById('juridica');



function checarF(){
    if(checkbox.checked ) {
        cpf.style.display = 'block'
    } 
    if(checkbox.checked ) {
        data.style.display = 'block'
    } 
    if(checkbox.checked ) {
        cnpj.style.display = 'none'
    } 
}



function checarJ(){
    if(checkbox2.checked ) {
        cpf.style.display = 'none'
    }
    if(checkbox2.checked ) {
        data.style.display = 'none'
    } 
     if(checkbox2.checked ) {
        cnpj.style.display = 'block'
    } 
    
}
