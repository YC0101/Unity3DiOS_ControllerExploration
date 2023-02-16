using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DownMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    public GameObject Player;
    public float Force;
    public float speed = 0;

    private Rigidbody rb;

    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            //Player.transform.Translate(Force * Time.deltaTime, 0, 0);
            Vector3 movement = new Vector3(0,0,Force * Time.deltaTime);
            rb.AddForce(movement * speed);
        }
        else
        {
            //Player.transform.Translate(0, 0, 0);
        }
    }
}
