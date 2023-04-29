using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUIncreasePadleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController leftPaddle;
    public PaddleController rightPaddle;
    public float increaseScale = 2f;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision == ball)
        {
            leftPaddle.ActivatePUIncreasePaddle(increaseScale, duration);
            rightPaddle.ActivatePUIncreasePaddle(increaseScale, duration);

            manager.RemovePowerUp(gameObject);
        }
    }
}
