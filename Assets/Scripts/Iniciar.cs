using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{

    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
