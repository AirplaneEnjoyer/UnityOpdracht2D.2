using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Physics2D.gravity = -Physics2D.gravity;
        }
    }
}
