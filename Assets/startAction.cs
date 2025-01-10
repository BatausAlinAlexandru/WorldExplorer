using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startAction : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "MapScene";

    void OnMouseDown()
    {
        // Detecteazã clicul pe butonul cu Polygon Collider 2D
        Debug.Log("Butonul Start a fost apãsat!");
        SceneManager.LoadScene(sceneToLoad);
    }
}
