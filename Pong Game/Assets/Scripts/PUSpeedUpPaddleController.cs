using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController leftPaddle;
    public PaddleController rightPaddle;
    public float magnitude = 2f;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision == ball)
        {
            leftPaddle.ActivatePUSpeedUp(magnitude, duration);
            rightPaddle.ActivatePUSpeedUp(magnitude, duration);

            manager.RemovePowerUp(gameObject);
        }
    }
}
