using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoPagesManager : MonoBehaviour
{
    public GameObject[] pagini; // Lista tuturor panourilor de informații
    private int paginaCurenta = 0;
    public string numeScenaTest = "RomaniaTestScene";


    public void MergiLaUrmatoareaPagina()
    {
        // Ascunde pagina curentă
        pagini[paginaCurenta].SetActive(false);

        // Crește indexul paginii
        paginaCurenta++;

        // Verifică dacă am depășit numărul total de pagini
        if (paginaCurenta >= pagini.Length)
        {
            SceneManager.LoadScene(numeScenaTest);
            return; 
        }

        // Afișează pagina următoare
        pagini[paginaCurenta].SetActive(true);
    }
}
