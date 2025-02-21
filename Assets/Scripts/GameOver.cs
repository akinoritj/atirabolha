using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Rasengan"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
