using System;

namespace RSCSharpClient.Client
{
    public class Exception_Sub6 : Exception
    {
        Class381 Parent { get; set; }

	    Exception_Sub6(Class381 parent, int p2, int p3) : base("")
        {
            Parent = parent;
        }
    }
}
