using UnityEngine;

public class Destroi : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Rasengan"))
        {
            Destroy(this.gameObject);
        }
    }
}
