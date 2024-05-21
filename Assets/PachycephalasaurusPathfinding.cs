using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PachycephalasaurusPathfinder : MonoBehaviour
{
    Vector3 end_pos;
    Vector3 start_pos;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("On start");
        start_pos = transform.position;
        end_pos = transform.position + new Vector3(0, 0, 3.8f);
        Debug.Log(start_pos);
        Debug.Log(end_pos);
        // end_pos = transform.TransformPoint(Vector3.right * 10f);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("On update");
        // movementSpeed += 0.0001f;
        // transform.position = Vector3.Lerp(start_pos, end_pos, movementSpeed * Time.deltaTime);
        // transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3 (10, 0, 0) , movementSpeed);
        transform.position = Vector3.Lerp(transform.position, transform.position, movementSpeed);

        // Debug.Log(GameObject.Find("Pachycephalasaurus"));

        // while(GameObject.Find("").GetComponent<>)
    }
}
