using AssemblyOne;

// 这个class被Access Specifiers借来测试private protected只能
// father
/// <summary>
/// 这个class被Access Specifiers借来测试private protected只能
/// FatherClass一个assembly的儿子才能用Id。这个class因为是儿子
/// 但是配置不一样，所以没有father members的访问权。
/// </summary>
public class ChildTest : FatherClass
{
    // private protected Id: 不能access Id!
    public void Display2()
    {
        Console.WriteLine(Id);
    }
}