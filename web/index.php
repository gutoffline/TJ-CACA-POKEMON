<h1>Pokemon</h1>
<hr>
<a href="limpar.php">Limpar</a>
<form name="formulario_pontos" method="post" action="cadastrar.php">
    Nome 1º Lugar <input name="nome1">
    Pontos 1º Lugar <input name="pontos1"> <br>

    Nome 2º Lugar <input name="nome2">
    Pontos 2º Lugar <input name="pontos2"> <br>

    Nome 3º Lugar <input name="nome3">
    Pontos 3º Lugar <input name="pontos3"> <br>

    <button type="submit">Cadastrar</button>
</form>
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
    
    echo "Tá conectado!<br>";
    /* FIM CONEXÃO */
    $consulta = "select * from placar";
    $sql = mysqli_query($conexao , $consulta);
    while($dados = mysqli_fetch_assoc($sql)){
        echo "1º Lugar - " . $dados['nome1'] . $dados['pontos1'] . " pontos";
        echo "<br>";
        echo "2º Lugar - " . $dados['nome2'] . $dados['pontos2'] . " pontos";
        echo "<br>";
        echo "3º Lugar - " . $dados['nome3'] . $dados['pontos3'] . " pontos";
        echo "<br>";
    }
    mysqli_close($conexao);
?>

