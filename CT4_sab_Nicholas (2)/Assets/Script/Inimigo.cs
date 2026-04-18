using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public Transform personagem;

    void Start()
    {
        
    }

    void Update(){
        // personagem = GameObject.Find("Jogador").GetComponent<Transform>();
        
        // Faz o inimigo olhar para o player
        transform.LookAt(personagem);
        print("Estou rodando!");
        transform.Rotate(Vector3.right, 90);   
    }

    void FixedUpdate(){
        print("Estou rodando fixed!");
    }
}
