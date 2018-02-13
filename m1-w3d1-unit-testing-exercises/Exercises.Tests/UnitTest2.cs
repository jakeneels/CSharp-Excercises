using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class UnitTest2
    {
        AnimalGroupName _animalGroupName = new AnimalGroupName();
        CigarParty _cigarParty = new CigarParty();
        Lucky13 _lucky13 = new Lucky13();
        MaxEnd3 _maxEnd3 = new MaxEnd3();
        NonStart _nonStart = new NonStart();
        SameFirstLast _sameFirstLast = new SameFirstLast();
        StringBits _stringBits = new StringBits();
        WordCount _wordCount = new WordCount();

        [TestMethod]
        public void AnimalGroupName()
        {
            Assert.AreEqual("Crash",       _animalGroupName.GetHerd("rhino"));
            Assert.AreEqual("Tower",     _animalGroupName.GetHerd("giraffe"));
            Assert.AreEqual("Herd",    _animalGroupName.GetHerd("elephant"));
            Assert.AreEqual("Pride",        _animalGroupName.GetHerd("lion"));
            Assert.AreEqual("Murder",        _animalGroupName.GetHerd("crow"));
            Assert.AreEqual("Kit",      _animalGroupName.GetHerd("pigeon"));
            Assert.AreEqual("Pat",    _animalGroupName.GetHerd("flamingo"));
            Assert.AreEqual("Herd",        _animalGroupName.GetHerd("deer"));
            Assert.AreEqual("Pack",         _animalGroupName.GetHerd("dog"));
            Assert.AreEqual("Float",   _animalGroupName.GetHerd("crocodile"));
            //Assert.AreEqual("Float",   _animalGroupName.GetHerd("CROCODILE"));
        }
    }
}
