using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    List<GameObject> _cubes = new List<GameObject>();
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            foreach (var cube in _cubes)
            {
                Destroy(cube);
            }
            _cubes.Clear();
            for (var x = -50; x < 50; x++)
            {
                for (var y = 0; y < 20; y++)
                {
                    _cubes.Add(Instantiate(Cube, new Vector3(x, y + 0.5f, 5), Quaternion.identity));
                }
            }
        }
    }
}
