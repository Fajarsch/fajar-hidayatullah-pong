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

    public void ResetBall() {
        transform.position = new Vector3(resetPosBall.x, resetPosBall.y, 2);
        rig.velocity = speed;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
        StartCoroutine(DeactivatePUSpeedUp(magnitude));
    }

    private IEnumerator DeactivatePUSpeedUp(float magnitude)
    {
        yield return new WaitForSeconds(5f);
        rig.velocity /= magnitude;
    }
}
