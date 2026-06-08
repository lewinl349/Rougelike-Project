using Godot;
using System;

public static class HelperMethods
{
    // Static helper methods

    // Non-recursive search
    public static T GetChildByType<T>(this Node node) where T : Node
    {
        for (int i = 0; i < node.GetChildCount(); i++)
        {
            Node child = node.GetChild(i);
            if (child is T childT)
            {
                return childT;
            }
        }

        return null;
    }
}
