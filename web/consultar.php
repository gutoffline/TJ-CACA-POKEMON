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

    $consulta = "select * from placar";
    $sql = mysqli_query($conexao , $consulta);
    while($dados = mysqli_fetch_assoc($sql)){
        echo $dados['nome1'] . "-" . $dados['pontos1'] . ";";
        echo $dados['nome2'] . "-" . $dados['pontos2'] . ";";
        echo $dados['nome3'] . "-" . $dados['pontos3'] . ";";
    }
    mysqli_close($conexao);
?>