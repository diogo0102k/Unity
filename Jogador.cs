using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{

public string meunome;
public float Velocidade;
public float Pulo;

private Rigidbody2D rig;

private bool Pulando;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá "+ meunome);
        rig = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Eixo X e Eixo Y, Eixo Y Para cima e baixo e para frente e trás Eixo X
        
            rig.velocity = new Vector2(Velocidade, rig.velocity.y);

            if(Input.GetMouseButtonDown(0) && !Pulando){

                rig.AddForce(Vector2.up * Pulo, ForceMode2D.Impulse);
                 
            }

    }
        void Colisao(Collision2D colisor){

            if(colisor.gameObject.layer == 8){
        

            }


        }


}
