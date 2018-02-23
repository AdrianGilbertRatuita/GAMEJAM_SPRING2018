using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestInteractable : IInteractable
{
    public bool Conditions()
    {

        return true;

    }

    public void Execute()
    {

        SceneManager.LoadScene(0);
       

    }

}