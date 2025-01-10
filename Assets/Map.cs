using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detectează click-ul stâng
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Transformă poziția click-ului în coordonate din scenă
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero); // Lansează un raycast în punctul click-ului

            if (hit.collider != null) // Dacă a lovit un collider
            {
                // Verifică ce continent a fost atins
                switch (hit.collider.gameObject.name)
                {
                    case "Europa":
                        SceneManager.LoadScene("EuropaScene"); 
                        break;
                    case "Africa":
                        SceneManager.LoadScene("AfricaScene"); 
                        break;
                    case "Asia":
                        SceneManager.LoadScene("AsiaScene"); 
                        break;
                    case "Australia":
                        SceneManager.LoadScene("AustraliaScene");
                        break;
                    case "Antarctica":
                        SceneManager.LoadScene("AntarcticaScene");
                        break;
                    case "America De Nord":
                        SceneManager.LoadScene("AmericaNordScene");
                        break;
                    case "America De Sud":
                        SceneManager.LoadScene("AmericaSudScene");
                        break;
                }
            }
        }
    }
}
