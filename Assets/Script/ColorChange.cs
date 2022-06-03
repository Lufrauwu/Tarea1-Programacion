using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer = default;
    private GameObject _sceneLigth = default;
    private Light _changeLigth = default;


    private void Awake()
    {
        _meshRenderer = gameObject.GetComponent<MeshRenderer>();
        _sceneLigth = GameObject.FindWithTag("Ligth");
        _changeLigth = _sceneLigth.GetComponent<Light>();

    }
    private void Start()
    {
         _meshRenderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
    private void OnTriggerEnter(Collider other)
    {
        _changeLigth.color = GetComponent<Renderer>().material.color;
    }
    private void OnTriggerExit(Collider other)
    {
        _changeLigth.color = Color.white;
    }

}
