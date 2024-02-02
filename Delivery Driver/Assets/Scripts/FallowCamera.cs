using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowCamera : MonoBehaviour
{
    [SerializeField] Transform driver;

    private void LateUpdate() //last thing happen at the frame
    {
        transform.position = new Vector3(driver.position.x, driver.position.y, transform.position.z);
    }
}
