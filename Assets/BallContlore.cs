using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class BallContlore : MonoBehaviour
{
    public TextMeshProUGUI TMPU;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        TMPU.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Hitcheck"))
        {
            TMPU.text = "Hit!!";
            Debug.Log("hit!!");
        }
    }
}
