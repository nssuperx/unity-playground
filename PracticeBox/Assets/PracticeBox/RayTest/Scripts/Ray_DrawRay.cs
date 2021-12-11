using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_DrawRay : MonoBehaviour {
    [SerializeField] private float distance = 100; // 飛ばす&表示するRayの長さ
    [SerializeField] private float duration = 10; // 表示期間（秒）

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.red, duration, false);

            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit, distance)) {
                GameObject hitObject = hit.collider.gameObject;
                string objectname = hitObject.GetComponent<SetSymbol>().GetSymbol();
                Debug.Log(objectname);
            }
        }

    }


}
