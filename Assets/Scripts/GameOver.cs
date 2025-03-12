using UnityEngine;


public class GameOver : MonoBehaviour
{
    public bool estaVivo = true;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Rasengan"))
        {
            estaVivo = false;
            Time.timeScale = 0f;
        }
    }
        public bool verificaVidaPlayer()
    {
        return estaVivo;
    }
}
