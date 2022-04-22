namespace DashboardWebApi

{
    public class DataPagination(IEnumerable<T> data , int i , int len)
    {   
        //EX: page  [1] we want 10 results => (1-1)*10 => skip(0)take(10)
        Data = data.Skip((i - 1)*len).Take(len).ToList();
        Total = data.Count();


    }
    public int Total {get;set;};
    public int IEnumerable<T> Data {get; set;};





}