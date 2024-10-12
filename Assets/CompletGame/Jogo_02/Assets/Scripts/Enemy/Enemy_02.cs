using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_02 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            PlayerController player = collision.GetComponent<PlayerController>();
            player.life--;
            // Inicia o efeito de dano
            StartCoroutine(ChangeColorOnDamage(player));
            player.Jump(20);
        }
    }

    IEnumerator ChangeColorOnDamage(PlayerController player2){
        // Obtém o SpriteRenderer do jogador
        SpriteRenderer playerSprite = player2.GetComponent<SpriteRenderer>();

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
