function MostrarSenha() {
    let senha = document.querySelector("input#senha");
    if (senha.type == 'password') {
        senha.type = 'text';
    } else {
        senha.type = "password";
    }
}
function MostrarSenhas() {
    let senha = document.querySelector("input#senha");
    let confirmSenha = document.querySelector("input#confirmarSenha");
    if (senha.type == 'password') {
        senha.type = 'text';
        confirmSenha.type = 'text';
    } else {
        senha.type = "password";
        confirmSenha.type = "password";
    }
}

function MostrarPassWord() {
    let senha = document.querySelector("input#senha");
    let novaSenha = document.querySelector("input#novasenha");
    let confirmSenha = document.querySelector("input#confirmarSenha");
    if (senha.type == 'password') {
        senha.type = 'text';
        novaSenha.type = 'text';
        confirmSenha.type = 'text';
    } else {
        senha.type = "password";
        novaSenha.type = 'password';
        confirmSenha.type = "password";
    }
}