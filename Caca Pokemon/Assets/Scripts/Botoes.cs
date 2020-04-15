using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{
    public DontDestroyThis objetoMusica;
    AudioSource minhaMusica;
    private float volume = 100f;
    public Text volumeVisor;

    public AudioClip musica1;
    public AudioClip musica2;

    void Start() {
        minhaMusica = FindObjectOfType<DontDestroyThis>().GetComponent<AudioSource>();
    }

    public void Play(){
        minhaMusica.Play();
    }

    public void Stop(){
        minhaMusica.Stop();
    }

    public void Aumentar(){
        if(volume < 100){
            volume += 10;
            volumeVisor.text = "Volume: " + volume;
            minhaMusica.volume = volume/100;
        }
    }

    public void Diminuir(){
        if(volume > 0){
            volume -= 10;
            volumeVisor.text = "Volume: " + volume;
            minhaMusica.volume = volume/100;
        }
    }

    public void TocarMusica1(){
        minhaMusica.Stop();
        minhaMusica.clip = musica1;
        minhaMusica.Play();
    }

    public void TocarMusica2(){
        minhaMusica.Stop();
        minhaMusica.clip = musica2;
        minhaMusica.Play();
    }

    public void AbrirConfiguracoes(){
        SceneManager.LoadScene("CenaConfiguracoes");
    }

    public void AbrirInicio(){
        SceneManager.LoadScene("CenaInicio");
    }

    public void AbrirTutorial(){
        SceneManager.LoadScene("CenaTutorial");
    }

    public void AbrirJogo(){
        SceneManager.LoadScene("CenaJogo");
    }

    public void AbrirRanking(){
        SceneManager.LoadScene("CenaRanking");
    }


}
