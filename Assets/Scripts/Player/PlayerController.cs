using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.SceneManagement; // Para reiniciar a cena, se necessário
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{

    // Variaveis privadas
    private Rigidbody2D rD;
    private float walkForce;
    private bool isGrounded; // Indica se o personagem está no chão

    // Variaveis publicas
    public float speed;
    public float jumpForce;
    public int life = 3;
    public TextMeshProUGUI textLife;
    

    // Start is called before the first frame update
    void Start()
    {
        rD = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        walkForce = Input.GetAxisRaw("Horizontal"); // Atualize movX a cada frame

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

    public void Move(){
        rD.velocity = new Vector2(walkForce * speed, rD.velocity.y);
        if(walkForce > 0){
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(walkForce < 0){
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
    }

    public void Jump(float y){
        rD.velocity = new Vector2(rD.velocity.x, y);
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
