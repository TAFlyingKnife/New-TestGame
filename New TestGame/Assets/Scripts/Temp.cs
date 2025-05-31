using UnityEngine;

public class Temp : MonoBehaviour
{
    public Transform guy;

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        guy = GetComponent<Transform>();
        speed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        float InputX = Input.GetAxis("Horizontal");
        float InputY = Input.GetAxis("Vertical");
        
        guy.position += new Vector3(InputX*speed, InputY*speed, 0);
    }
}
