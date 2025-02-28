using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void Sair()
    {
        
    }
}
