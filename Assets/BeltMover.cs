using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMover : MonoBehaviour
{
    [SerializeField] RectTransform beltRectTransform;
    [SerializeField] int beltMovingSpeed;
    float beltReapeatBoundry;
    // Start is called before the first frame update
    void Start()
    {
        beltReapeatBoundry = (beltRectTransform.rect.width) / 4;
       // print(transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * beltMovingSpeed);
        if(transform.localPosition.x >= beltReapeatBoundry)
        {
            transform.localPosition = new Vector3(0, transform.localPosition.y, 0);
        }
    }
}
