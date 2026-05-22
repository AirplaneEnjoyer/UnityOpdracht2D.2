using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private string _coinTag = "Coin";
    [SerializeField] private TMP_Text _coinText;

    private int Coin = 0;
    private int _score = 0;

    public AudioSource coinSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            print("Ik heb W ingedrukt");
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * _speed;
            Debug.Log("boven");
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("Ik heb S ingedrukt");
            transform.position -= new Vector3(0, 1, 0) * Time.deltaTime * _speed;
            Debug.Log("beneden");
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("Ik heb D ingedrukt");
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * _speed;
            Rotate(0, 0, 0);
            Debug.Log("rechts");
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Ik heb A ingedrukt");
            transform.position -= new Vector3(1, 0, 0) * Time.deltaTime * _speed;
            Rotate(0, 180, 0);
            Debug.Log("links");
        }
    }

    private void Rotate(int v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CoinValue CoinValue;
        if (collision.gameObject.CompareTag(_coinTag) && collision.gameObject.TryGetComponent<CoinValue>(out CoinValue))
        {
            Coin += CoinValue.GetScoreWorth();
            print(Coin);
            Destroy(collision.gameObject);

            _coinText.text = "Score: " + Coin.ToString();
            coinSound.Play();
        }
    }

}
