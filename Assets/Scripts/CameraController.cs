using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform square;

    private Vector3 tempPosition;

    [SerializeField]
    private float offsetX, offsetY;

    [SerializeField]
    protected float followSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!square){
            return;
        }

        float xTarget = square.position.x + offsetX;
        float yTarget = square.position.y + offsetY;

        float xNew = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        float yNew = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);

        transform.position = new Vector3(
            xNew,
            yNew,
            transform.position.z
        );
    }
}
