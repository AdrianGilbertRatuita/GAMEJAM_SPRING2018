using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Totem : IInteractable
{
    public bool Conditions(Protagonist P)
    {

        return false;

    }

    public bool Conditions()
    {
        throw new NotImplementedException();
    }

    public void Execute()
    {

    }

}