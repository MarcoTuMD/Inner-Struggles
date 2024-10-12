using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform a;

    // Update is called once per frame
    void Update()
    {
        // Move o inimigo em direção ao ponto A
        transform.position = Vector2.MoveTowards(transform.position, a.position, speed * Time.deltaTime);

        // Verifica se o inimigo chegou ao ponto A
        if (Vector2.Distance(transform.position, a.position) < 0.1f)
        {
            // Para de se mover ao atingir o ponto A
            enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            NewBehaviourScript player = collision.GetComponent<NewBehaviourScript>();
            player.life--;
            // Inicia o efeito de dano
            StartCoroutine(ChangeColorOnDamage(player));
            player.Jump(20);
        }
    }

    IEnumerator ChangeColorOnDamage(NewBehaviourScript player){
        // Obtém o SpriteRenderer do jogador
        SpriteRenderer playerSprite = player.GetComponent<SpriteRenderer>();

        if (playerSprite != null)
        {
            // Muda a cor para vermelha
            playerSprite.color = Color.red;

            // Aguarda 0.5 segundos antes de restaurar a cor original
            yield return new WaitForSeconds(0.5f);

            // Restaura a cor original (branca)
            playerSprite.color = Color.white;
        }
    }
}
