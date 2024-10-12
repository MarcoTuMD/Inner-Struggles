using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Para reiniciar a cena, se necessário
using TMPro;

public class PlayerController : MonoBehaviour
{

    //Variaveis Privadas
    private Rigidbody2D rd;
    private float walkForce;
    private bool isGrounded;

    //Variaveis Publicas
    public float speed;
    public float jumpForce;
    public int life = 3;
    public TextMeshProUGUI textLife;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        walkForce = Input.GetAxisRaw("Horizontal");
        if(isGrounded == true && Input.GetButtonDown("Jump")){
            Jump(jumpForce);
        }
                
        textLife.text = life.ToString();

        // Verifica se a vida chegou a 0
        CheckGameOver();
    }

    void FixedUpdate(){
        Move();
    }

    void Move(){
        rd.velocity = new Vector2(walkForce*speed, rd.velocity.y);
        if(walkForce > 0){
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(walkForce < 0){
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
    }

    public void Jump(float y){
        rd.velocity = new Vector2(rd.velocity.x, y);
        isGrounded = false;
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }

    }

    // Função que verifica se a vida chegou a 0 e executa o Game Over
    void CheckGameOver()
    {
        if (life <= 0)
        {
            // Reiniciar a cena atual (se estiver usando UnityEngine.SceneManagement)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
