using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ControlaRanking : MonoBehaviour
{
    public Text listaCampeoes;
    private string suaPontuacao;
    private string url = "https://bdpokemon.000webhostapp.com";
    void Start()
    {
        StartCoroutine(WebCarregar());
        OrganizaRanking();
        listaCampeoes.text = MontaRanking();
        LimparDadosJogadorAtual();
    }

    IEnumerator WebCarregar(){
        UnityWebRequest www = UnityWebRequest.Get(url + "/consultar.php");
        yield return www.SendWebRequest();
        if(www.isHttpError){
            Debug.Log("Deu ruim: " + www.error);
        }else{
            string placar = www.downloadHandler.text;
            string[] lugares = placar.Split(';');
            string[] lugar1 = lugares[0].Split('-');
            string[] lugar2 = lugares[1].Split('-');
            string[] lugar3 = lugares[2].Split('-');
            PlayerPrefs.SetString("NomeJogador1", lugar1[0]);
            PlayerPrefs.SetInt("PontosJogador1", Int32.Parse(lugar1[1]));

            PlayerPrefs.SetString("NomeJogador2", lugar2[0]);
            PlayerPrefs.SetInt("PontosJogador2", Int32.Parse(lugar2[1]));

            PlayerPrefs.SetString("NomeJogador3", lugar3[0]);
            PlayerPrefs.SetInt("PontosJogador3", Int32.Parse(lugar3[1]));
        }
    }


    IEnumerator WebDeletar(){
        UnityWebRequest www = UnityWebRequest.Get(url + "/limpar.php");
        yield return www.SendWebRequest();
        if(www.isHttpError){
            Debug.Log("Deu ruim: " + www.error);
        }else{
            Debug.Log("Deu Bom: "+ www.downloadHandler.text);
        }
    }

    

    

    
    void OrganizaRanking(){
        if(PlayerPrefs.GetInt("PontosJogador0") > PlayerPrefs.GetInt("PontosJogador1")){
            TrocaTroca("3","2");
            TrocaTroca("2","1"); 
            TrocaTroca("1","0");
        }else if(PlayerPrefs.GetInt("PontosJogador0") > PlayerPrefs.GetInt("PontosJogador2")){
            TrocaTroca("3","2");
            TrocaTroca("2","0");
        }else if(PlayerPrefs.GetInt("PontosJogador0") > PlayerPrefs.GetInt("PontosJogador3")){
            TrocaTroca("3","0");
        }else{
            if(PlayerPrefs.GetInt("PontosJogador0") > 0){
                suaPontuacao = "\nSua Pontuação: " + PlayerPrefs.GetInt("PontosJogador0");
            }
        }
    }

    public void TrocaTroca(string numeroSaindo , string numeroEntrando){
        PlayerPrefs.SetInt("PontosJogador"+numeroSaindo , PlayerPrefs.GetInt("PontosJogador"+numeroEntrando));
        PlayerPrefs.SetString("NomeJogador"+numeroSaindo , PlayerPrefs.GetString("NomeJogador"+numeroEntrando));
    }

    public string MontaRanking(){
        string ranking = "1º - " + PlayerPrefs.GetString("NomeJogador1");
        ranking += " - " + PlayerPrefs.GetInt("PontosJogador1");
        ranking += "\n2º - " + PlayerPrefs.GetString("NomeJogador2");
        ranking += " - " + PlayerPrefs.GetInt("PontosJogador2");
        ranking += "\n3º - " + PlayerPrefs.GetString("NomeJogador3");
        ranking += " - " + PlayerPrefs.GetInt("PontosJogador3");
        ranking += suaPontuacao;
        return ranking;
    }

    public void LimparDadosJogadorAtual(){
        PlayerPrefs.SetString("NomeJogador0","");
        PlayerPrefs.SetInt("PontosJogador0",0);
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
