using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoController : MonoBehaviour
{

    public int Speed;
    public int RotationSpeed;
    public bool Forward;
    public bool Left;
    public bool Right;
    public bool Down;

    private GameObject Car;
    private Rigidbody _RigidbodyCar;

    // Start is called before the first frame update
    void Start()
    {
        Car = this.gameObject;
        _RigidbodyCar = Car.GetComponent<Rigidbody>();
        Debug.Log(_RigidbodyCar);
    }

    // Update is called once per frame
    void Update()
    {
        var TimePastSinceLastFrame = Time.deltaTime;
        var DistanceToTravel = Speed * TimePastSinceLastFrame;
       
        
        if (Forward)
        {
            //Car.transform.position += Car.transform.forward * DistanceToTravel;
            _RigidbodyCar.AddForce(Car.transform.forward * DistanceToTravel, ForceMode.VelocityChange);
        }

        if (Left)
        {
            Car.transform.Rotate(0, Time.deltaTime + -DistanceToTravel, 0, Space.Self);
            Debug.Log("Hallo");
        }

        if (Right)
        {
            Car.transform.Rotate(0, Time.deltaTime + DistanceToTravel, 0, Space.Self);
        }
        if (Down)
        {
            //Car.transform.position += Car.transform.forward * DistanceToTravel;
            _RigidbodyCar.AddForce(Car.transform.forward * -DistanceToTravel, ForceMode.VelocityChange);
        }
    }
}