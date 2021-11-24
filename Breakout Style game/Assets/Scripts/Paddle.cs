using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float widthInUnits = 16f;
    [SerializeField] float max = 15f;
    [SerializeField] float min = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos = Input.mousePosition.x / Screen.width * widthInUnits;
        Vector2 paddlePos = new Vector2 (transform.position.x , transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePos, min, max);
        transform.position = paddlePos;

    }
}
