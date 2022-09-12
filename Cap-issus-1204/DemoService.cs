using DotNetCore.CAP;

namespace Cap_issus_1204;


public class DemoService :  ICapSubscribe
{
    public virtual string Add(int a, int b)
    {
        throw new NotImplementedException();
    }

    [CapSubscribe("demo")]
    public Task DemoSubscribe(DateTime time)
    {
        return Task.CompletedTask;
    }
}
