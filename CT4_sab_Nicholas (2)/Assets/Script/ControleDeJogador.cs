using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeJogador : MonoBehaviour
{

    public float sensibilidadeDeMouse = 100f;
    public Transform jogador;
    float rotacaoX = 0f;

    public CharacterController controller;
    public float velocidade = 4.04f;
    public float gravidade = -9.81f;

    public Vector3 aceleracao;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // -1 ou +1
        float z = Input.GetAxis("Vertical"); // -1 ou +1

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move (move * velocidade * Time.deltaTime);

        aceleracao.y += gravidade * Time.deltaTime;
        controller.Move(aceleracao * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * sensibilidadeDeMouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadeDeMouse * Time.deltaTime;

        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        jogador.Rotate(Vector3.up * mouseX);
    }
}
