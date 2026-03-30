using System;

namespace LearnCSharp.Delegates;

public class ThresholdReachedEventArgs
{
    public int threshold{get;set;}
    public DateTime TimeReached{get;set;}
    
}