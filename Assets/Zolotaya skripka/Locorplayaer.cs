using UnityEngine;

public class Locorplayaer : MonoBehaviour
{

    public LayerMask LayerMaskScan;
    public AudioSource source;
    private GameObject Podobran;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, Mathf.Infinity, LayerMaskScan);
            if (hit)
            {
                Destroy(hit.collider.gameObject);
                source.Play();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, Mathf.Infinity, LayerMaskScan);
            if (hit && Podobran == null)
            {
                if (hit.collider.transform.TryGetComponent(out FollowMe fm))
                {
                    fm.enabled = true;
                    Podobran = hit.collider.gameObject;
                }
            }
        }
        if (Input.GetMouseButtonUp(1))
        {
            if (Podobran != null && Podobran.TryGetComponent(out FollowMe fm))
            {
                fm.enabled = false;
                Podobran = null;
            }
        }
    }
}
