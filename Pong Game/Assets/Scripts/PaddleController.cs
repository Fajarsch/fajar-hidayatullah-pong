using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private Vector3 paddleScale;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        paddleScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {   
        //  Get input
        Vector3 movement = GetInput();

        // Move object
        MoveObject(movement);
    }

    private Vector2 GetInput()
    {
        if(Input.GetKey(upKey)) {
            // Paddle up
            return Vector2.up * speed;
        }

        if(Input.GetKey(downKey)) {
            // Paddle down
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {   
        rig.velocity = movement;
    }

    public void ActivatePUIncreasePaddle(float increaseScale, float duration)
    {
        StartCoroutine(IncreasePaddle(increaseScale, duration));
    }

    private IEnumerator IncreasePaddle(float increaseScale, float duration)
    {
        Vector3 paddleScale = transform.localScale;
        transform.localScale = new Vector3(paddleScale.x, paddleScale.y * increaseScale, paddleScale.z);
        yield return new WaitForSeconds(duration);
        transform.localScale = paddleScale;
    }
}
