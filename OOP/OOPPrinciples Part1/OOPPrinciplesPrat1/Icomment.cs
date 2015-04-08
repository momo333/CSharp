namespace OOPPrinciplesPrat1
{
    using System;
    using System.Collections.Generic;
    public interface IComment
    {
        List<string> Comments { get;}
        void AddCommment(string comment);
    } 
}
