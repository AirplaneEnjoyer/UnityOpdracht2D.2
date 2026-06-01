using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : MonoBehaviour
{
    [SerializeField] private string _playerTag = "Player";



    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag(_playerTag))
        {
            SceneManager.LoadScene("ExitGame");
        }
    }
}

