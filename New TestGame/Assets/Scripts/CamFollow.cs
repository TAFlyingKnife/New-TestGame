using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform subject;
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 change = new Vector3(target.position.x, target.position.y, -10f);
        subject.position = change;
    }
}
