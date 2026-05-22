using UnityEngine;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            print("You Won!!!");
            Debug.Log("You Won!!!");
        }
    }
}

