using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestManager : MonoBehaviour

{
    public string raspunsuriCorecte;
    public GameObject[] panouriIntrebari; // Lista cu toate panourile
    public TextMeshProUGUI textScor; // Text pentru afișarea scorului
    private int indexIntrebareCurenta = 0; // Care este întrebarea curentă
    private int scor = 0; // Câte răspunsuri corecte a dat jucătorul

    void Start()
    {
        // Asigură-te că doar primul panou este activ la start
        for (int i = 0; i < panouriIntrebari.Length; i++)
        {
            panouriIntrebari[i].SetActive(i == 0);
        }
    }

    public void VerificaRaspuns( int indexRaspunsSelectat)
    {
        if (indexRaspunsSelectat == raspunsuriCorecte[indexIntrebareCurenta] - '0')
        {
            scor++;
        }

        indexIntrebareCurenta++;
        textScor.text = "Scor: " + scor;

        if (indexIntrebareCurenta < panouriIntrebari.Length)
        {
            // Dezactivează panoul curent și activează următorul
            panouriIntrebari[indexIntrebareCurenta - 1].SetActive(false);
            panouriIntrebari[indexIntrebareCurenta].SetActive(true);
        }
        else
        {
            // Afișează scorul final după ce toate întrebările au fost completate
            panouriIntrebari[indexIntrebareCurenta - 1].SetActive(false);
            textScor.text = "Test complet! Ai obținut " + scor + " din " + panouriIntrebari.Length + " puncte!";
            textScor.gameObject.SetActive(true);
        }
    }
}
