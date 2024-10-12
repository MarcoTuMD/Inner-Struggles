using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformMove : MonoBehaviour
{
    public float speed;
    public Transform a;
    public Transform b;

    private bool goRight;

    // Start is called before the first frame update
    void Start()
    {
        // Inicializa para ir em direção ao ponto B inicialmente
        goRight = true; 
    }

    // Update is called once per frame
    void Update()
    {
        // Movimentação para o ponto B
        if (goRight)
        {
            // Se a plataforma estiver próxima de B, muda a direção
            if (Vector2.Distance(transform.position, b.position) < 0.1f)
            {
                goRight = false;
            }
            // Move-se em direção a B
            transform.position = Vector2.MoveTowards(transform.position, b.position, speed * Time.deltaTime);
        }
        // Movimentação para o ponto A
        else
        {
            // Se a plataforma estiver próxima de A, muda a direção
            if (Vector2.Distance(transform.position, a.position) < 0.1f)
            {
                goRight = true;
            }
            // Move-se em direção a A
            transform.position = Vector2.MoveTowards(transform.position, a.position, speed * Time.deltaTime);
        }
    }
}
