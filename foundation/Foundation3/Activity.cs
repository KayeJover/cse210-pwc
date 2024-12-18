using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    // Abstract methods for calculation
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Get summary of activity
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({_minutes} min)";
    }
}