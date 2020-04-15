using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public Sprite[] modelos;
    private SpriteRenderer sr;
    private Criador criador;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = modelos[Random.Range(0, modelos.GetLength(0))];
        criador = FindObjectOfType<Criador>();
    }

    void OnMouseDown() {
        criador.AumentarPontos();
        Destroy(gameObject);
    }
}
