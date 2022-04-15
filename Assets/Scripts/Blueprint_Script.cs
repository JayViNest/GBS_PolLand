using UnityEngine;

public class Blueprint_Script : MonoBehaviour
{
    [SerializeField] private GameObject hangar;
    [SerializeField] private float maxDistance = 50000.0f;

    private RaycastHit hit;
    private Camera camera;

    private void Start()
    {
        camera = Camera.main;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                Instantiate(hangar, hit.point, Quaternion.identity);
            }
        }
    }
}
