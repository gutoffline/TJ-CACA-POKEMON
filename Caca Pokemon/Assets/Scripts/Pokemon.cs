using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public Sprite[] modelos;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = modelos[Random.Range(0, modelos.GetLength(0))];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        Destroy(gameObject);
    }
}
