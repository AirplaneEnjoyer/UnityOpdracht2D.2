using System;
using TMPro;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private string _coinTag = "Coin";
    [SerializeField] private TMP_Text _coinText;

    

    public AudioSource coinSound;

    public int Coin { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Ik heb W ingedrukt - boven");
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Ik heb S ingedrukt - beneden");
            transform.position -= new Vector3(0, 1, 0) * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Ik heb D ingedrukt - rechts");
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Ik heb A ingedrukt - links");
            transform.position -= new Vector3(1, 0, 0) * Time.deltaTime * _speed;
        }
    }

    // Handle collisions with coin objects
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CoinValue coinValue;
      
      if (collision.gameObject.CompareTag(_coinTag) && collision.gameObject.TryGetComponent<CoinValue>(out coinValue))
        {
         Coin += coinValue.GetScoreWorth();
         print(Coin);
         Destroy(collision.gameObject);

            _coinText.text = "Coins: " + Coin;
        }
    }
}
