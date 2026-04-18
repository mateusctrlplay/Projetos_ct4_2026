using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiy : MonoBehaviour
{

 public Transform cobaia;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cobaia);
        transform.Rotate(Vector3.right, 90);

    }
}
