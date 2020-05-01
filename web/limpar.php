<?php
    /* INÍCIO CONEXÃO */
    $servidor = "localhost";
    $banco = "id13314127_pokemon";
    $usuario = "id13314127_superpokemon";
    $senha = "1nn4>9@&!z_(yhKx";

    $conexao = mysqli_connect($servidor , $usuario , $senha , $banco);
    if(!$conexao){
        die("Deu ruim: " . mysqli_connect_error());
    }
    
    /* FIM CONEXÃO */
    $excluir = "delete from placar";
    if(mysqli_query($conexao , $excluir)){
        echo "Tabela limpa";
    }else{
        echo "Erro";
    }
    
    mysqli_close($conexao);
?>