using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text pontuacao;
    public InputField nome;
    void Start()
    {

    }

    public void Salvar(){
        PlayerPrefs.SetString("NomeJogador" , nome.text);
        pontuacao.text = "PONTUAÇÃO\n" + PlayerPrefs.GetString("NomeJogador") + " : " + PlayerPrefs.GetInt("PontosAtual");
        nome.text = "";
        
        SceneManager.LoadScene("CenaRanking");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
