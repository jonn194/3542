﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyManager : MonoBehaviour
{

    public GameObject galaxy;

    public List<GameObject> galaxies = new List<GameObject>();

	
    void Awake()
    {
        var newGal = Instantiate(galaxy, new Vector3(0, -180, Screen.height + Screen.height / 2), Quaternion.identity);
        galaxies.Add(newGal);
    }

	void Update ()
    {
        ManageGalaxies();
    }

    void ManageGalaxies()
    {
        for(int i = 0; i < galaxies.Count; i++)
        {
            if(galaxies[i].gameObject.transform.position.z <= -Screen.height - Screen.height/2)
            {
                var oldGal = galaxies[i].gameObject;
               galaxies.Remove(galaxies[i]);
                Destroy(oldGal);


               var newGal = Instantiate(galaxy, new Vector3(0, -180, Screen.height + Screen.height / 2), Quaternion.identity);
               galaxies.Add(newGal);
            }
        }
    }
}
