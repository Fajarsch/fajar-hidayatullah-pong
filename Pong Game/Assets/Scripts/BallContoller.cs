using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContoller : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;

    public Vector2 resetPosBall;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {   
        // Move object
    }

    public void ResetBall() {
        transform.position = new Vector3(resetPosBall.x, resetPosBall.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}
