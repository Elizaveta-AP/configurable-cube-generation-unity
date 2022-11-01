using System.Collections;
using UnityEngine;

public class CubesGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    public static float GenerationFrequency = 2;
    private Vector3 _position;

    void Start()
    {
        _position = transform.position;
        StartCoroutine(Generation());
    }

    IEnumerator Generation()
    {
        while (true)
        {            
            Instantiate(_cube, _position, Quaternion.Euler(0,0,0));
            yield return new WaitForSeconds(GenerationFrequency);
        }
    }
}
