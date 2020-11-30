using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{

    //•	Dummy loses health if attacked
    //•	Dead Dummy throws exception if attacked
    //•	Dead Dummy can give XP
    //•	Alive Dummy can't give XP


    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);

        //Act
        dummy.TakeAttack(10);

        //Assert

        var expectedResult = 90;
        var actualResult = dummy.Health;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test] 
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);

        //Act - Assert

        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
    }

    [Test]
    public void DeadDummyCanGiveXP()
    {
        // Arrange
        Dummy dummy = new Dummy(0 , 100);

        //Act //Assert
       
        var expectedResult = 100;

        var actualResult = dummy.GiveExperience();




        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void AliveDummyCantGiveXP()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);
        //Act //Assert

        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
