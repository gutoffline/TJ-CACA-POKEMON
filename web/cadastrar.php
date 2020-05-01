<?php
/* INÍCIO CONEXÃO */
$servidor = "localhost";
$banco = "pokemon";
$usuario = "root";
$senha = "";

$conexao = mysqli_connect($servidor , $usuario , $senha , $banco);
if(!$conexao){
    die("Deu ruim: " . mysqli_connect_error());
}

echo "Tá conectado!<br>";
/* FIM CONEXÃO */
$nome1 = $_POST['nome1'];
$pontos1 = $_POST['pontos1'];
$nome2 = $_POST['nome2'];
$pontos2 = $_POST['pontos2'];
$nome3 = $_POST['nome3'];
$pontos3 = $_POST['pontos3'];
$inserir = "insert into placar(nome1, pontos1, nome2, pontos2, nome3, pontos3) values('$nome1' , $pontos1 , '$nome2', $pontos2 , '$nome3', $pontos3)";

if(mysqli_query($conexao , $inserir)){
    echo "Novo registro criado<br>";
}else{
    echo "Erro: " . mysqli_error($conexao);
}
?>
