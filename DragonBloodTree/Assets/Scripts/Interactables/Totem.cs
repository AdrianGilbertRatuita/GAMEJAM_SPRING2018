using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Totem : IInteractable
{
    public bool Conditions()
    {

        if (OrbCount == Goal)
        {

            return true;

        }

        return false;

    }

    public void Execute()
    {

    }

}