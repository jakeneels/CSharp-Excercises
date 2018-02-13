using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void HavePartyTest()
        {
            Assert.IsFalse(_cigarParty.HaveParty(30, false));
            Assert.IsTrue(_cigarParty.HaveParty(50, false));
            Assert.IsTrue(_cigarParty.HaveParty(70, true));
            Assert.IsTrue(_cigarParty.HaveParty(500, true));
            Assert.IsFalse(_cigarParty.HaveParty(39, false));
        }

        [TestMethod]
        public void Lucky13()
        {
            Assert.IsTrue(_lucky13.GetLucky(new[] { 0, 2, 4 }));
            Assert.IsFalse(_lucky13.GetLucky(new[] { 1, 2, 3 }));
            Assert.IsFalse(_lucky13.GetLucky(new[] { 1, 2, 4 }));
            Assert.IsTrue(_lucky13.GetLucky(new[] { -1, 2, 4 }));
            Assert.IsTrue(_lucky13.GetLucky(new[] { -1, -3, 4 }));
        }
        [TestMethod]
        public void MaxEnd3()
        { 
           CollectionAssert.AreEqual(new[] { 3, 3, 3 }, _maxEnd3.MakeArray(new[] { 1, 2, 3 }));
           CollectionAssert.AreEqual(new[] { 11, 11, 11 }, _maxEnd3.MakeArray(new[] { 11, 5, 9 }));
           CollectionAssert.AreEqual(new[] { 3, 3, 3 }, _maxEnd3.MakeArray(new[] { 2, 11, 3 }));
           CollectionAssert.AreEqual(new[] { -3, -3, -3 }, _maxEnd3.MakeArray(new[] { -5, -4, -3 }));
        }
        [TestMethod]
        public void NonStart()
        {
            Assert.AreEqual("ellohere", _nonStart.GetPartialString("Hello", "There"));
            Assert.AreEqual("avaode", _nonStart.GetPartialString("Java", "code"));
            Assert.AreEqual("hotlava", _nonStart.GetPartialString("shotl", "java"));
        }
        [TestMethod]
        public void SameFirstLastTest()
        {
            Assert.IsFalse(_sameFirstLast.IsItTheSame(new[] { 1, 2, 3 }));
            Assert.IsTrue(_sameFirstLast.IsItTheSame(new[] { 1, 2, 3, 1 }));
            Assert.IsTrue(_sameFirstLast.IsItTheSame(new[] { 1, 2, 1 }));
            Assert.IsTrue(_sameFirstLast.IsItTheSame(new[] { 1 }));
            Assert.IsTrue(_sameFirstLast.IsItTheSame(new[] { -1 }));
            Assert.IsFalse(_sameFirstLast.IsItTheSame(new[] { -1,-2 }));
        }
        [TestMethod]
        public void GetBitsTest()
        {
            Assert.AreEqual("Hlo", _stringBits.GetBits("Hello"));
            Assert.AreEqual("H", _stringBits.GetBits("Hi"));
            Assert.AreEqual("Hello", _stringBits.GetBits("Heeololeo"));
            Assert.AreEqual("", _stringBits.GetBits(""));
        }
        [TestMethod]
        public void WordCountTest()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "ba", 2 }, {"black", 1 }, { "sheep", 1 } }, _wordCount.GetCount(new[] {"ba","ba","black","sheep" }));
        }


    }
}
