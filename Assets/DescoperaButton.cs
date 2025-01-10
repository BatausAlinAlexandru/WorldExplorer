using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DescoperaButton : MonoBehaviour
{
    
    public string scenaDeDestinatie = "RomaniaInfoScene";

    
    public void MergiLaScenaDestinatie()
    {
        SceneManager.LoadScene(scenaDeDestinatie);
    }
}
