using System;

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        
    }

    public void addNewData(T data)
    {
`       Data = data;
    }

    public void PrintAllData()
    {

    }
}
