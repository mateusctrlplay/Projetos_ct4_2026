using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dyleinimizade : MonoBehaviour
{
 
 public  Transform personagem;
 
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.LookAt(personagem);
      transform.Rotate(Vector3.right,  90);
    }
}
