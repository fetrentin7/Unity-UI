using UnityEngine;

public class Target : MonoBehaviour
{
    //tossing them 4 targets into the air with a random force, torque and position
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 5;
    private float xRange = 4.0f;
    private float ySpawnPos = -6.0f;
    private GameManager gameManager;

    public int pointValue;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), Random.Range(-maxTorque, maxTorque), 
            Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);

        transform.position = new Vector3(Random.Range(-xRange, xRange), ySpawnPos); //random place for the object to spawn
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
       return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameManager.UpdateScore(5);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
