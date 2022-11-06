let botao = document.getElementById('button1')
botao.style.display = "none";

let checkbox = document.getElementById('check1');
let checkbox1 = document.getElementById('check2');




function checar(){
    if(checkbox.checked && checkbox1.checked ) {
        botao.style.display = 'block'
    } else {
        botao.style.display = 'none'
    }
}

