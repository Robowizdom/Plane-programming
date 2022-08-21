using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject propeller;
    public float angle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(Vector3.forward, angle);
    }
}
