using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Textos : MonoBehaviour
{
    public TextMeshProUGUI textoPontos;
    public TextMeshProUGUI textoDeveres;
    private  Ball player;
    
    void Start()
    {
        player = GameObject.FindFirstObjectByType<Ball>();
        AtualizarTexto();
    }

    
    void Update()
    {
        AtualizarTexto();  
    }

    void AtualizarTexto()
    {
        textoPontos.text = player.PegaPontos().ToString() + "/45";
    }
}