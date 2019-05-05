namespace TSDB
{
    public interface ITsdb
    {
        QueryResult Query(Query query);
        void Insert(TimeSeries timeSeries);
    }
}
