﻿using System.Collections;
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
        PlayerPrefs.SetString("NomeJogador0" , nome.text);
        pontuacao.text = "PONTUAÇÃO\n" + PlayerPrefs.GetString("NomeJogador0") + " : " + PlayerPrefs.GetInt("PontosJogador0");
        nome.text = "";
        SceneManager.LoadScene("CenaRanking");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
