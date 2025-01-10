using UnityEngine;
using UnityEngine.SceneManagement;

public class EuropeCountryDropdown : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null)
            {
                switch (hit.collider.gameObject.name)
                {
                    case "Romania":
                        SceneManager.LoadScene("RomaniaScene");
                        break;
                    case "Spania":
                        SceneManager.LoadScene("SpaniaScene");
                        break;
                    case "Portugalia":
                        SceneManager.LoadScene("PortugaliaScene");
                        break;
                    case "Grecia":
                        SceneManager.LoadScene("GreciaScene");
                        break;
                    case "Norvegia":
                        SceneManager.LoadScene("NorvegiaScene");
                        break;
                    case "Finlanda":
                        SceneManager.LoadScene("FinlandaScene");
                        break;
                    case "Suedia":
                        SceneManager.LoadScene("SuediaScene");
                        break;
                    case "Elvetia":
                        SceneManager.LoadScene("ElvetiaScene");
                        break;
                    case "Franta":
                        SceneManager.LoadScene("FrantaScene");
                        break;
                    case "Austria":
                        SceneManager.LoadScene("AustriaScene");
                        break;
                    case "Luxemburg":
                        SceneManager.LoadScene("LuxemburgScene");
                        break;
                    case "Letonia":
                        SceneManager.LoadScene("LetoniaScene");
                        break;
                    case "Lituania":
                        SceneManager.LoadScene("LituaniaScene");
                        break;
                    case "Ucraina":
                        SceneManager.LoadScene("UcrainaScene");
                        break;
                    case "Bulgaria":
                        SceneManager.LoadScene("BulgariaScene");
                        break;
                    case "Italia":
                        SceneManager.LoadScene("ItaliaScene");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}