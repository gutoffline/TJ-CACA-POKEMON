using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaRanking : MonoBehaviour
{
    public Text listaCampeoes;
    void Start()
    {
        MontaListaCampeoes();
    }

    // Update is called once per frame
    void MontaListaCampeoes(){

        string suaPontuacao = "";

        if(PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador1")){

           PlayerPrefs.SetInt("PontosJogador3" , PlayerPrefs.GetInt("PontosJogador2"));
           PlayerPrefs.SetInt("PontosJogador2" , PlayerPrefs.GetInt("PontosJogador1"));
           PlayerPrefs.SetInt("PontosJogador1" , PlayerPrefs.GetInt("PontosAtual"));

           PlayerPrefs.SetString("NomeJogador3" , PlayerPrefs.GetString("NomeJogador2"));
           PlayerPrefs.SetString("NomeJogador2" , PlayerPrefs.GetString("NomeJogador1"));
           PlayerPrefs.SetString("NomeJogador1" , PlayerPrefs.GetString("NomeJogador"));

        }else if(PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador2")){
            PlayerPrefs.SetInt("PontosJogador3" , PlayerPrefs.GetInt("PontosJogador2"));
            PlayerPrefs.SetInt("PontosJogador2" , PlayerPrefs.GetInt("PontosAtual"));

            PlayerPrefs.SetString("NomeJogador3" , PlayerPrefs.GetString("NomeJogador2"));
            PlayerPrefs.SetString("NomeJogador2" , PlayerPrefs.GetString("NomeJogador"));

        }else if(PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador3")){

            PlayerPrefs.SetInt("PontosJogador3" , PlayerPrefs.GetInt("PontosAtual"));
            PlayerPrefs.SetInt("PontosJogador3" , PlayerPrefs.GetInt("PontosAtual"));
        }else{
            suaPontuacao = "\nSua Pontuação: " + PlayerPrefs.GetInt("PontosAtual");
        }

        listaCampeoes.text = "1º - " + PlayerPrefs.GetString("NomeJogador1");
        listaCampeoes.text += " - " + PlayerPrefs.GetInt("PontosJogador1");

        listaCampeoes.text += "\n2º - " + PlayerPrefs.GetString("NomeJogador2");
        listaCampeoes.text += " - " + PlayerPrefs.GetInt("PontosJogador2");

        listaCampeoes.text += "\n3º - " + PlayerPrefs.GetString("NomeJogador3");
        listaCampeoes.text += " - " + PlayerPrefs.GetInt("PontosJogador3");

        listaCampeoes.text += suaPontuacao;

        PlayerPrefs.SetString("NomeJogador","");
        PlayerPrefs.SetInt("PontosAtual",0);

    }

    public void LimparRanking(){
        PlayerPrefs.SetString("NomeJogador1","");
        PlayerPrefs.SetInt("PontosJogador1",0);

        PlayerPrefs.SetString("NomeJogador2","");
        PlayerPrefs.SetInt("PontosJogador2",0);

        PlayerPrefs.SetString("NomeJogador3","");
        PlayerPrefs.SetInt("PontosJogador3",0);
        listaCampeoes.text = "";
    }
    void Update()
    {
        
    }
}
