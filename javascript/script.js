// var numero = 1;

// if (numero == "1") {
//     alert("== compara apenas os valores");
// }

// var mensagem;

// if (numero === "1") {
//     mensagem = "nunca executa";
// } else {
//     mensagem = "Number é diferente de string com o ==="
// }

// var x = (numero === "1") ? "Nunca execuada" : "Number é diferente de string com ===";



// var laranja = 6;

// switch (laranja) {
//     case 3:
//         alert('Fazer um copo de suco')
//         break;
//     case 6:
//         alert('Fazer dois copos de suco')
//         break;
//     case 9:
//         alert('Fazer uma jarra de suco')
//         break;
//         defaut:
//         alert('fazer quanto suco for possivel');
// }



// var pessoas = ["João", "José", "Maria", "Sebastião", "Antônio"];

// for(var i = 0; i < pessoas.length; i++)
// {
//     alert(pessoas[i]);
// }

// var nome = "";

// var pessoa = { nome:"Iara", sobrenome: "Almeida"};
// for(x in pessoa)
// {
//     nome += pessoa [x] + " ";

// }
// alert(nome);


// var numeros = 0;

// for(var i = 0; i < 10; i++)
// {
 
//     numeros++;
//     if(numeros%2 == 1)
//     {
//         alert(numeros)  
//     }
 
// }

// var soma =0;
// for(var i = 1; i <= 100; i++)
// {
 
//     soma += i;
   
  
// }
// alert(soma)


// function funcao()
// {
//     alert("ola")
// }


// function minhaFuncao()
// {
//   var input = document.getElementById("nome");
//   var nome1 = input.value;

//   var input = document.getElementById("idade");
//   var idade1 = input.value;

//   if(idade1=>18){
//     alert((nome1)  +  " é maior de idade")
//   }
 

// }



function minhaFuncao()
{
  var input = document.getElementById("numero1");
  var numero1 = input.value;

  var input = document.getElementById("numero2");
  var numero2 = input.value;

var soma = parseInt(numero1)  + parseInt(numero2) 

if(soma%2 == 0){
    document.getElementById('botao1').style.background = 'blue';
}
else{
    document.getElementById('botao1').style.background = 'green';
}
}
