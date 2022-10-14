namespace DeploymentDemo.Test;
public class MikMak{
    public bool isTrue(bool input){
        return input;
    }
}

public class Tests
{

    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
        var mikMak = new MikMak();
        bool actual = mikMak.isTrue(true);
        bool expected = true;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test2()
    {
        var mikMak = new MikMak();
        bool actual = mikMak.isTrue(true);
        bool expected = false;
        Assert.AreNotEqual(expected, actual);
    }
    [Test]
    public void Test3()
    {
       var mikMak = new MikMak();
        bool actual = mikMak.isTrue(true);
        bool expected = false;
        Assert.AreNotEqual(expected, actual);
    }
    [Test]
    public void Test4()
    {
        var mikMak = new MikMak();
        bool actual = mikMak.isTrue(true);
        bool expected = true;
        Assert.AreEqual(expected, actual);
    }
}