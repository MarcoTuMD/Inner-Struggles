using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BildManeger : MonoBehaviour
{
    [SerializeField] private string NameLevel_1;
    [SerializeField] private string NameLevel_2;
    [SerializeField] private GameObject painelMenu;
    [SerializeField] private GameObject painelFaseI;
    [SerializeField] private GameObject painelFaseII;
    [SerializeField] private GameObject painelFaseIII;
    [SerializeField] private GameObject painelFaseIV;
    [SerializeField] private GameObject painelFaseV;

    //public void Jogar(){
    //    pass
    //}

    public void AbrirFaseI(){
        painelMenu.SetActive(false);
        painelFaseI.SetActive(true);
    }

    public void FecharFaseI(){
        painelFaseI.SetActive(false);
        painelMenu.SetActive(true);
    }

    //-------------------------------------

    public void AbrirFaseII(){
        painelMenu.SetActive(false);
        painelFaseII.SetActive(true);
    }

    public void FecharFaseII(){
        painelFaseII.SetActive(false);
        painelMenu.SetActive(true);
    }
    
    //-------------------------------------

    public void AbrirFaseIII(){
        painelMenu.SetActive(false);
        painelFaseIII.SetActive(true);
    }

    public void FecharFaseIII(){
        painelFaseIII.SetActive(false);
        painelMenu.SetActive(true);
    }

    //-------------------------------------

    public void AbrirFaseIV(){
        painelMenu.SetActive(false);
        painelFaseIV.SetActive(true);
    }

    public void FecharFaseIV(){
        painelFaseIV.SetActive(false);
        painelMenu.SetActive(true);
    }

    //-------------------------------------

    public void AbrirFaseV(){
        painelMenu.SetActive(false);
        painelFaseV.SetActive(true);
    }

    public void FecharFaseV(){
        painelFaseV.SetActive(false);
        painelMenu.SetActive(true);
    }

    //-------------------------------------

    public void jogar1(){
        SceneManager.LoadScene(NameLevel_1);
    }

    public void jogar2(){
        SceneManager.LoadScene(NameLevel_2);
    }

}
