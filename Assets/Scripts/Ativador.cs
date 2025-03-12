using UnityEngine;

public class Ativador : MonoBehaviour
{
    public GameOver player;
    public GameObject canvaRes;

    void Start()
    {
        player = GameObject.FindAnyObjectByType<GameOver>();
        canvaRes.SetActive(false);
    }

    void Update()
    {
        Ativation();
    }

    void Ativation()
    {
        if(!player.verificaVidaPlayer())
        {
            canvaRes.SetActive(true);
        }
    }

}
