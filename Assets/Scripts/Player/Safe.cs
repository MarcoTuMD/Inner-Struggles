using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar cenas

public class Safe : MonoBehaviour
{
    [SerializeField] private GameObject painelWin;
    [SerializeField] private GameObject painelJogo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            NewBehaviourScript player = collision.GetComponent<NewBehaviourScript>();
            StartCoroutine(WaitAndExecute());
        }
    }

    IEnumerator WaitAndExecute()
    {
        // Espera 5 segundos
        yield return new WaitForSeconds(5f);
        AbrirWin();
    }

    public void AbrirWin(){
        painelJogo.SetActive(false);
        painelWin.SetActive(true);
    }

    public void Reiniciar(){
        painelJogo.SetActive(true);
        painelWin.SetActive(false);
        // Reiniciar a cena atual (se estiver usando UnityEngine.SceneManagement)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu(){
        SceneManager.LoadScene("Menu"); // Substitua "NomeDaCenaDoMenu" pelo nome real da cena
    }

}
